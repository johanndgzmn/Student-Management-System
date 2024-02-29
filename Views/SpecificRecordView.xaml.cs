using System;
using System.Collections.Generic;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _CPE106_FOPI01_DE_GUZMAN_MOD1_QUIZ.Views
{
    /// <summary>
    /// Interaction logic for SpecificRecordView.xaml
    /// </summary>
    public partial class SpecificRecordView : UserControl
    {
        public SpecificRecordView()
        {
            InitializeComponent();
        }

        private void ID_Click(object sender, RoutedEventArgs e)
        {
            string idInput = TextInputID.Text;
            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
            SqlCommand command = new SqlCommand("ID_Click", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Person_ID", idInput);

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string lastName = reader.GetString(0);
                    string givenName = reader.GetString(1);
                    string middleName = reader.GetString(2);
                    string studentNumber = reader.GetString(3);
                    string programDescription = reader.GetString(4);
                    int year = reader.GetInt32(5);
                    int personID2 = reader.GetInt32(6);

                    TextLastName.Text = lastName;
                    TextGivenName.Text = givenName;
                    TextMiddleName.Text = middleName;
                    TextStudentNumber.Text = studentNumber;
                    TextStudentProgram.Text = programDescription;
                    TextStudentYear.Text = year.ToString();
                    TextStudentPerson.Text = personID2.ToString();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void StudentNumber_Click(object sender, RoutedEventArgs e)
        {
            string studentNumberInput = TextStudentNumber.Text;

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
            SqlCommand command = new SqlCommand("StudentNum_Click", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Student_Number", studentNumberInput);

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string lastName = reader.GetString(0);
                    string givenName = reader.GetString(1);
                    string middleName = reader.GetString(2);
                    string studentNumber = reader.GetString(3);
                    string programDescription = reader.GetString(4);
                    int year = reader.GetInt32(5);
                    int personID2 = reader.GetInt32(6);

                    TextInputID.Text = personID2.ToString();
                    TextLastName.Text = lastName;
                    TextGivenName.Text = givenName;
                    TextMiddleName.Text = middleName;
                    TextStudentNumber.Text = studentNumber;
                    TextStudentProgram.Text = programDescription;
                    TextStudentYear.Text = year.ToString();
                    TextStudentPerson.Text = personID2.ToString();
                }
            }
            reader.Close();
            conn.Close();
        }
    }
}
