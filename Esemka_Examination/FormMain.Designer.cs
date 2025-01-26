namespace Esemka_Examination
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.useeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuType = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewCase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.useeToolStripMenuItem,
            this.caseToolStripMenuItem,
            this.menuSchedule});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuExit});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(139, 26);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(139, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // useeToolStripMenuItem
            // 
            this.useeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUser,
            this.menuType,
            this.menuRoom});
            this.useeToolStripMenuItem.Name = "useeToolStripMenuItem";
            this.useeToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.useeToolStripMenuItem.Text = "Master";
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(132, 26);
            this.menuUser.Text = "User";
            this.menuUser.Click += new System.EventHandler(this.menuUser_Click);
            // 
            // menuType
            // 
            this.menuType.Name = "menuType";
            this.menuType.Size = new System.Drawing.Size(132, 26);
            this.menuType.Text = "Type";
            this.menuType.Click += new System.EventHandler(this.menuType_Click);
            // 
            // menuRoom
            // 
            this.menuRoom.Name = "menuRoom";
            this.menuRoom.Size = new System.Drawing.Size(132, 26);
            this.menuRoom.Text = "Room";
            this.menuRoom.Click += new System.EventHandler(this.menuRoom_Click);
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewCase,
            this.menuNewCase});
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.caseToolStripMenuItem.Text = "Case";
            // 
            // menuViewCase
            // 
            this.menuViewCase.Name = "menuViewCase";
            this.menuViewCase.Size = new System.Drawing.Size(159, 26);
            this.menuViewCase.Text = "View Case";
            this.menuViewCase.Click += new System.EventHandler(this.viewCaseToolStripMenuItem_Click);
            // 
            // menuNewCase
            // 
            this.menuNewCase.Name = "menuNewCase";
            this.menuNewCase.Size = new System.Drawing.Size(159, 26);
            this.menuNewCase.Text = "New Case";
            this.menuNewCase.Click += new System.EventHandler(this.menuNewCase_Click);
            // 
            // menuSchedule
            // 
            this.menuSchedule.Name = "menuSchedule";
            this.menuSchedule.Size = new System.Drawing.Size(83, 24);
            this.menuSchedule.Text = "Schedule";
            this.menuSchedule.Click += new System.EventHandler(this.menuSchedule_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 674);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem useeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem menuType;
        private System.Windows.Forms.ToolStripMenuItem menuRoom;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuViewCase;
        private System.Windows.Forms.ToolStripMenuItem menuNewCase;
        private System.Windows.Forms.ToolStripMenuItem menuSchedule;
    }
}