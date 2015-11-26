﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingBot
{
    public partial class Frm_Bot : Form
    {
        int Searches = 0;
        Random rndGen = new Random();

        public Frm_Bot()
        {
            InitializeComponent();
        }

        private void Frm_Bot_Load(object sender, EventArgs e)
        {
            Web_Bing.Navigate("http://www.bing.com/");
            MessageBox.Show("Please Sign Into Bing Rewards (User Info is Dumped After Program Completes)");
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (Btn_Start.Text == "Start")
            {
                MessageBox.Show("WARNING: This program assumes you are signed into bing within the web element, and will only work if you are", "Warning!");
                Tmr_Run.Start();
                Btn_Start.Text = "Pause";
            } else if (Btn_Start.Text == "Manual Point Earning")
            {
                Web_Bing.Navigate("https://www.bing.com/rewards/dashboard");
            } else if (Btn_Start.Text == "Pause")
            {
                Tmr_Run.Enabled = !Tmr_Run.Enabled;
            }
        }

        private void Tmr_Run_Tick(object sender, EventArgs e)
        {
            if (Searches < 31)
            {
                try
                {
                    String webLink = "http://www.bing.com/search?q=" + RandySearch();
                    Web_Bing.Navigate(webLink);
                    Searches++;
                    Prg_Main.Value = Searches;
                } catch
                {
                    Console.WriteLine("Page Navigation Failed, Retrying");
                }

            } else
            {
                Tmr_Run.Stop();
                Btn_Start.Text = "Manual Point Earning";
                MessageBox.Show("Auto Point Earning Complete");
            }
        }

        private String RandySearch()
        {
            String[] Question =
            {
                "How Far Can A",
                "What is A",
                "How Do You"
            };

            String[] Noun =
            {
                "Cat",
                "Car",
                "Dog",
                "Person",
                "Human",
                "Drill",
                "Random",
                "Class",
                "Code",
                "Microsoft",
                "Bing",
                "Google",
                "ALIENS",
                "Game",
                "SWAG",
                "Flight",
                "Airplane"
            };

            String[] Action =
            {
                "Swim",
                "Die",
                "Live",
                "Kill",
                "Revive",
                "Play",
                "Program",
                "Code",
                "Fly",
                "Throw",
                "Explode",
                "Explore",
                "Repair",
                "Game",
                "SWAG",
                "Fire"
            };

            return Question[rndGen.Next(0, Question.Length)] + " " + Noun[rndGen.Next(0, Noun.Length)] + " " + Action[rndGen.Next(0, Action.Length)];
        }
    }
}
