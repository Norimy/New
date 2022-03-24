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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Team team = new Team();
            // label1.Text = team[0].Name;
            for (int i = 0; 1 < 5; i++)
                this.Controls["label" + i].Text = team.Name;
        }
    }
}
