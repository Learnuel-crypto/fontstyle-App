using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPress.API.Startups
{
    public partial class LoadScreenFrm : Form
    {
        private int WaitCounter = 0;
        private Random rand;
        public LoadScreenFrm()
        {
            InitializeComponent();
        }
      
        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            WaitCounter--;
            if (WaitCounter <= 0)
            {
                var logingForm = new LoginFrm();
                WaitTimer.Stop();
                this.Hide();
                logingForm.Show();
            }
        }

        private void LoadScreenFrm_Load(object sender, EventArgs e)
        {
            rand = new Random();
            WaitCounter = rand.Next(12);
            WaitTimer.Start();
        }
    }
}
