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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void serviceSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn;
                var connectionString = "data source=(local);initial catalog = shopDB; persist security info = True;Integrated Security = True;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                var cmd = @"INSERT INTO [dbo].[Services]([Name],[Charges],[Description]) VALUES ('" + serviceName.Text + "'," + serviceCharges.Text + ",'" + serviceDescription.Text + "')";
                SqlCommand command = new SqlCommand(cmd, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void serviceCharges_TextChanged(object sender, EventArgs e)
        {
            global.GlobalCharges = Convert.ToInt32(serviceCharges.Text);
        }
    }
}
