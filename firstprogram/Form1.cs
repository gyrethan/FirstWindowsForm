using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace firstprogram
{
    public partial class Form1 : Form
    {

        List<Panel> listPanel = new List<Panel>();

        private SoundPlayer sPlayer;
        private SoundPlayer sPlayer2;
        private SoundPlayer sPlayer3;
        int panelIndex = 0;

        public Form1()
        {
            InitializeComponent();
            sPlayer = new SoundPlayer("spagettScareSound.wav");
            sPlayer2 = new SoundPlayer("intenseMusic.wav");
            sPlayer3 = new SoundPlayer("awkwardContact.wav");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(spagettScare);
            listPanel.Add(didHeGetYou);
            listPanel.Add(contactInfo);
            listPanel[0].BringToFront();
            timer1.Start();
            sPlayer.Play();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            sPlayer2.Stop();
            listPanel[2].BringToFront();
            sPlayer3.Play();

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            sPlayer.Stop();
            spagettScareGif.Enabled = true;
            listPanel[0].BringToFront();
            timer1.Start();
            panelIndex = panelIndex - 1;
            sPlayer.Play();           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelIndex < 1)
            {
                listPanel[1].BringToFront();
                panelIndex = panelIndex + 1;
                sPlayer.Stop();
                timer1.Stop();
                sPlayer2.Play();
                spagettScareGif.Enabled = false;
            }           
        }
    }

}
