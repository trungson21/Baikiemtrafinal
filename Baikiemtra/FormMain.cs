using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baikiemtra
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            var formDonHang = new DonHangForm();
            formDonHang.ShowDialog();
        }
    }
}
