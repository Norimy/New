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
    public partial class VisitorMenu : Form
    {
        public VisitorMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form PlayersForm = new PlayersForm();
            PlayersForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form TeamForm = new TeamsMain();
            TeamForm.Show();
        }
    }
}
