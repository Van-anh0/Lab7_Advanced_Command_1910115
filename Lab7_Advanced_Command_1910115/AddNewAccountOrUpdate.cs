using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab7_Advanced_Command_1910115
{
    public partial class AddNewAccountOrUpdate : Form
    {
        public AddNewAccountOrUpdate()
        {
            InitializeComponent();
        }

        private void AddNewAccountOrUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";

                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertAccount @AccountName,@Pass,@FullName,@Email,@Tell,@DateCreated";

                //thêm tham số
                cmd.Parameters.Add("@AccountName",SqlDbType.NVarChar, 100 );
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Tell", SqlDbType.NVarChar,200);
                cmd.Parameters.Add("@DateCreated", SqlDbType.SmallDateTime);
                

              

                //tryền giá trị vào thủ tục qua tham số
                cmd.Parameters["@AccountName"].Value = txtName.Text;
                cmd.Parameters["@Pass"].Value = txtPass.Text;
                cmd.Parameters["@FullName"].Value = txtFullName.Text;
                cmd.Parameters["@Email"].Value = txtEmail.Text;
                cmd.Parameters["@Tell"].Value = txtTell.Text;
                cmd.Parameters["@DateCreated"].Value = new DateTime(dtpDateCreated.Value.Year, dtpDateCreated.Value.Month, dtpDateCreated.Value.Day);

                //mở kết nối
                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                // thông báo kết quả
                if (numRowAffected > 0)
                {
                    
                    MessageBox.Show("Successfully adding new Account.");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding account failed.");
                }
                //đóng kết nối
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
                Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateAccount @AccountName, @Pass, @FullName, @Email, @Tell, @DateCreated";

                //thêm tham số vào đối tượng command
                cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Tell", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@DateCreated", SqlDbType.SmallDateTime);

                //truyền giá trị vào thủ tục qua tham số
                cmd.Parameters["@AccountName"].Value = txtName.Text;
                cmd.Parameters["@Pass"].Value = txtPass.Text;
                cmd.Parameters["@FullName"].Value = txtFullName.Text;
                cmd.Parameters["@Email"].Value = txtEmail.Text;
                cmd.Parameters["@Tell"].Value = txtTell.Text;
                cmd.Parameters["@DateCreated"].Value = new DateTime(dtpDateCreated.Value.Year,dtpDateCreated.Value.Month,dtpDateCreated.Value.Day);
                //mở kết nối
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();

                //thông báo kết quả
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Successfull updating account", "Message");
                    this.ResetText();
                    //  Close();
                }
                else
                {
                    MessageBox.Show("Updating account failed");
                }

                //đóng kết nối
                conn.Close();
                conn.Dispose();

            }
            //bắt lỗi SQL và các lỗi khác
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        public void DisplayAccountInfo(DataRowView rowView)
        {
            try
            {
                txtName.Text = rowView["AccountName"].ToString();
                txtPass.Text = rowView["Password"].ToString();
                txtFullName.Text = rowView["FullName"].ToString();
                txtEmail.Text = rowView["Email"].ToString();
                txtTell.Text = rowView["Tell"].ToString();
                if (rowView["DateCreated"].ToString() == "")
                {
                    dtpDateCreated.Value = DateTime.Today;
                }
                else
                    dtpDateCreated.Value = DateTime.Parse(rowView["DateCreated"].ToString());
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                Close();
            }
        }
    }
}
