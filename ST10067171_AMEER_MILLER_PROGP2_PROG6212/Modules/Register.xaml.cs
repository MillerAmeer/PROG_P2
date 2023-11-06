using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Modules
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string connectionstring = "";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string insertQuesrt = "INSERT INTO STUDENT(UserName)VALUES(@STUDENT_USERNAME)";
                    SqlCommand command = new SqlCommand(insertQuesrt, con);

                    command.Parameters.AddWithValue("@STUDENT_USERNAME", UserName.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show(UserName.Text + "added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            UserName.Text = "";
            Password.Text = "";
        }
    }
}



