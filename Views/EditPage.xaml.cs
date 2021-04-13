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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Controllers.ClientsController clientsController = new Controllers.ClientsController();
        public EditPage(string login, string password)
        {
            InitializeComponent();

            foreach (var item in clientsController.ClientsZxc(password))
            {
                string name = item.name + " (Изменить)";

                FirstNameInput.Text = item.name;
                LastNameInput.Text = item.surname;
                PatronymicInput.Text = item.patronymic;
                AddressInput.Text = item.address;
                WorkplaceInput.Text = item.workplace;
                StudyplaceInput.Text = item.studyplace;
                PhoneInput.Text = item.phone;
                LoginInput.Text = item.login;
                PasswordInput.Password = item.password;

                //string[] words = name.Split(' ');

                //foreach (var word in words)
                //{
                //    string zxc = word;

                //    FirstNameInput.Text = zxc;
                //}

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new MenuAdminPage());
        }

        private void FirstNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            bool trigger = check.CheckName(FirstNameInput.Text);
            string word = FirstNameInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (trigger && word != item.name)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;

                }
            }
        }

        private void LastNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            bool trigger = check.CheckName(LastNameInput.Text);
            string word = LastNameInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (trigger && word != item.surname)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }

        private void PatronymicInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            bool trigger = check.CheckName(PatronymicInput.Text);
            string word = PatronymicInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (trigger && word != item.patronymic)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }

        private void AddressInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            bool trigger = check.CheckAddress(AddressInput.Text);
            string word = AddressInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (trigger && word != item.address)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }

        private void WorkplaceInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            string word = WorkplaceInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (word != item.workplace)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }

        private void StudyplaceInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            string word = StudyplaceInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (word != item.studyplace)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }

        private void PhoneInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            bool trigger = check.CheckPhone(PhoneInput.Text);
            string word = PhoneInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (trigger && word != item.phone)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }

        private void LoginInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringCheck check = new StringCheck();

            bool trigger = check.CheckLogin(LoginInput.Text);
            string word = LoginInput.Text;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (trigger && word != item.login)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }

        private void PasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            StringCheck check = new StringCheck();

            bool trigger = check.CheckPassword(PasswordInput.Password);
            string word = PasswordInput.Password;

            foreach (var item in clientsController.ClientsInfoOutput())
            {

                if (trigger && word != item.password)
                {
                    SaveBtn.Background = Brushes.Green;
                    SaveBtn.IsEnabled = true;
                }
                else
                {
                    SaveBtn.Background = Brushes.Gray;
                    SaveBtn.IsEnabled = false;
                }
            }
        }
    }
}
