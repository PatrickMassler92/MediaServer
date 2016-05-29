using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playlist.DoubleClick += new EventHandler(playlist_MouseDoubleClick);
            string[] filelist = Directory.GetFiles("media");
            foreach(string s in filelist)
            {
                playlist.Items.Add(s.ToString());
            }
        }

        void playlist_MouseDoubleClick(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            vlcplayer.playlist.add(playlist.SelectedItem.ToString());
            vlcplayer.playlist.playItem(0);
        }
    }
}
