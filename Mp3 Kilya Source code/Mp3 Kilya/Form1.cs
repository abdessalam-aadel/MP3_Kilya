using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Media;
using System.IO;

namespace Mp3_Kilya
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.mp3) | *.mp3";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog1.FileName;
                label1.Visible = false;
                load.Visible = false;
                pictureBox1.Visible = true;
                play.Enabled = false;
                pausse.Enabled = false;
                restart.Enabled = true;
                Start.Enabled = true;
                this.totaletemp.Text = openFileDialog1.SafeFileName;
                // Filter il decrit le type de fichier :
                this.label3.Text = openFileDialog1.Filter;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox_path.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            Start.Visible = false;
            restart.Visible = true;
            play.Visible = false;
            pausse.Visible = true;
            play.Enabled = true;
            pausse.Enabled = true;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox_path.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            play.Visible = false;
            pausse.Visible = true;
        }

        private void pausse_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pausse.Visible = false;
            play.Visible = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            label1.Visible = true;
            load.Visible = true;
            pictureBox1.Visible = false;
            pausse.Visible = true;
            Start.Visible = true;
            ambiance_TrackBar1.Value = 20;
            ambiance_Button_21.Visible = true;
            totaletemp.Text = "";
            restart.Enabled = false;
            Start.Enabled = false;
            pausse.Enabled = false;
        }

        private void textBox_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  About Box.
            AboutBox1 K = new AboutBox1();
            K.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
            // this.Opacity = (double) trackBar.Value / 100;
            // axWindowsMediaPlayer1.Ctlcontrols.fastForward();
 
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 20;
        }

        private void ambiance_TrackBar1_ValueChanged()
        {
            // Trackbare 1 pour le Volume
            axWindowsMediaPlayer1.settings.volume = ambiance_TrackBar1.Value;
        }

        private void ambiance_TrackBar2_ValueChanged()
        {
            // Trackbare 2 pour la duree du mp3 
        }

        private void totaletemp_Click(object sender, EventArgs e)
        {
            // le totale du temp du fichier .mp3 qui on veux le lire .

        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            // axWindowsMediaPlayer1.settings.mute = true;
            axWindowsMediaPlayer1.settings.volume = 0;
            ambiance_TrackBar1.Value = 0;
            ambiance_Button_21.Visible = false;
            ambiance_Button_22.Visible = true;
        }

        private void ambiance_Button_22_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 20;
            ambiance_TrackBar1.Value = 20;
            ambiance_Button_21.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // le Temps Découler .

        }

        private void ambiance_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kilya.hyperphp.com/");
        }

    }
}
