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
    public partial class Transaction : Form
    {
        Service serviceObj;
        public Transaction(Service obj)
        {
            this.serviceObj = obj;
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void transactionSubmit_Click(object sender, EventArgs e)
        {
            int am = Convert.ToInt32(serviceObj.serviceCharges.Text);
            int pamount = am * Convert.ToInt32(serviceCount.Text);
            try
            {
                SqlConnection cnn;
                var connectionString = "data source=(local);initial catalog = shopDB; persist security info = True;Integrated Security = True;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                var cmd = @"INSERT INTO [dbo].[Transactions]([Date],[Amount],[ServiceCount],[TotalPaidAmount]) VALUES ('" +DateTime.Now + "'," + pamount + ",'" + serviceCount.Text + "','" + paidAmount.Text+"')";
                SqlCommand command = new SqlCommand(cmd, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
                amount.Text = Convert.ToString(pamount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
