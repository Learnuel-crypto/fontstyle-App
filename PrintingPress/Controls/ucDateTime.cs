using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPress.Controls
{
    public partial class ucDateTime : UserControl
    {
        private string dateTime;

        public string DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        
        public ucDateTime()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime;
        }
        public ucDateTime(string datatime)
        {
            InitializeComponent();
            lblDateTime.Text = datatime;
        }
    }
}
