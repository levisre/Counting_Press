﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Counting_Press
{
    public partial class mainForm : Form
    {
        static long noOfKeyPressed = 0;
        public const string AboutMsg = "Counting Press v0.1 by Levis Nickaster\nWebsite: https://ltops9.wordpress.com\nThis is only a hobby project, so except bugs!";
        private const string postfixStr = " key(s) pressed";
        public const string AppName = "Counting Press";
        private static string datafilePath = Directory.GetCurrentDirectory() + "\\data.txt";

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private LowLevelKeyboardProc hkProc = hookProc ;
        public static IntPtr hHook = IntPtr.Zero;

        public mainForm()
        {
            InitializeComponent();
            notifyIcon1.ContextMenuStrip = contextMenu;
            notifyIcon1.Text = AppName ;
            notifyIcon1.Icon = Icon;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
            setHook();
        }

        public void setHook()
        {
            try
            {
                IntPtr hInst = LoadLibrary("User32");
                hHook = SetWindowsHookEx(0xD, hkProc, hInst, 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Application.Exit();
            }
        }
        public void unHook()
        {
            try
            {
                UnhookWindowsHookEx(hHook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Application.Exit();
            }

        }
        public void QuitProc()
        {
            unHook();
            Application.Exit();
        }

        public static IntPtr hookProc(int code, IntPtr wparam, IntPtr lparam)
        {
            if (code >= 0 && (wparam == (IntPtr)0x101|| wparam == (IntPtr)0x0105))
            {
                noOfKeyPressed++;
                return CallNextHookEx(hHook, code, (int)wparam, lparam);
            }
            else
               return CallNextHookEx(hHook, code, (int)wparam, lparam);

        }
        private void SaveData()
        {
            File.WriteAllText(datafilePath, noOfKeyPressed.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            switch(MessageBox.Show("You pressed " + noOfKeyPressed.ToString() + " key(s) in this session. Sure to quit?","Notice",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    QuitProc();
                    break;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            countLbl.Text = noOfKeyPressed.ToString();
        }

        private void countLbl_DoubleClick(object sender, EventArgs e)
        {
            switch(MessageBox.Show("Are you want to clear the counter?","Notice",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    noOfKeyPressed = 0;
                    break;
                case DialogResult.No:
                    break;
            }
            countLbl.Text = noOfKeyPressed.ToString();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AboutMsg, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            statusTextMenu.Text = noOfKeyPressed.ToString() + postfixStr;
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.Text = noOfKeyPressed.ToString() + postfixStr;
        }

        private void statusTextMenu_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }


        private void exitMainMenu_Click(object sender, EventArgs e)
        {
            switch(MessageBox.Show("Save the counter date?","Notice",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    SaveData();
                    QuitProc();
                    break;
                case DialogResult.No:
                    QuitProc();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void SaveDataMainMenu_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void loadDataMainMenu_Click(object sender, EventArgs e)
        {
            noOfKeyPressed = Convert.ToInt32(File.ReadAllText(datafilePath));
            countLbl.Text = noOfKeyPressed.ToString();
        }
    }
}