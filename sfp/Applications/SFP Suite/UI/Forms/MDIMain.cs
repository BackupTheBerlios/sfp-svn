#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SFP.Core.Module.Interfaces;

#endregion

namespace SFP.Suite.UI.Forms
{
    partial class MDIMain : Form , IConnectable
    {
        public MDIMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConnectable a;
            
        }

        public void RaiseSuiteEvent(String Text)
        {
            
        }
    }
}