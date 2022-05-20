﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top - 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top + 10;
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox1.Size = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void numericUpDown2_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox1.Size = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            // ku ku
        }
    }
}
