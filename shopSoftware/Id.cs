using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopSoftware
{
    public partial class Id : Form
    {
        public Id()
        {
            InitializeComponent();
        }

        private void idSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                var connectionString = "data source=(local);initial catalog = shopDB; persist security info = True;Integrated Security = True;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                var cmd = "INSERT INTO [dbo].[IdTypes] ([Name],[Description]) VALUES ('" + idName.Text + "','" + idDescription.Text + "')";
                SqlCommand command = new SqlCommand(cmd, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
                idName.Text=String.Empty;
                idDescription.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
