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
    /// Логика взаимодействия для MenuAdminPage.xaml
    /// </summary>
    public partial class MenuAdminPage : Page
    {
        Controllers.BooksController booksController = new Controllers.BooksController();
        Controllers.ClientsController clientsController = new Controllers.ClientsController();
        public MenuAdminPage()
        {
            InitializeComponent();
            BookDataGrid.ItemsSource = booksController.BooksInfoOutput();
            ClientDataGrid.ItemsSource = clientsController.ClientsInfoOutput();
        }

        private void SearchAdminBooksBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            BookDataGrid.ItemsSource = booksController.BooksMatchUpInfoOutput(SearchAdminBooksBox.Text);
        }

        private void SearchAdminReadersBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ClientDataGrid.ItemsSource = clientsController.ClientsMatchUpInfoOutput(SearchAdminReadersBox.Text);
        }
    }
}
