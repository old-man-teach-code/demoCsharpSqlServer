using System.Data.SqlClient;

namespace peeshop
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
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
            }catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra ở createConnection " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String username = tbUserName.Text;
                String password = tbPassword.Text;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT TOP 1 * FROM staffs WHERE staffs.password = '" + password + "' AND staffs.email = '" + username +"'";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    AppData.isLogin = true;
                    AppData.username = username;
                    AppData.fullname = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    AppData.role = AppData.ROLE_STAFF;
                    MessageBox.Show("Đăng nhập thành công! Xin chào " + AppData.fullname);
                    Close();
                }
                else
                {
                    MessageBox.Show("Không tồn tại user!");
                }
                conn.Close();
                
            }catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra ở btnLogin_Click " + ex.Message);
            }
        }
    }
}