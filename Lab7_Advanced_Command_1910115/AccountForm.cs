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
    public partial class AccountForm : Form
    {
        private DataTable AccountTable;
        string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true;";
        public AccountForm()
        {
            InitializeComponent();
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectionString);

          

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXECUTE ShowAccount";


            //tạo bộ điều phiếu dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            AccountTable = new DataTable();

            //mở kết nối
            conn.Open();

            //lấy dữ liệu từ csdl đưa vào DataTable
            adapter.Fill(AccountTable);

            //đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();

            //đưa dữ liệu vào data gridview
            dtgvAccount.DataSource = AccountTable;
            
        }

        private void cbbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbShow.Text == "Active")
            {
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE ShowAccountActive";


                //tạo bộ điều phiếu dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                AccountTable = new DataTable();

                //mở kết nối
                conn.Open();

                //lấy dữ liệu từ csdl đưa vào DataTable
                adapter.Fill(AccountTable);

                //đóng kết nối và giải phóng bộ nhớ
                conn.Close();
                conn.Dispose();

                //đưa dữ liệu vào data gridview
                dtgvAccount.DataSource = AccountTable;
            }

            if (cbbShow.Text == "UnActive")
            {
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE ShowAccountUnActive";


                //tạo bộ điều phiếu dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                AccountTable = new DataTable();

                //mở kết nối
                conn.Open();

                //lấy dữ liệu từ csdl đưa vào DataTable
                adapter.Fill(AccountTable);

                //đóng kết nối và giải phóng bộ nhớ
                conn.Close();
                conn.Dispose();

                //đưa dữ liệu vào data gridview
                dtgvAccount.DataSource = AccountTable;
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            AddNewAccountOrUpdate addForm = new AddNewAccountOrUpdate();
            addForm.Show();
            addForm.FormClosed += new FormClosedEventHandler(AccountForm_Load);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //lấy thông tin sản phẩm được chọn
            if (dtgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvAccount.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                AddNewAccountOrUpdate form = new AddNewAccountOrUpdate();
                form.Show(this);
                form.FormClosed += new FormClosedEventHandler(AccountForm_Load);

               
                form.DisplayAccountInfo(rowView);
            }
        }

        private void tsmiShowRoleAccount_Click(object sender, EventArgs e)
        {
            RoleForm roleForm = new RoleForm();
            roleForm.Show(this);
            roleForm.LoadRoleAccount(dtgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            roleForm.LblAccountName(dtgvAccount.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
