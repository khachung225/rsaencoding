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
    public partial class KiemTraChuKy : Form
    {
        private RSAAlgorithm _rsaAlgorithm = new RSAAlgorithm();
        public KiemTraChuKy()
        {
            InitializeComponent();
        }

        private void btnnhannoidung_Click(object sender, EventArgs e)
        {
            try
            {
                txtChuKy.Text = AppGlobal.ChuKy;
                txtNoiDung.Text = AppGlobal.NoiDung;
                txte.Text = AppGlobal.E.ToString(CultureInfo.InvariantCulture);
                txtn.Text = AppGlobal.N.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                
               
            }

        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            try
            {
                txtnoidunggoc.Text = _rsaAlgorithm.GiaiMaBase64NoiDung(txtNoiDung.Text);
               
                txtchukygoc.Text = _rsaAlgorithm.GiaiMaBase64ChuKy(txtChuKy.Text); ;
                //lblKetQua.Text = magia;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
          var isOK=  _rsaAlgorithm.Kiemtra(txtnoidunggoc.Text, txtChuKy.Text, AppGlobal.N, AppGlobal.D);
            lblKetQua.Text = isOK ? "Xác nhận" : "Không xác nhận";
        }

    }
}
