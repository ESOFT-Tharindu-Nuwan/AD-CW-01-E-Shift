using EShift.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShift.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Use the static method from your DBConnection class to get a new connection
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    // Open the connection
                    connection.Open();

                    // If no exception is thrown, the connection was successful
                    MessageBox.Show("Database connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } // The 'using' statement ensures the connection is automatically closed and disposed
            }
            catch (Exception ex)
            {
                // Display any errors that occur during connection
                MessageBox.Show($"Database connection failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
