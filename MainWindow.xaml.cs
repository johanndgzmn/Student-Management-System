using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _CPE106_FOPI01_DE_GUZMAN_MOD1_QUIZ;
using _CPE106_FOPI01_DE_GUZMAN_MOD1_QUIZ.ViewModels;

namespace _CPE106_FOPI01_DE_GUZMAN_MOD1_QUIZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_Application(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Person_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new PersonViewModel();
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new StudentViewModel();
        }

        private void AllRecords_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AllRecordsViewModel();
        }

        private void SpecificRecord_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SpecificRecordViewModel();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure that you want to delete ALL records?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                SqlConnection connect = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("Delete_All", connect);
                connect.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("All values were deleted.");
            }
        }
    }
}
