using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuBaruUas
{
    public partial class Form1 : Form
    {
        int[,] arr = new int[15, 15];
        bool x = true; 
        int t = 0;
        public static int status = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox0_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBo0_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox0_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_0_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_14_Click(object sender, EventArgs e)
        {

        }
        private void UbahGambar(PictureBox px, Label l)
        {
            if (x == true)
            {
                px.Image = Image.FromFile(@"C:\Users\Asus\source\repos\GomokuBaruUas\GomokuBaruUas\pngegg.png");
                x = false;
               

            }
            else
            {
                px.Image = Image.FromFile(@"C:\Users\Asus\source\repos\GomokuBaruUas\GomokuBaruUas\kisspng-white-color-cosmetics-nail-polish-upload-button-5ac5a6523c9438.9667141115229026102481.png");
                x = true;
               

            }
            px.Enabled = false;

        }

    }
}
