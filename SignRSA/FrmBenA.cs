using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignRSA
{
    public partial class FrmBenA : Form
    {
        private RSAAlgorithm _rsaAlgorithm = new RSAAlgorithm();

        public FrmBenA()
        {
            InitializeComponent();
            var frmb = new FrmBenB();
            frmb.Show();
        }
        private void btnmahoa_Click(object sender, EventArgs e)
        {

            if (!IsHaKey())
                MessageBox.Show("Bạn phải tạo khóa trước ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                try
                {
                    string mahoanoidung;
                    string txtMaBanMa;
                    string txtBanma;
                   
                    _rsaAlgorithm.MaHoa(txtnoidung.Text, AppGlobal.E, AppGlobal.N, out mahoanoidung, out txtMaBanMa, out txtBanma);

                    txtRoSo.Text = mahoanoidung;
                    txtMaHoa.Text = txtMaBanMa;
                    txtchuky.Text = txtBanma;

                    AppGlobal.NoiDung = mahoanoidung;
                    AppGlobal.ChuKy = txtBanma;
                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            AppGlobal.NoiDungnguyon = txtnoidung.Text;
             
        }

        private bool IsHaKey()
        {
            if (AppGlobal.D <= 0)
                return false;
                    if (AppGlobal.E <= 0)
                return false;
            if (AppGlobal.N <= 0)
                return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txte.Text = AppGlobal.E.ToString(CultureInfo.InvariantCulture);
            txtn.Text = AppGlobal.N.ToString(CultureInfo.InvariantCulture);
        }
    }
}
