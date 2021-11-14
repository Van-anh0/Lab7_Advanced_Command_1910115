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
    public partial class BillDetailsForm : Form
    {
        public BillDetailsForm()
        {
            InitializeComponent();
        }

        public void LoadBillDetails(int invoiceID)
        {
            //tạo đối tượng kết nối
            string connectionString = "server = DESKTOP-E123JR5; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            //mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();



            sqlCommand.CommandText = "EXECUTE FoodBillDetails " + invoiceID;

            // tạo đối tượng DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            // tạo datatable để chứa dữ liệu
            DataTable dt = new DataTable("BillDetails");
            da.Fill(dt);

            //hiển thị danh sách món ăn lên Form
            dgvBillDetails.DataSource = dt;

            //đóng kết nối và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();



        }
        private void dgvBillDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
