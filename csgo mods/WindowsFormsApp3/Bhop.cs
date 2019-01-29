using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class Bhop : UserControl
    {
        public Bhop()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Bunnyhop.enabled = !Settings.Bunnyhop.enabled;
        }

        private void bhopDelay_Scroll(object sender, EventArgs e)
        {
            Settings.Bunnyhop.delay = bhopDelay.Value;
        }

        private void Bhop_Load(object sender, EventArgs e)
        {

        }
    }
}
