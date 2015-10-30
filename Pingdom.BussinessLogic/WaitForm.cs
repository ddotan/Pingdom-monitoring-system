using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pingdom.BussinessLogic
{
    public partial class WaitForm : Form
    {
        public void SetProgressBarMax(int I_Max)
        {
            progressBarWait.Maximum = I_Max;

        }

        public void PerformStep()
        {
            progressBarWait.Value += 1;
        }
        public WaitForm()
        {
          
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
    }
}
