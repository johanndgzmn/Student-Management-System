using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace _CPE106_FOPI01_DE_GUZMAN_MOD1_QUIZ.Views
{
    /// <summary>
    /// Interaction logic for AllRecordsView.xaml
    /// </summary>
    public partial class AllRecordsView : UserControl
    {
        public AllRecordsView()
        {
            InitializeComponent();
            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("ViewStudentDetailed", conn);
            conn.Open();

            DataTable dataTable = new System.Data.DataTable();

            adapter.Fill(dataTable);

            dataGrid.ItemsSource = dataTable.DefaultView;
            conn.Close();
        }
    }
}
