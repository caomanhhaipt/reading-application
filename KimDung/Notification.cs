using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimDung
{
    public partial class Notification : Form
    {
        private string Info;
        private string Guide;
        public Notification()
        {
            this.Info = "";
            this.Guide = "";
            InitializeComponent();
        }

        public Notification(string info, string guide)
        {
            this.Info = info;
            this.Guide = guide;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            if (!Info.Equals(""))
            {
                lbInfo.Text = Info;
                lbGuide.Text = Guide;
            }
        }
    }
}
