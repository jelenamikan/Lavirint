﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lavirint.Properties;

namespace Lavirint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame game = new NewGame(this);
            game.Show(this);
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            this.btnQuit.BackgroundImage = Resources.Hover_btn;
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            this.btnQuit.BackgroundImage = Resources.Normal_btn;
        }

        private void btnLoadGame_MouseEnter(object sender, EventArgs e)
        {
            this.btnLoadGame.BackgroundImage = Resources.Hover_btn;
        }

        private void btnLoadGame_MouseLeave(object sender, EventArgs e)
        {
            this.btnLoadGame.BackgroundImage = Resources.Normal_btn;
        }

        private void btnInstructions_MouseEnter(object sender, EventArgs e)
        {
            this.btnInstructions.BackgroundImage = Resources.Hover_btn;
        }

        private void btnInstructions_MouseLeave(object sender, EventArgs e)
        {
            this.btnInstructions.BackgroundImage = Resources.Normal_btn;
        }

        private void btnNewGame_MouseEnter(object sender, EventArgs e)
        {
            this.btnNewGame.BackgroundImage = Resources.Hover_btn;
        }

        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            this.btnNewGame.BackgroundImage = Resources.Normal_btn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ova  ne raboti :( popravete ako mozete :D <3
       private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
