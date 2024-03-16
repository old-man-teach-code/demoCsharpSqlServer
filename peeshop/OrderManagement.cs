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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace peeshop
{
    public partial class OrderManagement : Form
    {
        SqlConnection conn;
        public OrderManagement()
        {
            InitializeComponent();
            createConnection();
        }

        private void createConnection()
        {
            try
            {
                String strConnection = "Server=HANGOCLINH45AC;Database=BikeStores;Integrated Security = true";
                conn = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra ở createConnection " + ex.Message);
            }
        }

        private void displayData()
        {
            try
            {
                conn.Open();

                String CustomerName = "";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql =
                    "SELECT orders.*, CONCAT(customers.first_name,' ', customers.last_name) AS fullname_customer," +
                    "stores.store_name,CONCAT(staffs.first_name,' ', staffs.last_name) AS fullname_staff " +
                    "FROM orders JOIN customers ON customers.customer_id = orders.customer_id " +
                    "JOIN staffs ON staffs.staff_id = orders.staff_id " +
                    "JOIN stores ON stores.store_id = orders.store_id ";

                if ((tbCustomerName.Text != null && tbCustomerName.Text != "") || cbStaff.SelectedValue != null)
                {
                    sql += "WHERE ";
                    
                    if (tbCustomerName.Text != null && tbCustomerName.Text != "")
                    {
                        CustomerName = tbCustomerName.Text.ToString();
                        sql += "(customers.first_name LIKE '%"
                            + CustomerName + "%' OR customers.last_name LIKE '%"
                            + CustomerName + "%')";
                    }

                    if (tbCustomerName.Text != null && tbCustomerName.Text != "" && cbStaff.SelectedValue != null)
                    {
                        sql += " AND ";
                    }

                    if (cbStaff.SelectedValue != null)
                    {
                        string Staff_id = cbStaff.SelectedValue.ToString();
                        sql += ("staffs.staff_id = " + Staff_id);
                    }
                }
                
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getAllStaffs()
        {
            try
            {
                conn.Open();

                String CustomerName = "";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql =
                    "SELECT staffs.staff_id , CONCAT(staffs.first_name,' ', staffs.last_name) AS fullname_staff " +
                    "FROM staffs ";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                List<staff> staffList = new List<staff>();
                staffList.Add(new staff(0, "All Staffs"));
                while (reader.Read())
                {
                    int staffID = Int32.Parse(reader["staff_id"].ToString());
                    String staffName = reader["fullname_staff"].ToString();
                    
                    staffList.Add(new staff(staffID, staffName));
                }
                cbStaff.DataSource = staffList;
                cbStaff.DisplayMember = "staffName";
                cbStaff.ValueMember = "staffId";
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error getAllStaffs " + ex.Message);
            }
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            displayData();
            getAllStaffs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            displayData();
        }
    }

    class staff
    {
        public int staffId { get; set; }
        public string staffName { get; set;}

        public staff(int _staffId, String _staffName)
        {
            staffId = _staffId;
            staffName = _staffName;
        }
    }
}
