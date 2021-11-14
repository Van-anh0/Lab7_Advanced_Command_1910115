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
    public partial class OrdersForm : Form
    {
        string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true;";
        private DataTable BillsTable;
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            
            
            SqlConnection conn = new SqlConnection(connectionString);

            string day = dtpHD.Value.Day.ToString();
            string month = dtpHD.Value.Month.ToString();
            string year = dtpHD.Value.Year.ToString();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Bills WHERE CheckoutDate = '"+year+"-"+month+"-"+day+"'";
            

            //tạo bộ điều phiếu dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            BillsTable = new DataTable();

            //mở kết nối
            conn.Open();

            //lấy dữ liệu từ csdl đưa vào DataTable
            adapter.Fill(BillsTable);

            //đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();

            //đưa dữ liệu vào data gridview
           dtgHD.DataSource = BillsTable;
            TotalSales();
            
        }

        private void dtpHD_ValueChanged(object sender, EventArgs e)
        {
           

            SqlConnection conn = new SqlConnection(connectionString);


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXECUTE DateBills @Today";

            //thêm tham số
            cmd.Parameters.Add("@Today", SqlDbType.SmallDateTime);

            DateTime selectedDate = new DateTime(dtpHD.Value.Year, dtpHD.Value.Month, dtpHD.Value.Day);
            //tryền giá trị vào thủ tục qua tham số
            cmd.Parameters["@Today"].Value = selectedDate;

            //tạo bộ điều phiếu dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            BillsTable = new DataTable();

            //mở kết nối
            conn.Open();

            //lấy dữ liệu từ csdl đưa vào DataTable
            adapter.Fill(BillsTable);

            //đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();

            //đưa dữ liệu vào data gridview
            dtgHD.DataSource = BillsTable;
            TotalSales();
        }

        void TotalSales()
        {
            int sum = 0;
            for (int i = 0; i < dtgHD.RowCount; i++)
            {
                if (dtgHD.Rows[i].Cells[3].Value is null)
                {
                    dtgHD.Rows[i].Cells[3].Value = 0;
                }
                sum += int.Parse(dtgHD.Rows[i].Cells[3].Value.ToString());
            }
            lblSum.Text = sum.ToString();
        }

        private void dtgHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


                string ma = dtgHD.SelectedRows[0].Cells[0].Value.ToString();
                BillDetailsForm billForm = new BillDetailsForm();
                billForm.Show(this);
                billForm.LoadBillDetails(int.Parse(ma));
            
        }
    }
    
}
