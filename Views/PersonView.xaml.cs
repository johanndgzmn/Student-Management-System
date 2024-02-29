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
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : UserControl
    {
        public PersonView()
        {
            InitializeComponent();
        }
        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            string LastNameInput = TextLastName.Text;
            string MiddleNameInput = TextMiddleName.Text;
            string GivenNameInput = TextGivenName.Text;
            try
            {
                SqlConnection connAdd = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("AddPerson", connAdd);
                connAdd.Open();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Last_name", SqlDbType.VarChar, (100)).Value = LastNameInput;
                adapter.SelectCommand.Parameters.Add("@Given_Name", SqlDbType.VarChar, (100)).Value = GivenNameInput;
                adapter.SelectCommand.Parameters.Add("@Middle_Name", SqlDbType.VarChar, (100)).Value = MiddleNameInput;
                adapter.SelectCommand.ExecuteNonQuery();
                connAdd.Close();
                MessageBox.Show("A Person was added to the database.");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Adding a Person Failed.");
            }
            TextID.Text = "";
            TextLastName.Text = "";
            TextMiddleName.Text = "";
            TextGivenName.Text = "";
        }

        private void EditPerson_Click(object sender, RoutedEventArgs e)
        {
            string IDInput = TextID.Text;
            string LastNameInput = TextLastName.Text;
            string MiddleNameInput = TextMiddleName.Text;
            string GivenNameInput = TextGivenName.Text;

            try
            {
                SqlConnection connEdit = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("EditPerson", connEdit);
                connEdit.Open();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Person_ID", SqlDbType.Int).Value = IDInput;
                adapter.SelectCommand.Parameters.Add("@Last_name", SqlDbType.VarChar, (100)).Value = LastNameInput;
                adapter.SelectCommand.Parameters.Add("@Given_Name", SqlDbType.VarChar, (100)).Value = GivenNameInput;
                adapter.SelectCommand.Parameters.Add("@Middle_Name", SqlDbType.VarChar, (100)).Value = MiddleNameInput;
                adapter.SelectCommand.ExecuteNonQuery();
                connEdit.Close();
                MessageBox.Show("A Person with ID " + IDInput + " was edited.");
            }
            catch(System.Exception)
            {
                MessageBox.Show("Editing a Person Failed.");
            }
            TextID.Text = "";
            TextLastName.Text = "";
            TextMiddleName.Text = "";
            TextGivenName.Text = "";
        }

        private void DeletePerson_Click(object sender, RoutedEventArgs e)
        {
            string IDInput = TextID.Text;

            try
            {
                SqlConnection connDel = new SqlConnection("Data Source=DESKTOP-0BB7K4Q\\SQL2022;Initial Catalog=student_maintenance;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("DeletePerson", connDel);
                connDel.Open();
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Person_ID", SqlDbType.Int).Value = IDInput;
                adapter.SelectCommand.ExecuteNonQuery();
                connDel.Close();
                MessageBox.Show("A Person was deleted.");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Deleting a Person Failed.");
            }

            TextID.Text = "";
            TextLastName.Text = "";
            TextMiddleName.Text = "";
            TextGivenName.Text = "";
        }
    }
}

