using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace shopSoftware
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            GetIdTypes();
        }
        private void GetIdTypes()
        {
            try
            {
                SqlConnection cnn;
                var connectionString = "data source=(local);initial catalog = shopDB; persist security info = True;Integrated Security = True;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                var cmd = "select * from IDtypes";
                
                SqlCommand command = new SqlCommand(cmd, cnn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
                idType.DataSource = dt;
                idType.DisplayMember = "Name";
                idType.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        private void customerSubmit_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || phoneNumber.Text == "" || address.Text == "")
            {
                MessageBox.Show("Please fill the marked entries","Error!");
            }
            else
            {
                try
                {
                    SqlConnection cnn;
                    var connectionString = "data source=(local);initial catalog = shopDB; persist security info = True;Integrated Security = True;";
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    var cmd = @"INSERT INTO [dbo].[Customers]([Name],[IdType],[PhoneNumber],[Email],[Address],[IdNumber],[Occupation],[DOB]) VALUES ('" + name.Text + "'," + idType.SelectedValue.ToString() + ",'" + phoneNumber.Text + "','" + email.Text + "','" + address.Text + "','" + idNumber.Text + "','" + occupation.Text + "','"+dateTime.Text+"')";
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
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Id idWin = new Id();
           idWin.Show();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerEdit cust = new FrmCustomerEdit();
            cust.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm mainFormObject = new mainForm();
            mainFormObject.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Account accObj = new Account();
            accObj.Show();
        }
        Service serviceObj=new Service();
        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Transaction tranObj = new Transaction(serviceObj);
            tranObj.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            serviceObj.Show();
        }
    }
}