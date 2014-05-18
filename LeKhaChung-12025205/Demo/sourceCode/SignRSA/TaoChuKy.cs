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
    public partial class TaoChuKy : Form
    {
        private RSAAlgorithm _rsaAlgorithm = new RSAAlgorithm();

        public TaoChuKy()
        {
            InitializeComponent();
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
        
        
        #region check bok

        private void reset()
        {
            txtq.Text = "";
            txtp.Text = "";
            txtn2.Text = "";
            txtn.Text = "";
            txte.Text = "";
            txtd.Text = "";

            txtd.Enabled = false;
            txte.Enabled = false;
            txtn.Enabled = false;
            txtn2.Enabled = false;
            txtp.Enabled = true;
            txtq.Enabled = true;

        }
        private void reset_tudong()
        {
            txtq.Text = "";
            txtp.Text = "";
            txtn2.Text = "";
            txtn.Text = "";
            txte.Text = "";
            txtd.Text = "";
            txtd.Enabled = false;
            txte.Enabled = false;
            txtn.Enabled = false;
            txtn2.Enabled = false;
            txtp.Enabled = false;
            txtq.Enabled = false;

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                btntaokhoa.Enabled = false;
                btntaokhoamoi.Enabled = false;
                btntaokhoamoi.Hide();
                btnkhoatudongmoi.Show();
                reset_tudong();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    btntaokhoa.Enabled = true;
                    btntaokhoamoi.Enabled = true;
                    btnkhoatudongmoi.Hide();
                    btntaokhoamoi.Show();
                    reset();
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        private void btntaokhoa_Click(object sender, EventArgs ea)
        {
            if (txtp.Text == "" || txtq.Text == "")
                MessageBox.Show("Bạn phải nhập đủ 2 số ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var p = Convert.ToInt16(txtp.Text);
                var q = Convert.ToInt16(txtq.Text);
                if (p == q)
                {
                    MessageBox.Show("Bạn phải nhập 2 số khác nhau ", " Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtq.Focus();
                }
                else
                {
                    if (!_rsaAlgorithm.kiemTraNguyenTo(p) || p <= 1)
                    {
                        MessageBox.Show("Bạn phải nhập số nguyên  tố [p] lớn hơn 1 ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtp.Focus();
                    }
                    else
                    {
                        if (!_rsaAlgorithm.kiemTraNguyenTo(q) || q <= 1)
                        {
                            MessageBox.Show("Bạn phải nhập số nguyên  tố [q] lớn hơn 1 ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtq.Focus();
                        }
                        else
                        {
                            int n = 0, phi_n = 0, d = 0, e = 0;
                            _rsaAlgorithm.taoKhoa(p, q, out n, out phi_n, out e, out d);
                            txtp.Text = "" + p;
                            txtq.Text = "" + q;
                            txtn.Text = "" + n;
                            txtn2.Text = "" + phi_n;
                            txtd.Text = "" + d;
                            txte.Text = "" + e;

                            AppGlobal.D = d;
                            AppGlobal.E = e;
                            AppGlobal.N = n;
                            AppGlobal.P = p;
                            AppGlobal.PhiN = phi_n;
                            AppGlobal.Q = q;
                        }
                    }
                }
            }
        }

        private void tnkhoatudongmoi_Click(object sender, EventArgs ea)
        {
            try
            {
                reset_tudong();
                int p = 0, q = 0;
                do
                {
                    p = _rsaAlgorithm.soNgauNhien();
                    q = _rsaAlgorithm.soNgauNhien();
                }
                while (p == q || !_rsaAlgorithm.kiemTraNguyenTo(p) || !_rsaAlgorithm.kiemTraNguyenTo(q));
                int n = 0, phi_n = 0, d = 0, e = 0;
                _rsaAlgorithm.taoKhoa(p, q, out  n, out  phi_n, out  e, out  d);

                txtp.Text = "" + p;
                txtq.Text = "" + q;
                txtn.Text = "" + n;
                txtn2.Text = "" + phi_n;
                txtd.Text = "" + d;
                txte.Text = "" + e;

                AppGlobal.D = d;
                AppGlobal.E = e;
                AppGlobal.N = n;
                AppGlobal.P = p;
                AppGlobal.PhiN = phi_n;
                AppGlobal.Q = q;
            }
            catch (Exception)
            {


            }
        }

        private void btntaokhoamoi_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void TaoChuKy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmb = new KiemTraChuKy();
            frmb.Show();
        }
    }
}
