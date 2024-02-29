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
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            string StudentNumberInput = TextStudentNumber.Text;
            string StudentProgramInput = TextStudentProgram.Text;
            string StudentYearInput = TextStudentYear.Text;

            try
            {
                SqlConnection connAdd = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("AddStudent", connAdd);
                connAdd.Open();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Student_Number", SqlDbType.VarChar, (10)).Value = StudentNumberInput;
                adapter.SelectCommand.Parameters.Add("@Year", SqlDbType.Int).Value = StudentYearInput;
                adapter.SelectCommand.Parameters.Add("@Program_ID", SqlDbType.VarChar, (200)).Value = StudentProgramInput;
                adapter.SelectCommand.ExecuteNonQuery();
                connAdd.Close();
                MessageBox.Show("A Student was added to the database.");
            }
            catch (Exception)
            {
                MessageBox.Show("Adding a Student Failed.");
            }

            TextStudentID.Text = "";
            TextStudentNumber.Text = "";
            TextStudentProgram.Text = "";
            TextStudentYear.Text = "";
        }
        
        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {
            string StudentIDInput = TextStudentID.Text;
            string StudentNumberInput = TextStudentNumber.Text;
            string StudentProgramInput = TextStudentProgram.Text;
            string StudentYearInput = TextStudentYear.Text;

            try
            {
                SqlConnection connEdit = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("EditStudent", connEdit);
                connEdit.Open();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Student_ID", SqlDbType.Int).Value = StudentIDInput;
                adapter.SelectCommand.Parameters.Add("@Student_Number", SqlDbType.VarChar, (10)).Value = StudentNumberInput;
                adapter.SelectCommand.Parameters.Add("@Year", SqlDbType.Int).Value = StudentYearInput;
                adapter.SelectCommand.Parameters.Add("@Program_ID", SqlDbType.VarChar, (200)).Value = StudentProgramInput;
                adapter.SelectCommand.ExecuteNonQuery();
                connEdit.Close();
                MessageBox.Show("A Student with ID " + StudentIDInput + " was edited.");
            }
            catch (Exception)
            {
                MessageBox.Show("Editing a Student Failed.");
            }

            TextStudentID.Text = "";
            TextStudentNumber.Text = "";
            TextStudentProgram.Text = "";
            TextStudentYear.Text = "";
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            string StudentIDInput = TextStudentID.Text;

            try
            {
                SqlConnection connDel = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("DeleteStudent", connDel);
                connDel.Open();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Student_ID", SqlDbType.Int).Value = StudentIDInput;
                adapter.SelectCommand.ExecuteNonQuery();
                connDel.Close();
                MessageBox.Show("A Student was deleted.");
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting a Student Failed.");
            }

            TextStudentID.Text = "";
            TextStudentNumber.Text = "";
            TextStudentProgram.Text = "";
            TextStudentYear.Text = "";
        }
    }
}

