using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChanLe
{
    public partial class Form1 : Form
    {
        int choose;
        Random rd = new Random();
        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            choose = int.Parse(bt.AccessibleName);
            label4.Text = "Bạn đã chọn : Chẵn";
            MessageBox.Show("Bạn đã chọn chẵn!\nBấm start để bắt đầu");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            choose = int.Parse(bt.AccessibleName);
            label4.Text = "Bạn đã chọn : Lẻ";
            MessageBox.Show("Bạn đã chọn lẻ!\nBấm start để bắt đầu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = rd.Next(1, 100);
            int checkResults = value % 2;
            if (choose == 1)
            {
                if (checkResults == 0)
                {
                    label2.Text = "Number : " + value.ToString();
                    label3.Text = "Kết quả : Thắng";
                }
                else
                {
                    label2.Text = "Number : " + value.ToString();
                    label3.Text = "Kết quả : Thua";
                }
            }
            else
            {
                if (checkResults != 0)
                {
                    label2.Text = "Number : " + value.ToString();
                    label3.Text = "Kết quả : Thắng";
                }
                else
                {
                    label2.Text = "Number : " + value.ToString();
                    label3.Text = "Kết quả : Thua";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e) { Application.Exit(); }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
    }
}
