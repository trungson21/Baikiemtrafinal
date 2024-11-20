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


namespace Baikiemtra
{
    public partial class DonHangForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-2FUILOR;Initial Catalog=MobileShop;Integrated Security=True;";
        public DonHangForm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DonHang";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDonHang.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO DonHang (Id, KhachHangId, SanPhamId, SoLuong, NgayMua) " +
                                   "VALUES (@Id, @KhachHangId, @SanPhamId, @SoLuong, @NgayMua)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                        cmd.Parameters.AddWithValue("@KhachHangId", int.Parse(txtKhachHangId.Text));
                        cmd.Parameters.AddWithValue("@SanPhamId", int.Parse(txtSanPhamId.Text));
                        cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                        cmd.Parameters.AddWithValue("@NgayMua", dtpNgayMua.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm đơn hàng thành công!", "Thông báo");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE DonHang SET KhachHangId = @KhachHangId, SanPhamId = @SanPhamId, " +
                                   "SoLuong = @SoLuong, NgayMua = @NgayMua WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                        cmd.Parameters.AddWithValue("@KhachHangId", int.Parse(txtKhachHangId.Text));
                        cmd.Parameters.AddWithValue("@SanPhamId", int.Parse(txtSanPhamId.Text));
                        cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                        cmd.Parameters.AddWithValue("@NgayMua", dtpNgayMua.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sửa đơn hàng thành công!", "Thông báo");
                    LoadData(); // Tải lại dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa dữ liệu: {ex.Message}", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM DonHang WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Thông báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DonHang WHERE " +
                                   "(@KhachHangId IS NULL OR KhachHangId = @KhachHangId) AND " +
                                   "(@SanPhamId IS NULL OR SanPhamId = @SanPhamId)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KhachHangId", string.IsNullOrEmpty(txtKhachHangId.Text) ? (object)DBNull.Value : int.Parse(txtKhachHangId.Text));
                        cmd.Parameters.AddWithValue("@SanPhamId", string.IsNullOrEmpty(txtSanPhamId.Text) ? (object)DBNull.Value : int.Parse(txtSanPhamId.Text));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvDonHang.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Thông báo");
            }
        }
    }
}
