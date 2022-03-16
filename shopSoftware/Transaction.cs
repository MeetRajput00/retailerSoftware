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
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void transactionSubmit_Click(object sender, EventArgs e)
        {
            int pamount = Convert.ToInt32(serviceCount.Text) * global.GlobalCharges;
            amount.Text = Convert.ToString(pamount);
            try
            {
                SqlConnection cnn;
                var connectionString = "data source=(local);initial catalog = shopDB; persist security info = True;Integrated Security = True;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                var cmd = @"INSERT INTO [dbo].[Transactions]([CustomerId],[ServiceId],[Date],[Amount],[ServiceCount],[TotalPaidAmount]) VALUES ("+0+","+0+","+"'" +DateTime.Now.ToString() + "'," + pamount + ",'" + serviceCount.Text + "','" + paidAmount.Text+"')";
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
