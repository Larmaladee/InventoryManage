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
using System.Data.Sql;

namespace InventoryManage
{
    /// <summary>
    /// Логика взаимодействия для TehMenu.xaml
    /// </summary>
    public partial class TehMenu : Window
    {
        string server;
        string db;
        int id;
        int idStat;
        public TehMenu()
        {
            InitializeComponent();
            server = "DESKTOP-FSRPCA1\\SERVERR";
            db = "InventoryProgramm";
            SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", server, db));
            connection.Open();
            SqlCommand commaand = new SqlCommand(" SELECT [ApplicationStatus].[ApplicationStat] as 'Статус', [Equipment].[Name] as 'Название', [Classes].[Number] as 'Кабинет',[Application].[Description] as 'Описание' FROM [Application] INNER JOIN dbo.[Equipment] ON [Application].[id_Equipment] = [Equipment].[Equipment_id] INNER JOIN dbo.[Classes] ON [Equipment].[id_Classes] = [Classes].[Classes_id] INNER JOIN dbo.[ApplicationStatus] ON [Application].[id_ApplicationStatus] = [ApplicationStatus].[ApplicationStatus_id];", connection);
            DataTable datattbp = new DataTable();
            datattbp.Load(commaand.ExecuteReader());
            Applications.ItemsSource = datattbp.DefaultView;
            fillCombobox();
            classes.Items.Add("");
            status.Items.Add("");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow empMenu = new MainWindow();
            empMenu.Show();
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Applications_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)Applications.SelectedItems[0];
                SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1} ; Integrated Security = True;", server, db));
                connection.Open();
                SqlCommand idCommant = new SqlCommand($" select [Application_id] from[dbo].[Application] where [Description] = '{dataRow[3]}'", connection);
                id = (int)idCommant.ExecuteScalar();
            }
            catch
            {

            }
        }

        private void status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", server, db));
            connection.Open();
            SqlCommand commaand = new SqlCommand(string.Format(" SELECT [ApplicationStatus].[ApplicationStat] as 'Статус', [Equipment].[Name] as 'Название', [Classes].[Number] as 'Кабинет',[Application].[Description] as 'Описание' FROM [Application] INNER JOIN dbo.[Equipment] ON [Application].[id_Equipment] = [Equipment].[Equipment_id] INNER JOIN dbo.[Classes] ON [Equipment].[id_Classes] = [Classes].[Classes_id] INNER JOIN dbo.[ApplicationStatus] ON [Application].[id_ApplicationStatus] = [ApplicationStatus].[ApplicationStatus_id] where [ApplicationStat] = '{0}'", status.SelectedItem), connection);
            DataTable datattbp = new DataTable();
            datattbp.Load(commaand.ExecuteReader());
            Applications.ItemsSource = datattbp.DefaultView;

            if (status.SelectedItem.ToString() == "")
            {

                 commaand = new SqlCommand(" SELECT [ApplicationStatus].[ApplicationStat] as 'Статус', [Equipment].[Name] as 'Название', [Classes].[Number] as 'Кабинет',[Application].[Description] as 'Описание' FROM [Application] INNER JOIN dbo.[Equipment] ON [Application].[id_Equipment] = [Equipment].[Equipment_id] INNER JOIN dbo.[Classes] ON [Equipment].[id_Classes] = [Classes].[Classes_id] INNER JOIN dbo.[ApplicationStatus] ON [Application].[id_ApplicationStatus] = [ApplicationStatus].[ApplicationStatus_id];", connection);
                 datattbp = new DataTable();
                datattbp.Load(commaand.ExecuteReader());
                Applications.ItemsSource = datattbp.DefaultView;
            }
        }

        private void class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", server, db));
            connection.Open();
            SqlCommand commaand = new SqlCommand(string.Format(" SELECT [ApplicationStatus].[ApplicationStat] as 'Статус', [Equipment].[Name] as 'Название', [Classes].[Number] as 'Кабинет',[Application].[Description] as 'Описание' FROM [Application] INNER JOIN dbo.[Equipment] ON [Application].[id_Equipment] = [Equipment].[Equipment_id] INNER JOIN dbo.[Classes] ON [Equipment].[id_Classes] = [Classes].[Classes_id]\r\nINNER JOIN dbo.[ApplicationStatus] ON [Application].[id_ApplicationStatus] = [ApplicationStatus].[ApplicationStatus_id] where [Number] = '{0}'", classes.SelectedItem), connection);
            DataTable datattbp = new DataTable();
            datattbp.Load(commaand.ExecuteReader());
            Applications.ItemsSource = datattbp.DefaultView;

            if (classes.SelectedItem.ToString() == "")
            {

                commaand = new SqlCommand(" SELECT [ApplicationStatus].[ApplicationStat] as 'Статус', [Equipment].[Name] as 'Название', [Classes].[Number] as 'Кабинет',[Application].[Description] as 'Описание' FROM [Application] INNER JOIN dbo.[Equipment] ON [Application].[id_Equipment] = [Equipment].[Equipment_id] INNER JOIN dbo.[Classes] ON [Equipment].[id_Classes] = [Classes].[Classes_id]\r\nINNER JOIN dbo.[ApplicationStatus] ON [Application].[id_ApplicationStatus] = [ApplicationStatus].[ApplicationStatus_id];", connection);
                datattbp = new DataTable();
                datattbp.Load(commaand.ExecuteReader());
                Applications.ItemsSource = datattbp.DefaultView;
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            if(statusChange.Text == "")
            {
                MessageBox.Show("Выбирете статус");
            }
            if(id == 0)
            {
                MessageBox.Show("Выбирете заявку");
            }
            if(statusChange.Text != "" && id != 0)
            {
                SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", server, db));
                connection.Open();
                SqlCommand idUserCommant = new SqlCommand($" select [ApplicationStatus_id] from[dbo].[ApplicationStatus] where [ApplicationStat] = '{statusChange.Text}'", connection);
                idStat = (int)idUserCommant.ExecuteScalar();

                SqlCommand commaand = new SqlCommand($"UPDATE [Application] SET [id_ApplicationStatus] = '{idStat}' WHERE [Application_id] = '{id}'", connection);
                commaand.ExecuteNonQuery();
                 commaand = new SqlCommand(" SELECT [ApplicationStatus].[ApplicationStat] as 'Статус', [Equipment].[Name] as 'Название', [Classes].[Number] as 'Кабинет',[Application].[Description] as 'Описание' FROM [Application] INNER JOIN dbo.[Equipment] ON [Application].[id_Equipment] = [Equipment].[Equipment_id] INNER JOIN dbo.[Classes] ON [Equipment].[id_Classes] = [Classes].[Classes_id] INNER JOIN dbo.[ApplicationStatus] ON [Application].[id_ApplicationStatus] = [ApplicationStatus].[ApplicationStatus_id];", connection);
                DataTable datattbp = new DataTable();
                datattbp.Load(commaand.ExecuteReader());
                Applications.ItemsSource = datattbp.DefaultView;
            }

            
        }
        /// <summary>
        /// 
        /// </summary>
        public void fillCombobox()
        {
            SqlConnection connection = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;", server, db));
            connection.Open();
            SqlCommand commandSelectStatus = new SqlCommand("select [ApplicationStat] from [ApplicationStatus]", connection);
            DataTable resTable = new DataTable();
            resTable.Load(commandSelectStatus.ExecuteReader());
            foreach (DataRow dataRow in resTable.Rows)
            {
                status.Items.Add(string.Format("{0}", dataRow[0]));
                statusChange.Items.Add(string.Format("{0}", dataRow[0]));
            }

            SqlCommand commaandd = new SqlCommand("select [Number] from [Classes]", connection);
            DataTable resTablee = new DataTable();
            resTablee.Load(commaandd.ExecuteReader());
            foreach (DataRow dataRow in resTablee.Rows)
            {
                classes.Items.Add(string.Format("{0}", dataRow[0]));
            }
        }
    }
}
