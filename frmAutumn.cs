﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Traditions
{
	public partial class frmAutumn : Form
	{
		public frmAutumn()
		{
			InitializeComponent();
		}
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home2.png");
		}

		private void frmAutumn_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			IntPtr cursor = LoadCursorFromFile(curName);
			this.Cursor = new Cursor(cursor);
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home1.png");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			frmMenu fMenu = new frmMenu();
			fMenu.Show();
			this.Hide();
		}

		private void pictureBox6_MouseEnter(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Calendar\\autumn\\14сsc.png");
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			frm1410 f1410 = new frm1410();
			f1410.Show();
			this.Hide();
		}

		private void pictureBox6_MouseLeave(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Calendar\\autumn\\14сs.png");
		}
	}
}
