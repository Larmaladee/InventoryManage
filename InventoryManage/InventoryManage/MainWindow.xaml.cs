using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace InventoryManage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string server;
        string db;
        public MainWindow()
        {
            InitializeComponent();
            server = "DESKTOP-FSRPCA1\\SERVERR";
            db = "InventoryProgramm";
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1} ; Integrated Security = True;", server, db));
            connection.Open();
            SqlCommand Role_id = new SqlCommand($"select [id_Role] from dbo.[Users] where Login = '{Login.Text}' and Password = '{Password.Text}'", connection);
            try
            {
                if(Role_id.ExecuteScalar() == null)
                {
                    MessageBox.Show("Введены неверные данные");

                }
                else if (Role_id.ExecuteScalar().ToString() == "1")
                {
                    EmpMenu empMenu = new EmpMenu(Login.Text);
                    empMenu.Show();
                    this.Close();
                }
                else if (Role_id.ExecuteScalar().ToString() == "2")
                {

                    RevizMenu revizMenu = new RevizMenu();
                    revizMenu.Show();
                    this.Close();
                }
                else if (Role_id.ExecuteScalar().ToString() == "3")
                {

                    TehMenu tehMenu = new TehMenu();
                    tehMenu.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }
    }
}
