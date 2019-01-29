using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class VISUALS : UserControl
    {
        public VISUALS()
        {
            InitializeComponent();
        }

        private void Glow_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Glow.enabled = !Settings.Glow.enabled;
        }

        private void Radar_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Radar.enabled = !Settings.Radar.enabled;
        }

        private void Glowteam_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Glowteam.enabled = !Settings.Glowteam.enabled;
        }

        private void Glowenemy_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Glowenemy.enabled = !Settings.Glowenemy.enabled;
        }

        private void Flash_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Flash.enabled = !Settings.Flash.enabled;
        }
    }
}
