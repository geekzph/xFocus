using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace XFocus
{
        

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern long GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern long SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);
        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern int SetLayeredWindowAttributes(IntPtr Handle, int crKey, byte bAlpha, int dwFlags);
        const int GWL_EXSTYLE = -20;
        const int WS_EX_TRANSPARENT = 0x20;
        const int WS_EX_LAYERED = 0x80000;
        const int LWA_ALPHA = 2; 　  

        public Form1()
        {
            InitializeComponent();
            //无边框   
            this.FormBorderStyle = FormBorderStyle.None;
            //不在任务栏中显示，用户按开始键或Ctrl+Tab时   
            this.ShowInTaskbar = false;
            //置于顶层   
            this.TopMost = true;
            //this.TopLevel = true ;
            //窗口布满整个屏幕   
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            //查看任务管理器时用   
            //this.Height -= 30;   
            //接受键盘输入，用于快捷键，如Esc   
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.notifyIcon1.Visible = true;
            //Color myColor = new Color(100, 1, 1, 1);
            //Color cl = new Color(100, 1, 1);
            this.BackColor = Color.FromArgb(0,0,0);
            //this.BackColor = Color.Black;
　　　　　　this.WindowState=FormWindowState.Maximized; 　  
　　　　　　SetWindowLong(Handle,GWL_EXSTYLE,GetWindowLong(Handle,GWL_EXSTYLE)|WS_EX_TRANSPARENT|WS_EX_LAYERED); 　  
　　　　　　SetLayeredWindowAttributes(Handle,0,133,LWA_ALPHA); 　  

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xFocusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
