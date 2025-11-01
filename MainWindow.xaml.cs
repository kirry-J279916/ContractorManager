using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContractorManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // -- Instantiate RecruitmentSystem.
        RecruitmentSystem Recruitment = new RecruitmentSystem();



        public MainWindow()
        {
            InitializeComponent();
        }


        private void AddContractorButton_Click(object sender, RoutedEventArgs e)
        {
            // -- Link Contractor properties to UI elements.
            string FirstName = FirstNameTextBox.Text;
            string LastName = LastNameTextBox.Text;
            DateTime StartDate = DateTime.Now;
            string HourlyWage = HourlyWageTextBox.Text;

            // -- Validate hourly wage input is number.
            if (!decimal.TryParse(HourlyWage, out decimal HourlyWageDecimal))
            {
                MessageBox.Show("Please enter a valid hourly wage.");
                return;
            }

            Contractor contractor = new Contractor(FirstName, LastName, StartDate, HourlyWageDecimal);

            // -- Call method to add contractor.
            Recruitment.AddContractor(contractor);

            // -- Show in list box.
            ContractorsListBox.Items.Add(contractor);
        }


        private void RemoveContractorButton_Click(object sender, RoutedEventArgs e)
        {
            // -- Casting ListBox item to Contractor type.
            Contractor contractor = (Contractor)ContractorsListBox.SelectedItem;

            if (contractor == null)
            {
                MessageBox.Show("Must select a contractor first");
            }
            else
            {
                // -- Call method to remove contractor.
                Recruitment.RemoveContractor(contractor);

                // -- Remove from list box.
                ContractorsListBox.Items.Remove(contractor);
            }
        }




        private void AddJobButton_Click(object sender, RoutedEventArgs e)
        {
            // -- Link Job properties to UI elements.
            string Title = JobTitleTextBox.Text;
            string Cost = JobCostTextBox.Text;
            DateTime CreatedDate = DateTime.Now;
            bool Completed = false;



            // -- Validate cost input is number.
            if (!decimal.TryParse(Cost, out decimal CostDecimal))
            {
                MessageBox.Show("Please enter a valid cost.");
                return;
            }


            Job job = new Job(Title, CostDecimal, CreatedDate, false);

            // -- Call method to add job.
            Recruitment.AddJob(job);

            // -- Show in list box.
            JobsListBox.Items.Add(job);


        }

        private void AssignJobButton_Click(object sender, RoutedEventArgs e)
        {
            // -- Casting ListBox item to class Object type.
            Contractor selectedContractor = (Contractor)ContractorsListBox.SelectedItem;
            Job selectedJob = (Job)JobsListBox.SelectedItem;

            if (selectedContractor == null || selectedJob == null)
            {
                MessageBox.Show("Please select a contractor and a job to assign them.");
                return;
            }

            // -- Call method to assign Contractor to Job.
            Recruitment.AssignJob(selectedContractor, selectedJob);

        }

        private void GetContractorButton_Click(object sender, RoutedEventArgs e)
        {
            //string ContractorsString = Recruitment.GetContractors();
            //Recruitment.GetContractors();

            // -- Show in list box.
            //JobsListBox.Items.Add(ContractorsString);


            //ContractorsListBox.Items.Add(Recruitment.GetContractors());


            //ContractorsListBox.Items.Clear();

            List<Contractor> ContractorsList = Recruitment.GetContractors();

            foreach (Contractor contractor in ContractorsList)
            {
                ContractorsListBox.Items.Add(contractor);
            }

            //MessageBox.Show($"{Recruitment.GetContractors}");
        }
    }
}