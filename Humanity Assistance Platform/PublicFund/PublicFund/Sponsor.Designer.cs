namespace PublicFund
{
    partial class Sponsor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sponsor));
            this.button2 = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHistory = new System.Windows.Forms.Button();
            this.txtSUname = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1033, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Log Out";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnEvent.Image")));
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.Location = new System.Drawing.Point(452, 175);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(109, 47);
            this.btnEvent.TabIndex = 5;
            this.btnEvent.Text = "Events";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.Transparent;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.Image = ((System.Drawing.Image)(resources.GetObject("btnDonate.Image")));
            this.btnDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonate.Location = new System.Drawing.Point(728, 175);
            this.btnDonate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(108, 47);
            this.btnDonate.TabIndex = 4;
            this.btnDonate.Text = "Donate";
            this.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(89, 648);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.EventToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.myProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myProfileToolStripMenuItem.Image")));
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.myProfileToolStripMenuItem.Text = "Menu";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem1,
            this.updateProfileToolStripMenuItem1});
            this.viewProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileToolStripMenuItem.Image")));
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.viewProfileToolStripMenuItem.Text = "My Profile";
            // 
            // viewProfileToolStripMenuItem1
            // 
            this.viewProfileToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileToolStripMenuItem1.Image")));
            this.viewProfileToolStripMenuItem1.Name = "viewProfileToolStripMenuItem1";
            this.viewProfileToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.viewProfileToolStripMenuItem1.Text = "View Profile";
            this.viewProfileToolStripMenuItem1.Click += new System.EventHandler(this.viewProfileToolStripMenuItem1_Click);
            // 
            // updateProfileToolStripMenuItem1
            // 
            this.updateProfileToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("updateProfileToolStripMenuItem1.Image")));
            this.updateProfileToolStripMenuItem1.Name = "updateProfileToolStripMenuItem1";
            this.updateProfileToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.updateProfileToolStripMenuItem1.Text = "Update Profile";
            this.updateProfileToolStripMenuItem1.Click += new System.EventHandler(this.updateProfileToolStripMenuItem1_Click);
            // 
            // EventToolStripMenuItem
            // 
            this.EventToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EventToolStripMenuItem.Image")));
            this.EventToolStripMenuItem.Name = "EventToolStripMenuItem";
            this.EventToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.EventToolStripMenuItem.Text = "Events";
            this.EventToolStripMenuItem.Click += new System.EventHandler(this.EventToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateToolStripMenuItem.Image")));
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.Image")));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(182, 175);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(111, 47);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // txtSUname
            // 
            this.txtSUname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSUname.AutoSize = true;
            this.txtSUname.BackColor = System.Drawing.Color.Transparent;
            this.txtSUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUname.Location = new System.Drawing.Point(381, 8);
            this.txtSUname.Name = "txtSUname";
            this.txtSUname.Size = new System.Drawing.Size(70, 25);
            this.txtSUname.TabIndex = 7;
            this.txtSUname.Text = "label1";
            // 
            // Sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 648);
            this.Controls.Add(this.txtSUname);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sponsor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sponsor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label txtSUname;
    }
}