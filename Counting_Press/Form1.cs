﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace Counting_Press
{
    public partial class mainForm : Form
    {
        //The counter, set to long to avoid integer overflow, in case the number reached over 4 bilion
        //Now plus 2 new counter, which are counter for Non-System Keys, and counter for System Key
        //In fact, i only devided the total counter into 2 smart parts, that will be more easier to watch out
        static long noOfKeyPressed = 0;
        static long noOfNonSystemKey = 0;
        static long noOfSystemKey = 0;

        //Some basic string and variable
        public const string AboutMsg = "Counting Press v0.1 by Levis Nickaster\nWebsite: https://ltops9.wordpress.com\nThis is only a hobby project, so except bugs!";
        private const string postfixStr = " key(s) pressed";
        public const string AppName = "Counting Press";
        private static string datafilePath = Directory.GetCurrentDirectory() + "\\data.txt";

        //delcare p/invoke functions
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        //used in hooking process
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

        //start Register global Keyboard hook
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

        //Unregister globalhook, release hook instance
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

        //Executed when exit program
        public void QuitProc()
        {
            unHook();
            Application.Exit();
        }

        //main hooking function
        public static IntPtr hookProc(int code, IntPtr wparam, IntPtr lparam)
        {
            //key pressed and released?
            if (code >= 0)
            {
                switch((int)wparam)
                {
                    case 0x101: //WM_KEYUP
                        noOfNonSystemKey++;
                        break;
                    case 0x105: //WM_SYSKEYUP
                        noOfSystemKey++;
                        break;
                    default:
                        break;
                }
                //increase counter
                noOfKeyPressed = noOfSystemKey + noOfNonSystemKey;
                //parse the keyinput for other programs
                return CallNextHookEx(hHook, code, (int)wparam, lparam);
            }
            else
                //parse the keyinput for other programs
               return CallNextHookEx(hHook, code, (int)wparam, lparam);

        }

        //save counter to file
        private void SaveData()
        {
            File.WriteAllText(datafilePath, noOfKeyPressed.ToString() + "\n" + noOfNonSystemKey.ToString() + "\n" + noOfSystemKey.ToString());
        }

        //read data form file and parse it to counter variables
        private void ReadData()
        {
            try
            {
                string[] dataInput = File.ReadAllLines(datafilePath);
                if(dataInput.Length!=3)
                {
                    throw new Exception("Data Corrupted!");
                }
                else
                {
                    noOfKeyPressed = Convert.ToInt32(dataInput[0]);
                    noOfNonSystemKey = Convert.ToInt32(dataInput[1]);
                    noOfSystemKey = Convert.ToInt32(dataInput[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            

        }

        //Prevent close form, minimize it and run in background
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        //When click on Exit in Context menu of the NofityIcon
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

        //Show the counter when form opened
        private void Form1_Activated(object sender, EventArgs e)
        {
            countLbl.Text = noOfKeyPressed.ToString();
            nonSystemKeyLbl.Text = noOfNonSystemKey.ToString();
            systemKeyLbl.Text = noOfSystemKey.ToString();
        }

        // Clear the counter when doubleclick on the counter label in main form
        private void countLbl_DoubleClick(object sender, EventArgs e)
        {
            switch(MessageBox.Show("Are you want to clear the counter?","Notice",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    noOfKeyPressed = 0;
                    noOfSystemKey = 0;
                    noOfNonSystemKey = 0;
                    countLbl.Text = noOfKeyPressed.ToString();
                    nonSystemKeyLbl.Text = noOfNonSystemKey.ToString();
                    systemKeyLbl.Text = noOfSystemKey.ToString();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        //When double click on the tray icon, open the main Form
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        //Show about Message
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AboutMsg, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Update the counter text in Contextmenu
        private void contextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            statusTextMenu.Text = noOfKeyPressed.ToString() + postfixStr;
        }

        //Update the counter value in Tooltip
        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.Text = noOfKeyPressed.ToString() + postfixStr;
        }

        //Show main form when click on Status menu in Context menu of notify icon
        private void statusTextMenu_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        //Ask to save data or not when click Exit in Main Menu
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

        //Save data to file When click Save Data in Main Menu
        private void SaveDataMainMenu_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        //Load Saved Data when click Load Data in Main Menu
        private void loadDataMainMenu_Click(object sender, EventArgs e)
        {
            ReadData();
            Form1_Activated(null, null);
        }

        //About stuffs, nothing importan
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem_Click(sender, e);
        }

        private void myBlogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://ltops9.wordpress.com");
        }

        private void gitRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/levisre/Counting_Press");
        }
    }
}
