using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace XFocus
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            //textBox1.Text = "XFocus is a softare that shows a transparent image across the screen.It can make you fix your attention to your work and study.\r\nEnjoy it!";

        }

        private void About_Load(object sender, EventArgs e)
        {
            label2.Text = "For more information,please visit my blog!.";
            label1.Text = "XFocus is a softare that shows a transparent image across \r\nthe screen.It can make you fix your attention to your work\r\nand study.\r\nEnjoy it!";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("mailto:zphzph1@gmail.com");
            }
            catch
            {
                Clipboard.SetData(DataFormats.Text, (Object)linkLabel2.Text);
                MessageBox.Show("email has copied to clipboard.");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("tencent://message/?uin=554178445");
            }
            catch
            {
                Clipboard.SetData(DataFormats.Text, (Object)linkLabel2.Text);
                MessageBox.Show("qq number has copied to clipboard!");
            }
        }
    }
}
