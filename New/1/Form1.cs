using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        String[] imgList = new String[]
                                        { "0.jpg" , "1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg","10.jpg" };
        int index=0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("../../../picture/"+imgList[0]);
            pictureBox2.Load("../../../picture/" + imgList[1]);
            pictureBox3.Load("../../../picture/" + imgList[2]);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form2();
            adminForm.Show();
            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imgList.Length) index = 0;
            pictureBox1.Load("../../../picture/" + imgList[index + 0]);
            pictureBox2.Load("../../../picture/" + imgList[index + 1]);
            pictureBox3.Load("../../../picture/" + imgList[index + 2]);
        }
    }
}
