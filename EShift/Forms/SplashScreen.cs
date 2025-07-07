using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShift.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            progressBarLoader.Style = ProgressBarStyle.Marquee;
            progressBarLoader.MarqueeAnimationSpeed = 30;
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();

            this.Close();
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
    }
}
