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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myBlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonSystemKeyLbl = new System.Windows.Forms.Label();
            this.systemKeyLbl = new System.Windows.Forms.Label();
            this.staticLabel1 = new System.Windows.Forms.Label();
            this.staticLabel2 = new System.Windows.Forms.Label();
            this.staticLabel3 = new System.Windows.Forms.Label();
            this.sharedTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.leftMouseLbl = new System.Windows.Forms.Label();
            this.staticLabel4 = new System.Windows.Forms.Label();
            this.staticLabel5 = new System.Windows.Forms.Label();
            this.rightMouseLbl = new System.Windows.Forms.Label();
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
            this.sharedTooltip.SetToolTip(this.countLbl, "Total Number of Key Pressed. Double Click to clear data");
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
            this.SaveDataMainMenu.Size = new System.Drawing.Size(127, 22);
            this.SaveDataMainMenu.Text = "&Save Data";
            this.SaveDataMainMenu.ToolTipText = "Save the Counter to file, located along side with this program";
            this.SaveDataMainMenu.Click += new System.EventHandler(this.SaveDataMainMenu_Click);
            // 
            // loadDataMainMenu
            // 
            this.loadDataMainMenu.Name = "loadDataMainMenu";
            this.loadDataMainMenu.Size = new System.Drawing.Size(127, 22);
            this.loadDataMainMenu.Text = "&Load Data";
            this.loadDataMainMenu.ToolTipText = "Load the previous saved Counter data";
            this.loadDataMainMenu.Click += new System.EventHandler(this.loadDataMainMenu_Click);
            // 
            // exitMainMenu
            // 
            this.exitMainMenu.Name = "exitMainMenu";
            this.exitMainMenu.Size = new System.Drawing.Size(127, 22);
            this.exitMainMenu.Text = "&Exit";
            this.exitMainMenu.Click += new System.EventHandler(this.exitMainMenu_Click);
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
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myBlogToolStripMenuItem,
            this.gitRepositoryToolStripMenuItem});
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.websiteToolStripMenuItem.Text = "&Website";
            // 
            // myBlogToolStripMenuItem
            // 
            this.myBlogToolStripMenuItem.Name = "myBlogToolStripMenuItem";
            this.myBlogToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.myBlogToolStripMenuItem.Text = "My Blog";
            this.myBlogToolStripMenuItem.Click += new System.EventHandler(this.myBlogToolStripMenuItem_Click);
            // 
            // gitRepositoryToolStripMenuItem
            // 
            this.gitRepositoryToolStripMenuItem.Name = "gitRepositoryToolStripMenuItem";
            this.gitRepositoryToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.gitRepositoryToolStripMenuItem.Text = "Git Repository";
            this.gitRepositoryToolStripMenuItem.Click += new System.EventHandler(this.gitRepositoryToolStripMenuItem_Click);
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
            this.sharedTooltip.SetToolTip(this.nonSystemKeyLbl, "Number of keys pressed (non System key is all the keys appear in your keyboard)");
            // 
            // systemKeyLbl
            // 
            this.systemKeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemKeyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.systemKeyLbl.Location = new System.Drawing.Point(0, 175);
            this.systemKeyLbl.Name = "systemKeyLbl";
            this.systemKeyLbl.Size = new System.Drawing.Size(276, 36);
            this.systemKeyLbl.TabIndex = 6;
            this.systemKeyLbl.Text = "0";
            this.systemKeyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sharedTooltip.SetToolTip(this.systemKeyLbl, "System Key recognized when you pressing key with Alt Key is being held down");
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
            // staticLabel3
            // 
            this.staticLabel3.AutoSize = true;
            this.staticLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLabel3.Location = new System.Drawing.Point(4, 153);
            this.staticLabel3.Name = "staticLabel3";
            this.staticLabel3.Size = new System.Drawing.Size(160, 13);
            this.staticLabel3.TabIndex = 9;
            this.staticLabel3.Text = "Total System Keys Pressed";
            // 
            // sharedTooltip
            // 
            this.sharedTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // leftMouseLbl
            // 
            this.leftMouseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMouseLbl.ForeColor = System.Drawing.Color.Teal;
            this.leftMouseLbl.Location = new System.Drawing.Point(0, 238);
            this.leftMouseLbl.Name = "leftMouseLbl";
            this.leftMouseLbl.Size = new System.Drawing.Size(276, 38);
            this.leftMouseLbl.TabIndex = 10;
            this.leftMouseLbl.Text = "0";
            this.leftMouseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sharedTooltip.SetToolTip(this.leftMouseLbl, "Number of Left Mouse Button Clicked. Double clcik to clear data");
            this.leftMouseLbl.DoubleClick += new System.EventHandler(this.leftMouseLbl_DoubleClick);
            // 
            // staticLabel4
            // 
            this.staticLabel4.AutoSize = true;
            this.staticLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLabel4.Location = new System.Drawing.Point(4, 211);
            this.staticLabel4.Name = "staticLabel4";
            this.staticLabel4.Size = new System.Drawing.Size(208, 13);
            this.staticLabel4.TabIndex = 11;
            this.staticLabel4.Text = "Total of Left Mouse Button clicked:";
            // 
            // staticLabel5
            // 
            this.staticLabel5.AutoSize = true;
            this.staticLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLabel5.Location = new System.Drawing.Point(4, 285);
            this.staticLabel5.Name = "staticLabel5";
            this.staticLabel5.Size = new System.Drawing.Size(208, 13);
            this.staticLabel5.TabIndex = 13;
            this.staticLabel5.Text = "Total of Left Mouse Button clicked:";
            // 
            // rightMouseLbl
            // 
            this.rightMouseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMouseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rightMouseLbl.Location = new System.Drawing.Point(0, 310);
            this.rightMouseLbl.Name = "rightMouseLbl";
            this.rightMouseLbl.Size = new System.Drawing.Size(276, 38);
            this.rightMouseLbl.TabIndex = 12;
            this.rightMouseLbl.Text = "0";
            this.rightMouseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sharedTooltip.SetToolTip(this.rightMouseLbl, "Number of Right Mouse Button Clicked. Double clcik to clear data");
            this.rightMouseLbl.DoubleClick += new System.EventHandler(this.rightMouseLbl_DoubleClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 344);
            this.Controls.Add(this.staticLabel5);
            this.Controls.Add(this.rightMouseLbl);
            this.Controls.Add(this.staticLabel4);
            this.Controls.Add(this.leftMouseLbl);
            this.Controls.Add(this.staticLabel3);
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
        private System.Windows.Forms.Label staticLabel3;
        private System.Windows.Forms.ToolTip sharedTooltip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myBlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitRepositoryToolStripMenuItem;
        private System.Windows.Forms.Label leftMouseLbl;
        private System.Windows.Forms.Label staticLabel4;
        private System.Windows.Forms.Label staticLabel5;
        private System.Windows.Forms.Label rightMouseLbl;
    }
}

