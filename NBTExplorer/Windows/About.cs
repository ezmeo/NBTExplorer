using System;
using System.Windows.Forms;

namespace NBTExplorer.Windows
{
    public partial class About : Form
    {
        public About ()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resource = new System.ComponentModel.ComponentResourceManager(typeof(About));
            string linktext = resource.GetString("link.Text");
            Version version = typeof(About).Assembly.GetName().Version;
            linkLabel1.Text = linkLabel1.Text.Replace("{ver}", version.Major + "." + version.Minor + "." + version.Build);
            linkLabel1.LinkArea = new LinkArea(GetLinkPos(linkLabel1.Text, linktext),linktext.Length);
        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ezmeo/NBTExplorer");
        }

        private int GetLinkPos (string text, string linktext)
        {
            int start_pos = text.IndexOf(linktext, StringComparison.Ordinal);
            if(start_pos > 0) { return start_pos; }
            else { return 0; }
        }
    }
}
