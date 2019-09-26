using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingMenu
{
    public partial class Form1 : Form
    {
        private int positionX_MaxMenuBar = 185; // X : 185; Y : 6
        private int positionX_MiniMenuBar = 13; // X : 10; Y : 6

        private int widthMaxPanelMenu = 225; // Width : 225 Height : 465
        private int widthMiniPanelMenu = 50; // Width : 50 Height : 465

        public Form1()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMenuBar_Click(object sender, EventArgs e)
        {
            if(picMenuBar.Location.X == 185)
            {
                picMenuBar.Location = new Point(positionX_MiniMenuBar, picMenuBar.Location.Y);
                panelMenu.Size = new Size(widthMiniPanelMenu, panelMenu.Size.Height);
            }
            else
            {
                picMenuBar.Location = new Point(positionX_MaxMenuBar, picMenuBar.Location.Y);
                panelMenu.Size = new Size(widthMaxPanelMenu, panelMenu.Size.Height);
            }
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            this.panelInbox.BackColor = Color.Blue;
            this.panelSend.BackColor = this.panelMenu.BackColor;
            this.panelDraft.BackColor = this.panelMenu.BackColor;
            this.panelSpams.BackColor = this.panelMenu.BackColor;
            this.panelJunk.BackColor = this.panelMenu.BackColor;
            this.panelTrash.BackColor = this.panelMenu.BackColor;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.panelInbox.BackColor = this.panelMenu.BackColor;
            this.panelSend.BackColor = Color.Blue;
            this.panelDraft.BackColor = this.panelMenu.BackColor;
            this.panelSpams.BackColor = this.panelMenu.BackColor;
            this.panelJunk.BackColor = this.panelMenu.BackColor;
            this.panelTrash.BackColor = this.panelMenu.BackColor;
        }

        private void btnDraft_Click(object sender, EventArgs e)
        {
            this.panelInbox.BackColor = this.panelMenu.BackColor;
            this.panelSend.BackColor = this.panelMenu.BackColor;
            this.panelDraft.BackColor = Color.Blue;
            this.panelSpams.BackColor = this.panelMenu.BackColor;
            this.panelJunk.BackColor = this.panelMenu.BackColor;
            this.panelTrash.BackColor = this.panelMenu.BackColor;
        }

        private void btnSpams_Click(object sender, EventArgs e)
        {
            this.panelInbox.BackColor = this.panelMenu.BackColor;
            this.panelSend.BackColor = this.panelMenu.BackColor;
            this.panelDraft.BackColor = this.panelMenu.BackColor;
            this.panelSpams.BackColor = Color.Blue;
            this.panelJunk.BackColor = this.panelMenu.BackColor;
            this.panelTrash.BackColor = this.panelMenu.BackColor;
        }

        private void btnJunk_Click(object sender, EventArgs e)
        {
            this.panelInbox.BackColor = this.panelMenu.BackColor;
            this.panelSend.BackColor = this.panelMenu.BackColor;
            this.panelDraft.BackColor = this.panelMenu.BackColor;
            this.panelSpams.BackColor = this.panelMenu.BackColor;
            this.panelJunk.BackColor = Color.Blue;
            this.panelTrash.BackColor = this.panelMenu.BackColor;
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            this.panelInbox.BackColor = this.panelMenu.BackColor;
            this.panelSend.BackColor = this.panelMenu.BackColor;
            this.panelDraft.BackColor = this.panelMenu.BackColor;
            this.panelSpams.BackColor = this.panelMenu.BackColor;
            this.panelJunk.BackColor = this.panelMenu.BackColor;
            this.panelTrash.BackColor = Color.Blue;
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.picNormal.Visible = true;
            this.picMaximize.Visible = false;
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.picNormal.Visible = false;
            this.picMaximize.Visible = true;
        }
    }
}
