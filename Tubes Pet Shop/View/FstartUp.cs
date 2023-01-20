using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tubes_Pet_Shop.View
{
    public partial class FstartUp : Form
    {
        public FstartUp()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Login lgn = new Login();
            progressBar1.Value += 5;
            if (progressBar1.Value == 100)
            {
                Timer.Dispose();
                Hide();
                lgn.Show();
            }
            /*
            Login lgn = new Login();
            startPoint += 2;
            guna2ProgressBar1.Value = startPoint;
            if (guna2ProgressBar1.Value == 100)
            {
                guna2ProgressBar1.Value = 0;
                Timer.Stop();
                this.Hide();
                lgn.Show();
            }*/
        }

        private void FstartUp_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }
    }
}
