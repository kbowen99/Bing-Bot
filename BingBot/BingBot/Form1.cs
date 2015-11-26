using System;
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
            //open Bing on Load (for sign in)
            Web_Bing.Navigate("http://www.bing.com/");
            //MessageBox.Show("Please Sign Into Bing Rewards (User Info is Dumped After Program Completes)");
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            //The Button of multiple options
            if (Btn_Start.Text == "Start")
            {
                MessageBox.Show("WARNING: This program assumes you are signed into bing within the web element, and will only work if you are", "Warning!");
                Tmr_Run.Start();
                Btn_Start.Text = "Pause";
            }
            else if (Btn_Start.Text == "Manual Point Earning")
            {
                Web_Bing.Navigate("https://www.bing.com/rewards/dashboard");
            }
            else if (Btn_Start.Text == "Pause")
            {
                Tmr_Run.Enabled = !Tmr_Run.Enabled;
            }
        }

        private void Tmr_Run_Tick(object sender, EventArgs e)
        {
            //1-31 = Desktop Searches
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

            } //32-52 = Mobile Searches
            else if (Searches < 53)
            {
                String webLink = "http://www.m.bing.com/search?q=" + RandySearch();
                //Web_Bing.Navigate(webLink);
                //Client Spoofing (+Window Sizing)
                Web_Bing.Width = 320;
                Prg_Main.Width = 320;
                Btn_Start.Width = 320;
                this.Width = 360;
                Web_Bing.Navigate(webLink, null, null, string.Format("User-Agent: {0}", "Opera/9.80 (J2ME/MIDP; Opera Mini/9 (Compatible; MSIE:9.0; iPhone; BlackBerry9700; AppleWebKit/24.746; U; en) Presto/2.5.25 Version/10.54"));
                Searches++;
                Prg_Main.Value = Searches;
            }//manual points
            else if (Searches > 52)
            {
                //Window Sizing & Cleanup
                Web_Bing.Navigate("https://www.bing.com/rewards/dashboard");
                Web_Bing.Width = 1160;
                Prg_Main.Width = 1160;
                Btn_Start.Width = 1160;
                this.Width = 1200;
                Tmr_Run.Stop();
                Btn_Start.Text = "Manual Point Earning";
                MessageBox.Show("Auto Point Earning Complete");
            }
        }

        private String RandySearch()
        {
            //Random Question Generator
            String[] Question =
            {
                "How Far Can A",
                "What is A",
                "How Do You",
                "Where is",
                "",
                "Why Do"
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
                "Airplane",
                "Fallout 4",
                "IPod",
                "Windows",
                "Spiderman",
                "Engine",
                "Kayak",
                "Wiki",
                "Earth",
                "Luigi",
                "Mario",
                "Pizza",
                "Nintendo",
                "Apple",
                "3d Printer",
                "music",
                "Pandora",
                "Minecraft",
                "The Sims",
                "TechNet",
                "Wikipedia"
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
                "Fire",
                "Search",
                "Meow",
                "urbandictionary",
                "Wiki",
                "Forumn",
                "Print",
                "Skype",
                "Netflix",
                "Download",
                "Free"
            };

            return Question[rndGen.Next(0, Question.Length)] + " " + Noun[rndGen.Next(0, Noun.Length)] + " " + Action[rndGen.Next(0, Action.Length)];
        }
    }
}
