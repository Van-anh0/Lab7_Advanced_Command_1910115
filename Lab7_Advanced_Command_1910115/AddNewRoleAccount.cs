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
    public partial class AddNewRoleAccount : Form
    {
        public AddNewRoleAccount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";

                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertRole @RoleId,@AccountName,@Actived,@Notes";

                //thêm tham số
                cmd.Parameters.Add("@RoleID",SqlDbType.Int);
                cmd.Parameters.Add("@AccountName",SqlDbType.NVarChar,100);
                cmd.Parameters.Add("@Actived",SqlDbType.Bit);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 1000);


                //tryền giá trị vào thủ tục qua tham số
                cmd.Parameters["@RoleID"].Value = int.Parse(cbbMS.SelectedItem.ToString());
                cmd.Parameters["@AccountName"].Value = txtAccountNa.Text;
                cmd.Parameters["@Actived"].Value = int.Parse(cbbActived.SelectedItem.ToString());
                cmd.Parameters["@Notes"].Value = txtNotes.Text;
               

                //mở kết nối
                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                // thông báo kết quả
                if (numRowAffected > 0)
                {

                    MessageBox.Show("Successfully adding new Role Account.");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding role account failed.");
                }
                //đóng kết nối
                conn.Close();
                conn.Dispose();
                Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
               
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        public void AccountNameText(string name)
        {
            txtAccountNa.Text = name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateRole @RoleId,@AccountName,@Actived,@Notes";
                //thêm tham số
                cmd.Parameters.Add("@RoleID", SqlDbType.Int);
                cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@Actived", SqlDbType.Bit);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 1000);


                //tryền giá trị vào thủ tục qua tham số
                cmd.Parameters["@RoleID"].Value = int.Parse(cbbMS.SelectedItem.ToString());
                cmd.Parameters["@AccountName"].Value = txtAccountNa.Text;
                cmd.Parameters["@Actived"].Value = int.Parse(cbbActived.SelectedItem.ToString());
                cmd.Parameters["@Notes"].Value = txtNotes.Text;
                //mở kết nối
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();

                //thông báo kết quả
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Successfull updating role account", "Message");
                    this.ResetText();
                    //  Close();
                }
                else
                {
                    MessageBox.Show("Updating role account failed");
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

        public void DisplayRoleAccountInfo(DataRowView rowView)
        {
            try
            {
                cbbMS.Text = rowView["RoleID"].ToString();
                txtAccountNa.Text = rowView["AccountName"].ToString();
                cbbActived.Text = rowView["Actived"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
               

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                Close();
            }
        }
    }
}
