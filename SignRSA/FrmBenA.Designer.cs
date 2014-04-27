namespace SignRSA
{
    partial class FrmBenA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtchuky = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnmahoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(13, 146);
            this.txtnoidung.Multiline = true;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(325, 131);
            this.txtnoidung.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa chữ ký";
            // 
            // txtchuky
            // 
            this.txtchuky.Location = new System.Drawing.Point(13, 303);
            this.txtchuky.Multiline = true;
            this.txtchuky.Name = "txtchuky";
            this.txtchuky.Size = new System.Drawing.Size(325, 131);
            this.txtchuky.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(453, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa nội dung";
            // 
            // txtRoSo
            // 
            this.txtRoSo.Location = new System.Drawing.Point(456, 146);
            this.txtRoSo.Multiline = true;
            this.txtRoSo.Name = "txtRoSo";
            this.txtRoSo.Size = new System.Drawing.Size(325, 131);
            this.txtRoSo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(453, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chữ ký trên nội dung";
            // 
            // txtMaHoa
            // 
            this.txtMaHoa.Location = new System.Drawing.Point(456, 327);
            this.txtMaHoa.Multiline = true;
            this.txtMaHoa.Name = "txtMaHoa";
            this.txtMaHoa.Size = new System.Drawing.Size(325, 131);
            this.txtMaHoa.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 51);
            this.label5.TabIndex = 0;
            this.label5.Text = ">>";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 51);
            this.label6.TabIndex = 0;
            this.label6.Text = "<<";
            // 
            // btnmahoa
            // 
            this.btnmahoa.Location = new System.Drawing.Point(812, 55);
            this.btnmahoa.Name = "btnmahoa";
            this.btnmahoa.Size = new System.Drawing.Size(75, 23);
            this.btnmahoa.TabIndex = 3;
            this.btnmahoa.Text = "Mã hóa";
            this.btnmahoa.UseVisualStyleBackColor = true;
            this.btnmahoa.Click += new System.EventHandler(this.btnmahoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lấy khóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(146, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "e = ";
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(176, 29);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(70, 20);
            this.txte.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "n = ";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(44, 29);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(70, 20);
            this.txtn.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txte);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khóa  công khai";
            // 
            // FrmBenA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmahoa);
            this.Controls.Add(this.txtchuky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmBenA";
            this.Text = "Bên gửi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtchuky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnmahoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

