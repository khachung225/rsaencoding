using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignRSA
{
    public class RSAAlgorithm
    {
        public static Random _rd = new Random();
        #region "Hàm tạo số ngẫu nhiên từ 2->10000" 
        public int soNgauNhien()
        {
            return _rd.Next(2, 10000);   //11,101
        }
        #endregion

        #region "Hàm kiểm tra nguyên tố"
        public bool kiemTraNguyenTo(int i)
        {
            bool kiemtra = true;
            for (int j = 2; j < i; j++)
                if (i % j == 0)
                {
                    kiemtra = false;
                    break;
                }
            return kiemtra;
        }
        #endregion

        #region "Hàm kiểm tra hai số nguyên tố cùng nhau"
        public bool nguyenToCungNhau(int a, int b)
        {
            bool kiemtra = true;
            for (int i = 2; i <= a; i++)
                if (a % i == 0 && b % i == 0)
                    kiemtra = false;
            return kiemtra;
        }
        #endregion

        #region "Hàm tạo khóa tự động"
        public void taoKhoa(int p, int q,out int n,out int phi_n,out int e,out int d)
        {
            //Tinh n=p*q
            n = p * q;

            //Tính Phi(n)=(p-1)*(q-1)
            phi_n = (p - 1) * (q - 1);

            //Tính e là một số ngẫu nhiên có giá trị 0< e <phi(n) và là số nguyên tố cùng nhau với Phi(n)
            do
            {
                e = _rd.Next(2, phi_n);
            }
            while (!nguyenToCungNhau(e, phi_n));
            //txte.Text = Convert.ToString(e);
            //Tính d
            d = 0;
            int i = 2;
            while (((1 + i * phi_n) % e) != 0 || d <= 0)
            {
                i++;
                d = (1 + i * phi_n) / e;
            }

            var g = nghichdao(e,phi_n);
            d = g;
        }

        private int nghichdao(int a, int m)
        {
            int x1, x2, x3;
            int a1, a2, a3;
            int b1, b2, b3;
            int y2;

            x1 = m;
            x2 = a;
            a1 = 1;
            a2 = 0;
            b1 = 0;
            b2 = 1;
            b3 = b2;
            x3 = x2;

            while (x3 != 1)
            {
                x3 = x1 % x2;
                y2 = x1 / x2;
                a3 = a1 - (a2 * y2);
                b3 = b1 - (b2 * y2);

                x1 = x2;
                x2 = x3;
                a1 = a2;
                a2 = a3;
                b1 = b2;
                b2 = b3;
            }

            while (b3 < 0) { b3 += m; }
            while (b3 > m) { b3 %= m; }

            return (b3);
        }
        #endregion

        #region "Hàm lấy mod"
      
        public int mod(int m, int e, int n)
        {
            //int a, d, a2i, rs;
            //a = m;
            //d = e;
            //rs = 1;
            //a2i = a;
            //while (d!=0)
            //{
            //    if ((d & 1 )==1) rs = (rs * a2i) % n;
            //    d >>= 1;
            //    a2i = (a2i * a2i) % n;
            //}
            //return rs;

            //Sử dụng thuật toán "bình phương nhân"
            //Chuyển e sang hệ nhị phân
            int[] a = new int[100];
            int k = 0;
            do
            {
                a[k] = e % 2;
                k++;
                e = e / 2;
            }
            while (e != 0);
            //Quá trình lấy dư
            long kq = 1;
            for (int i = k - 1; i >= 0; i--)
            {
                kq = (kq * kq) % n;
                if (a[i] == 1)
                    kq = (kq * m) % n;
            }

            var kf = (int) kq;
            return kf;




            //int kqq = 1;
            //int a = m;
            //int x = e;
            //while (x != 0)
            //{
            //    if ((x%2) != 0)
            //        kqq = kqq*(a%n);

            //    x = x/2;
            //    a = (a*a)%n;
            //}
            //if (kqq > n) kqq = kqq%n;
            //return kqq;




            /* cách khác
             * int kq = 1;
             * while ( e > 0)
             * {
             *     if((e & 1) == 1)
             *     {
             *         kq = (kq + m)%n;
             *     }
             *     e = e >> 1;
             *     m = (m * m) % n;
             * }
             * return kq
             * */
        }
        #endregion

        #region "Lấy chuỗi từ mảng ra xâu S"
        public string chuoi(int[] a)
        {
            string s = "";
            for (int i = 0; i < a.Length - 1; i++)
            {
                s = s + a[i].ToString() + " ";
            }
            s = s + a[a.Length - 1].ToString();
            return s;
        }
        public int[] Revertchuoi(string a)
        {
            
            string s = "";
            var listkey = a.Split(' ');
            int cout = listkey.Count();
            if (cout == 0)
            {
                int k = 0;
                if (!Int32.TryParse(a, out k))
                    k = 0;
                var keys = new int[1];
                keys[0] = k;
                return keys; 
            }
            var key = new int[cout];
            int i = 0;
            foreach (var s1 in listkey)
            {
                int k = 0;
                if (!Int32.TryParse(s1, out k))
                    k = 0;
                key[i] = k;
                i++;

            }

            return key;
        }
        #endregion

        #region "Hàm Mã hóa"
        public void MaHoa(string s, int e, int n, out string txtMahoanoidung, out string txtMaBanMa, out string txtBanma)
        {
            //taoKhoa();
            // Chuyen xau thanh ma Unicode
            int[] nguyen = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                nguyen[i] = (int)s[i];
            }
            
            //txtMaBanRo = chuoi(nguyen);
            //Mảng a chứa các kí tự đã mã hóa
            int[] a = new int[nguyen.Length];
            for (int i = 0; i < nguyen.Length; i++)
            {
                a[i] = mod(nguyen[i], e, n);
            }
            txtMaBanMa = chuoi(a);
            //Chuyển sang kiểu kí tự trong bảng mã Unicode
            //string str = "";
            //for (int i = 0; i < nguyen.Length; i++)
            //{
            //    str = str + (char)a[i];
            //}
            byte[] data = Encoding.Unicode.GetBytes(txtMaBanMa);
            txtBanma = Convert.ToBase64String(data);

            

            ////#region giai ma nguoc luon

            string giaima = Encoding.Unicode.GetString(Convert.FromBase64String(txtBanma));
            var lista = Revertchuoi(giaima);
            int[] b = new int[lista.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                b[i] = (int)lista[i];
            }
            //Giải mã
            int[] c = new int[b.Length];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = mod(b[i], AppGlobal.D, n);
            }
            
            //// so sanh c va songuyn
            
            //#endregion

            //ma hoa noi dung
            byte[] dataNoidung = Encoding.Unicode.GetBytes(s);
            txtMahoanoidung = Convert.ToBase64String(dataNoidung);
        }
        #endregion

        #region "Hàm giải mã"
        public void GiaiMa(string s, int n, int d, out string txtMaGiaiMa, out string txtGiaima)
        {
            //Lấy mã Unicode của từng kí tự mã hóa
            string giaima = Encoding.Unicode.GetString(Convert.FromBase64String(s));
            int[] b = new int[giaima.Length];
            for (int i = 0; i < giaima.Length; i++)
            {
                b[i] = (int)giaima[i];
            }
            //Giải mã
            int[] c = new int[b.Length];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = mod(b[i], d, n);
            }
            txtMaGiaiMa = chuoi(c);
            //kiem tra c co tuong duong x.


            string str = "";
            for (int i = 0; i < c.Length; i++)
            {
                str = str + (char)c[i];
            }
            txtGiaima = str;
        }
        #endregion

        public string GiaiMaBase64NoiDung(string bangma)
        {
            try
            {
                //Lấy mã Unicode của từng kí tự mã hóa
                string giaima = Encoding.Unicode.GetString(Convert.FromBase64String(bangma));
                return giaima;
            }
            catch (Exception)
            {
                
                
            }
            return "";
        }
        public string GiaiMaBase64ChuKy(string bangma)
        {
            try
            {
                //Lấy mã Unicode của từng kí tự mã hóa
                string giaima = Encoding.Unicode.GetString(Convert.FromBase64String(bangma));
                return giaima;
            }
            catch (Exception)
            {


            }
            return "";
        }

        public bool Kiemtra(string noidung,string chuky, int n, int d)
        {
            //xu ly x
            // Chuyen xau thanh ma Unicode  được x.
            int[] nguyen = new int[noidung.Length];
            for (int i = 0; i < noidung.Length; i++)
            {
                nguyen[i] = (int)noidung[i];
            }
            
            //xu ly y
            //Lấy mã Unicode của từng kí tự mã hóa
            string giaima = Encoding.Unicode.GetString(Convert.FromBase64String(chuky));
            var lista = Revertchuoi(giaima);
            int[] b = new int[lista.Length];

            for (int i = 0; i < lista.Length; i++)
            {
                b[i] = (int)lista[i];
            }
            //Giải mã
            int[] c = new int[b.Length];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = mod(b[i], AppGlobal.D, n);
            }
            //kiem tra c va nguyn.
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != nguyen[i]) return false;
            }

            return true;

            //if (AppGlobal.NoiDungnguyon != noidung)
            //    return false;
            //if (AppGlobal.ChuKy != chuky)
            //    return false;
            return true;
        }

    }
}
