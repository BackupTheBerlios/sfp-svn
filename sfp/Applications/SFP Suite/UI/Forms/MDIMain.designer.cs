namespace SFP.Suite.UI.Forms
{
    partial class MDIMain
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
            this.ctlStateStrip = new System.Windows.Forms.StatusStrip();
            this.leftRaftingContainer = new System.Windows.Forms.RaftingContainer();
            this.rightRaftingContainer = new System.Windows.Forms.RaftingContainer();
            this.topRaftingContainer = new System.Windows.Forms.RaftingContainer();
            this.ctlMenuStrip = new System.Windows.Forms.MenuStrip();
            this.bottomRaftingContainer = new System.Windows.Forms.RaftingContainer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftRaftingContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRaftingContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRaftingContainer)).BeginInit();
            this.topRaftingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRaftingContainer)).BeginInit();
            this.bottomRaftingContainer.SuspendLayout();
            this.SuspendLayout();
// 
// ctlStateStrip
// 
            this.ctlStateStrip.Location = new System.Drawing.Point(0, 0);
            this.ctlStateStrip.Name = "ctlStateStrip";
            this.ctlStateStrip.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.ctlStateStrip.Raft = System.Windows.Forms.RaftingSides.Bottom;
            this.ctlStateStrip.TabIndex = 0;
            this.ctlStateStrip.Text = "statusStrip1";
// 
// leftRaftingContainer
// 
            this.leftRaftingContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftRaftingContainer.Name = "leftRaftingContainer";
// 
// rightRaftingContainer
// 
            this.rightRaftingContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightRaftingContainer.Name = "rightRaftingContainer";
// 
// topRaftingContainer
// 
            this.topRaftingContainer.Controls.Add(this.ctlMenuStrip);
            this.topRaftingContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRaftingContainer.Name = "topRaftingContainer";
// 
// ctlMenuStrip
// 
            this.ctlMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ctlMenuStrip.Name = "ctlMenuStrip";
            this.ctlMenuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.ctlMenuStrip.Raft = System.Windows.Forms.RaftingSides.Top;
            this.ctlMenuStrip.TabIndex = 0;
            this.ctlMenuStrip.Text = "menuStrip1";
// 
// bottomRaftingContainer
// 
            this.bottomRaftingContainer.Controls.Add(this.ctlStateStrip);
            this.bottomRaftingContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomRaftingContainer.Name = "bottomRaftingContainer";
// 
// button1
// 
            this.button1.Location = new System.Drawing.Point(179, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 81);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// MDIMain
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(685, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leftRaftingContainer);
            this.Controls.Add(this.rightRaftingContainer);
            this.Controls.Add(this.topRaftingContainer);
            this.Controls.Add(this.bottomRaftingContainer);
            this.IsMdiContainer = true;
            this.Name = "MDIMain";
            this.Text = "MDIMain";
            ((System.ComponentModel.ISupportInitialize)(this.leftRaftingContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRaftingContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRaftingContainer)).EndInit();
            this.topRaftingContainer.ResumeLayout(false);
            this.topRaftingContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRaftingContainer)).EndInit();
            this.bottomRaftingContainer.ResumeLayout(false);
            this.bottomRaftingContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ctlStateStrip;
        private System.Windows.Forms.RaftingContainer leftRaftingContainer;
        private System.Windows.Forms.RaftingContainer rightRaftingContainer;
        private System.Windows.Forms.RaftingContainer topRaftingContainer;
        private System.Windows.Forms.RaftingContainer bottomRaftingContainer;
        private System.Windows.Forms.MenuStrip ctlMenuStrip;
        private System.Windows.Forms.Button button1;
    }
}