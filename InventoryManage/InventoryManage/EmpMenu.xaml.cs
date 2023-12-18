using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;

namespace InventoryManage
{
    /// <summary>
    /// Логика взаимодействия для EmpMenu.xaml
    /// </summary>
    public partial class EmpMenu : Window
    {
        string server;
        string db;
        int id;
        string login;
        int userID;
        public EmpMenu(string login)
        {
            InitializeComponent();
            server = "DESKTOP-FSRPCA1\\SERVERR";
            db = "InventoryProgramm";
            SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", server, db));
            connection.Open();
            SqlCommand commaand = new SqlCommand("   Select [Name] as 'Название оборудования',[SerialNumber] as 'Серийный номер',[Number] as 'Кабинет',[EquipmentStat] as 'Статус',[Category] as 'Категория'  From [dbo].[Equipment] inner join dbo.[Classes] on id_Classes=[Classes_id] inner join dbo.[EquipmentStatus] on [id_EquipmentStatus]=[EquipmentStatus_id] inner join dbo.[EquipmentCategory] on [id_EquipmentCategory]=[EquipmentCategory_id]", connection);
            DataTable datattbp = new DataTable();
            datattbp.Load(commaand.ExecuteReader());
            Enviroment.ItemsSource = datattbp.DefaultView;
            this.login = login;
            SqlCommand idUserCommant = new SqlCommand($" select [User_id] from[dbo].[Users] where [Login] = '{login}'", connection);
            userID = (int)idUserCommant.ExecuteScalar();

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow empMenu = new MainWindow();
            empMenu.Show();
            this.Close();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", server, db));
            connection.Open();
            SqlCommand commaand = new SqlCommand(string.Format(" Select [Name] as 'Название оборудования',[SerialNumber] as 'Серийный номер',[Number] as 'Кабинет',[EquipmentStat] as 'Статус',[Category] as 'Категория'  From [dbo].[Equipment] inner join dbo.[Classes] on id_Classes=[Classes_id] inner join dbo.[EquipmentStatus] on [id_EquipmentStatus]=[EquipmentStatus_id] inner join dbo.[EquipmentCategory] on [id_EquipmentCategory]=[EquipmentCategory_id] where [Name] like '%{0}%' or [SerialNumber] like '%{0}%' or [Number] like '%{0}%' or [EquipmentStat] like '%{0}%' or [Category] like '%{0}%'", search.Text), connection);
            DataTable datattbp = new DataTable();
            datattbp.Load(commaand.ExecuteReader());
            Enviroment.ItemsSource = datattbp.DefaultView;

            if(search.Text == "")
            {
                 commaand = new SqlCommand("   Select [Name] as 'Название оборудования',[SerialNumber] as 'Серийный номер',[Number] as 'Кабинет',[EquipmentStat] as 'Статус',[Category] as 'Категория'  From [dbo].[Equipment] inner join dbo.[Classes] on id_Classes=[Classes_id] inner join dbo.[EquipmentStatus] on [id_EquipmentStatus]=[EquipmentStatus_id] inner join dbo.[EquipmentCategory] on [id_EquipmentCategory]=[EquipmentCategory_id]", connection);
                 datattbp = new DataTable();
                datattbp.Load(commaand.ExecuteReader());
                Enviroment.ItemsSource = datattbp.DefaultView;
            }
        }

        private void Application_Click(object sender, RoutedEventArgs e)
        {
           if(id == null)
            {
                MessageBox.Show("Выбирете оборудование");
            }
            if (Discrip.Text == "")
            {
                MessageBox.Show("Напишите подробности заявки");
            }
            if(id != null && Discrip.Text != "")
            {
                DataRowView dataRow = (DataRowView)Enviroment.SelectedItems[0];
                SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1} ; Integrated Security = True;", server, db));
                connection.Open();
                SqlCommand commaand = new SqlCommand($"insert into dbo.[Application]([id_User],[id_ApplicationStatus],[id_Equipment],[Description]) values({userID},{1},{id},'{Discrip.Text}')", connection);
                commaand.ExecuteNonQuery();
                MessageBox.Show("Заявка создана");
                commaand = new SqlCommand($"UPDATE [Equipment] SET [id_EquipmentStatus] = 4 WHERE [Equipment_id] = '{id}'", connection);
                commaand.ExecuteNonQuery();
                commaand = new SqlCommand("   Select [Name] as 'Название оборудования',[SerialNumber] as 'Серийный номер',[Number] as 'Кабинет',[EquipmentStat] as 'Статус',[Category] as 'Категория'  From [dbo].[Equipment] inner join dbo.[Classes] on id_Classes=[Classes_id] inner join dbo.[EquipmentStatus] on [id_EquipmentStatus]=[EquipmentStatus_id] inner join dbo.[EquipmentCategory] on [id_EquipmentCategory]=[EquipmentCategory_id]", connection);
                DataTable datattbp = new DataTable();
                datattbp.Load(commaand.ExecuteReader());
                Enviroment.ItemsSource = datattbp.DefaultView;
            }
        }

        private void Enviroment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)Enviroment.SelectedItems[0];
                SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1} ; Integrated Security = True;", server, db));
                connection.Open();
                SqlCommand idCommant = new SqlCommand($" select[Equipment_id] from[dbo].[Equipment] where[SerialNumber] = '{dataRow[1]}'", connection);
                id = (int)idCommant.ExecuteScalar();
            }
            catch
            {

            }

        }
    }
}
