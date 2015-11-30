namespace Counting_Press
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusTextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countLbl = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDataMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nonSystemKeyLbl = new System.Windows.Forms.Label();
            this.systemKeyLbl = new System.Windows.Forms.Label();
            this.staticLabel1 = new System.Windows.Forms.Label();
            this.staticLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detailSystemKey = new System.Windows.Forms.ToolTip(this.components);
            this.detailNonSystemKey = new System.Windows.Forms.ToolTip(this.components);
            this.hintToClear = new System.Windows.Forms.ToolTip(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myBlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Counting started! You can check and access application from this small icon on th" +
    "e taskbar!";
            this.notifyIcon1.BalloonTipTitle = "Counting started!";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTextMenu,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(108, 76);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // statusTextMenu
            // 
            this.statusTextMenu.Name = "statusTextMenu";
            this.statusTextMenu.Size = new System.Drawing.Size(107, 22);
            this.statusTextMenu.Click += new System.EventHandler(this.statusTextMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // countLbl
            // 
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.ForeColor = System.Drawing.Color.Green;
            this.countLbl.Location = new System.Drawing.Point(0, 49);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(276, 37);
            this.countLbl.TabIndex = 3;
            this.countLbl.Text = "0";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hintToClear.SetToolTip(this.countLbl, "Double click here to Clear the counter");
            this.countLbl.DoubleClick += new System.EventHandler(this.countLbl_DoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(276, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveDataMainMenu,
            this.loadDataMainMenu,
            this.exitMainMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "&Main";
            // 
            // SaveDataMainMenu
            // 
            this.SaveDataMainMenu.Name = "SaveDataMainMenu";
            this.SaveDataMainMenu.Size = new System.Drawing.Size(152, 22);
            this.SaveDataMainMenu.Text = "&Save Data";
            this.SaveDataMainMenu.ToolTipText = "Save the Counter to file, located along side with this program";
            this.SaveDataMainMenu.Click += new System.EventHandler(this.SaveDataMainMenu_Click);
            // 
            // loadDataMainMenu
            // 
            this.loadDataMainMenu.Name = "loadDataMainMenu";
            this.loadDataMainMenu.Size = new System.Drawing.Size(152, 22);
            this.loadDataMainMenu.Text = "&Load Data";
            this.loadDataMainMenu.ToolTipText = "Load the previous saved Counter data";
            this.loadDataMainMenu.Click += new System.EventHandler(this.loadDataMainMenu_Click);
            // 
            // exitMainMenu
            // 
            this.exitMainMenu.Name = "exitMainMenu";
            this.exitMainMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMainMenu.Text = "&Exit";
            this.exitMainMenu.Click += new System.EventHandler(this.exitMainMenu_Click);
            // 
            // nonSystemKeyLbl
            // 
            this.nonSystemKeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonSystemKeyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nonSystemKeyLbl.Location = new System.Drawing.Point(0, 111);
            this.nonSystemKeyLbl.Name = "nonSystemKeyLbl";
            this.nonSystemKeyLbl.Size = new System.Drawing.Size(276, 33);
            this.nonSystemKeyLbl.TabIndex = 5;
            this.nonSystemKeyLbl.Text = "0";
            this.nonSystemKeyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.detailNonSystemKey.SetToolTip(this.nonSystemKeyLbl, "Non System Key is all the key shown in the Keyboard");
            // 
            // systemKeyLbl
            // 
            this.systemKeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemKeyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.systemKeyLbl.Location = new System.Drawing.Point(4, 175);
            this.systemKeyLbl.Name = "systemKeyLbl";
            this.systemKeyLbl.Size = new System.Drawing.Size(272, 36);
            this.systemKeyLbl.TabIndex = 6;
            this.systemKeyLbl.Text = "0";
            this.systemKeyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.detailSystemKey.SetToolTip(this.systemKeyLbl, "System Key recognized when you pressing key with Alt Key is being held down");
            // 
            // staticLabel1
            // 
            this.staticLabel1.AutoSize = true;
            this.staticLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLabel1.Location = new System.Drawing.Point(4, 36);
            this.staticLabel1.Name = "staticLabel1";
            this.staticLabel1.Size = new System.Drawing.Size(110, 13);
            this.staticLabel1.TabIndex = 7;
            this.staticLabel1.Text = "Total Key Pressed";
            // 
            // staticLabel2
            // 
            this.staticLabel2.AutoSize = true;
            this.staticLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLabel2.Location = new System.Drawing.Point(4, 90);
            this.staticLabel2.Name = "staticLabel2";
            this.staticLabel2.Size = new System.Drawing.Size(186, 13);
            this.staticLabel2.TabIndex = 8;
            this.staticLabel2.Text = "Total Non-System Keys pressed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total System Keys Pressed";
            // 
            // detailSystemKey
            // 
            this.detailSystemKey.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // detailNonSystemKey
            // 
            this.detailNonSystemKey.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // hintToClear
            // 
            this.hintToClear.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.websiteToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myBlogToolStripMenuItem,
            this.gitRepositoryToolStripMenuItem});
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.websiteToolStripMenuItem.Text = "&Website";
            // 
            // myBlogToolStripMenuItem
            // 
            this.myBlogToolStripMenuItem.Name = "myBlogToolStripMenuItem";
            this.myBlogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myBlogToolStripMenuItem.Text = "My Blog";
            this.myBlogToolStripMenuItem.Click += new System.EventHandler(this.myBlogToolStripMenuItem_Click);
            // 
            // gitRepositoryToolStripMenuItem
            // 
            this.gitRepositoryToolStripMenuItem.Name = "gitRepositoryToolStripMenuItem";
            this.gitRepositoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gitRepositoryToolStripMenuItem.Text = "Git Repository";
            this.gitRepositoryToolStripMenuItem.Click += new System.EventHandler(this.gitRepositoryToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staticLabel2);
            this.Controls.Add(this.staticLabel1);
            this.Controls.Add(this.systemKeyLbl);
            this.Controls.Add(this.nonSystemKeyLbl);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.countLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counting Press by Levis";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusTextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDataMainMenu;
        private System.Windows.Forms.ToolStripMenuItem loadDataMainMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMainMenu;
        private System.Windows.Forms.Label nonSystemKeyLbl;
        private System.Windows.Forms.Label systemKeyLbl;
        private System.Windows.Forms.Label staticLabel1;
        private System.Windows.Forms.Label staticLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip detailNonSystemKey;
        private System.Windows.Forms.ToolTip detailSystemKey;
        private System.Windows.Forms.ToolTip hintToClear;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myBlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitRepositoryToolStripMenuItem;
    }
}

