﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace psikolojikAnaliz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private async void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            for(int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                listBox1.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                listBox2.Items.Add(openFileDialog1.FileNames[i].ToString());

            }
            
        }
        int i = 0;
        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();

          
           
           
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 3;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        

        private void button8_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private async void button10_Click(object sender, EventArgs e)
        {
           
        }

        private async void button11_Click(object sender, EventArgs e)
        {
           
        }
    }
}