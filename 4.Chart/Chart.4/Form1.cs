using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Chart_Button_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;//간격 줘야 x축이 다 보임

            this.chart1.Series["temper"].Points.AddXY("1월",textBox1.Text);
            this.chart1.Series["temper"].Points.AddXY("2월", textBox3.Text);
            this.chart1.Series["temper"].Points.AddXY("3월", textBox5.Text);
            this.chart1.Series["temper"].Points.AddXY("4월", textBox7.Text);
            this.chart1.Series["temper"].Points.AddXY("5월", textBox9.Text);
            this.chart1.Series["temper"].Points.AddXY("6월", textBox11.Text);
            this.chart1.Series["temper"].Points.AddXY("7월", textBox13.Text);
            this.chart1.Series["temper"].Points.AddXY("8월", textBox15.Text);
            this.chart1.Series["temper"].Points.AddXY("9월", textBox17.Text);
            this.chart1.Series["temper"].Points.AddXY("10월", textBox19.Text);
            this.chart1.Series["temper"].Points.AddXY("11월", textBox21.Text);
            this.chart1.Series["temper"].Points.AddXY("12월", textBox23.Text);

            this.chart1.Series["humidity"].Points.AddXY("1월", textBox2.Text);
            this.chart1.Series["humidity"].Points.AddXY("2월", textBox4.Text);
            this.chart1.Series["humidity"].Points.AddXY("3월", textBox6.Text);
            this.chart1.Series["humidity"].Points.AddXY("4월", textBox8.Text);
            this.chart1.Series["humidity"].Points.AddXY("5월", textBox10.Text);
            this.chart1.Series["humidity"].Points.AddXY("6월", textBox12.Text);
            this.chart1.Series["humidity"].Points.AddXY("7월", textBox14.Text);
            this.chart1.Series["humidity"].Points.AddXY("8월", textBox16.Text);
            this.chart1.Series["humidity"].Points.AddXY("9월", textBox18.Text);
            this.chart1.Series["humidity"].Points.AddXY("10월", textBox20.Text);
            this.chart1.Series["humidity"].Points.AddXY("11월", textBox22.Text);
            this.chart1.Series["humidity"].Points.AddXY("12월", textBox24.Text);
        }

        private void rnd_button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox2.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox3.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox4.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox5.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox6.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox7.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox8.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox9.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox10.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox11.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox12.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();

            textBox13.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox14.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox15.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox16.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox17.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox18.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox19.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox20.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox21.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox22.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox23.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
            textBox24.Text = rnd.Next(Convert.ToInt32(textbox_min.Text), Convert.ToInt32(textbox_max.Text) + 1).ToString();
        }
    }
}
