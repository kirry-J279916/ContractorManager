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

        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddContractorButton_Click(object sender, RoutedEventArgs e)
        {
            // -- Link Contractor properties to UI elements.
            string FirstName = FirstNameTextBox.Text;
            string LastName = LastNameTextBox.Text;
            DateTime StartDate = DateTime.Now;
            string HourlyWage = HourlyWageTextBox.Text;


            if (!decimal.TryParse(HourlyWage, out decimal HourlyWageDecimal))
            {
                MessageBox.Show("Please enter a valid hourly wage.");
                return;
            }


            Contractor contractor = new Contractor(FirstName, LastName, StartDate, HourlyWageDecimal);

            // Call method to add contractor.
            Recruitment.AddContractor(contractor);

            // Show in list box.
            ContractorsListBox.Items.Add(contractor);
        }
    }
}