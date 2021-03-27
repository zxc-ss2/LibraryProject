using StringCheckLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryProject.Views
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        Controllers.ClientsController clientsController = new Controllers.ClientsController();
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void LoginBtnClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthorizationPage());
        }

        private void StartBtnClick(object sender, RoutedEventArgs e)
        {
            StringCheck check = new StringCheck();

            clientsController.AddNewUser(FirstNameInput.Text, LastNameInput.Text, PatronymicInput.Text, Convert.ToDateTime(DateInput.SelectedDate), AddressInput.Text, WorkplaceInput.Text, StudyplaceInput.Text, PhoneInput.Text, LoginInput.Text, PasswordInput.Password);
        }
    }
}
