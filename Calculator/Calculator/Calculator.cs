﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            Calculation c = new Calculation(a,b);
            int ketQua = c.Exucute("Cong");
            txtRes.Text = ketQua.ToString();

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            Calculation c = new Calculation(a, b);
            int ketQua = c.Exucute("Tru");
            txtRes.Text = ketQua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            Calculation c = new Calculation(a, b);
            int ketQua = c.Exucute("Nhan");
            txtRes.Text = ketQua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            Calculation c = new Calculation(a, b);
            int ketQua = c.Exucute("Chia");
            txtRes.Text = ketQua.ToString();
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtSoThuNhat.Text);
            int n = int.Parse(txtSoThuHai.Text);
            double ketQua = Calculation.Power(x, n); //Phương thức tỉnh gọi qua tên class chưa nó luôn
            txtRes.Text = ketQua.ToString();

        }
    }
}
