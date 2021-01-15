using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Score = 0, Assist = 0, Rebound = 0, Steal = 0, Turnover = 0;

            try
            {
                Score = Convert.ToInt32(textBox1.Text);
                Assist = Convert.ToInt32(textBox2.Text);
                Rebound = Convert.ToInt32(textBox3.Text);
                Steal = Convert.ToInt32(textBox4.Text);
                Turnover = Convert.ToInt32(textBox5.Text);
            }

            catch
            {
                MessageBox.Show("你輸入的數值有錯誤 ! 請檢查重試");
                return;

            }    
            int MVP = (Score * 1 + Assist * 2 + Rebound * 2 + Steal * 2) - (Turnover * 2);
            String level = "";
            if (MVP > 45) level = "A";
            else if (MVP >= 35 && MVP <= 44) level = "B";
            else if (MVP >= 25 && MVP <= 34) level = "C";
            else level = "D";
                    label6.Text = "MVP level " + level;


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
