﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LengthCalculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string strInput; 
        double douOutput; 

        public MainWindow()
        {
            InitializeComponent();
        }

        //private void TestBox_TextChanged(object sender, TextChangedEventArgs e)
        //{

        // }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo1.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;

            douM = Convert.ToDouble(txtM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douM * 100);
            txtKM.Text = string.Format("{0:0.##########}", douM * 0.001);
            txtIn.Text = string.Format("{0:0.##########}", douM * 39.37);
            txtFt.Text = string.Format("{0:0.##########}", douM * 3.28);
            txtYard.Text = string.Format("{0:0.##########}", douM * 1.09);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;

            douKM = Convert.ToDouble(txtKM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100);
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
            txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.1);
            txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84);
            txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.61);
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;

            douIn = Convert.ToDouble(txtIn.Text);

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
            txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
            txtFt.Text = string.Format("{0:0.##########}", douIn * 0.0833);
            txtYard.Text = string.Format("{0:0.##########}", douIn * 0.0278);
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;

            douFt = Convert.ToDouble(txtFt.Text);

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
            txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
            txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
            txtYard.Text = string.Format("{0:0.##########}", douFt * 0.3333);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;

            douYard = Convert.ToDouble(txtYard.Text);

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
            txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
            txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
            txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
        }

        
    }
}
