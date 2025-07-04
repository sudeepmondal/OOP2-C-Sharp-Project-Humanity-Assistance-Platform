namespace PublicFund
{
    partial class Volunteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volunteer));
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvitedEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVUname = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1061, 4);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 47);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(131, 601);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.EventToolStripMenuItem,
            this.InvitedEventToolStripMenuItem});
            this.myProfileToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myProfileToolStripMenuItem.Image")));
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(120, 37);
            this.myProfileToolStripMenuItem.Text = "Menu";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem1,
            this.updateProfileToolStripMenuItem1});
            this.viewProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileToolStripMenuItem.Image")));
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.viewProfileToolStripMenuItem.Text = "My Profile";
            // 
            // viewProfileToolStripMenuItem1
            // 
            this.viewProfileToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileToolStripMenuItem1.Image")));
            this.viewProfileToolStripMenuItem1.Name = "viewProfileToolStripMenuItem1";
            this.viewProfileToolStripMenuItem1.Size = new System.Drawing.Size(297, 38);
            this.viewProfileToolStripMenuItem1.Text = "View Profile";
            this.viewProfileToolStripMenuItem1.Click += new System.EventHandler(this.viewProfileToolStripMenuItem1_Click);
            // 
            // updateProfileToolStripMenuItem1
            // 
            this.updateProfileToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("updateProfileToolStripMenuItem1.Image")));
            this.updateProfileToolStripMenuItem1.Name = "updateProfileToolStripMenuItem1";
            this.updateProfileToolStripMenuItem1.Size = new System.Drawing.Size(297, 38);
            this.updateProfileToolStripMenuItem1.Text = "Update Profile";
            this.updateProfileToolStripMenuItem1.Click += new System.EventHandler(this.updateProfileToolStripMenuItem1_Click);
            // 
            // EventToolStripMenuItem
            // 
            this.EventToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EventToolStripMenuItem.Image")));
            this.EventToolStripMenuItem.Name = "EventToolStripMenuItem";
            this.EventToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.EventToolStripMenuItem.Text = "Events";
            this.EventToolStripMenuItem.Click += new System.EventHandler(this.EventToolStripMenuItem_Click);
            // 
            // InvitedEventToolStripMenuItem
            // 
            this.InvitedEventToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InvitedEventToolStripMenuItem.Image")));
            this.InvitedEventToolStripMenuItem.Name = "InvitedEventToolStripMenuItem";
            this.InvitedEventToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.InvitedEventToolStripMenuItem.Text = "Invited Events";
            this.InvitedEventToolStripMenuItem.Click += new System.EventHandler(this.InvitedEventToolStripMenuItem_Click);
            // 
            // txtVUname
            // 
            this.txtVUname.AutoSize = true;
            this.txtVUname.BackColor = System.Drawing.Color.Transparent;
            this.txtVUname.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVUname.Location = new System.Drawing.Point(424, 7);
            this.txtVUname.Name = "txtVUname";
            this.txtVUname.Size = new System.Drawing.Size(21, 33);
            this.txtVUname.TabIndex = 12;
            this.txtVUname.Text = " ";
            this.txtVUname.Click += new System.EventHandler(this.txtVUname_Click_1);
            // 
            // Volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 601);
            this.Controls.Add(this.txtVUname);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Volunteer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volunteer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Volunteer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvitedEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem1;
        private System.Windows.Forms.Label txtVUname;
    }
}