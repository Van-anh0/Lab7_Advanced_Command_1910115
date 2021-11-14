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
    public partial class RoleForm : Form
    {
        string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true;";
        public RoleForm()
        {
            InitializeComponent();
        }

        private void dtgvRoleAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadRoleAccount(string accountName)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXECUTE ShowRoleAccount @AccountName";

            //truyền tham số
            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100);


            cmd.Parameters["@AccountName"].Value = accountName;

            //tạo bộ điều phiếu dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable roleAccountTable = new DataTable();

            //mở kết nối
            conn.Open();

            //lấy dữ liệu từ csdl đưa vào DataTable
            adapter.Fill(roleAccountTable);

            //đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();

            //đưa dữ liệu vào data gridview
            dtgvRoleForm.DataSource = roleAccountTable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LblAccountName(string name)
        {
            lblAccountName.Text = name;
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewRoleAccount roleAccount = new AddNewRoleAccount();
            roleAccount.Show();
            roleAccount.AccountNameText(lblAccountName.Text);
            
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //lấy thông tin sản phẩm được chọn
            if (dtgvRoleForm.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvRoleForm.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                AddNewRoleAccount form = new AddNewRoleAccount();
                form.Show(this);
                form.AccountNameText(lblAccountName.Text);
                form.DisplayRoleAccountInfo(rowView);
            }
        }

        
    }
}
