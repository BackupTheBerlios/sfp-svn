namespace SFP.Suite.UI.Forms
{
    partial class NavTree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlTabs.SuspendLayout();
            this.SuspendLayout();
// 
// ctlTabs
// 
            this.ctlTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ctlTabs.Controls.Add(this.tabPage1);
            this.ctlTabs.Controls.Add(this.tabPage2);
            this.ctlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTabs.Location = new System.Drawing.Point(0, 0);
            this.ctlTabs.Name = "ctlTabs";
            this.ctlTabs.SelectedIndex = 0;
            this.ctlTabs.Size = new System.Drawing.Size(269, 563);
            this.ctlTabs.TabIndex = 0;
// 
// tabPage1
// 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
// 
// tabPage2
// 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(261, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
// 
// NavTree
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(269, 563);
            this.Controls.Add(this.ctlTabs);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "NavTree";
            this.Text = "NavTree";
            this.ctlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ctlTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;


    }
}