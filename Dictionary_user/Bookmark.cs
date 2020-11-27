﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Dictionary_user
{
    public partial class Bookmark : Form
    {
        #region Variable
        private int page = 0;
        private string language1;
        private string language2;
        private string language3;
        private string language4;
        private string language5;
        private string language6;
        private string language7;
        private string language8;
        private string language9;
        private string language10;
        private string language11;
        private string language12;
        private string language13;
        private string command;
        public string time = DateTime.Now.ToString("yyyy'-'MM'-'dd hh':'mm':'ss.ff");
        #endregion
        private void loadImageSource()
        {
            engFlag1.Image = Properties.Resources.united_kingdom;
            engFlag2.Image = Properties.Resources.united_kingdom;
            engFlag3.Image = Properties.Resources.united_kingdom;
            engFlag4.Image = Properties.Resources.united_kingdom;
            engFlag5.Image = Properties.Resources.united_kingdom;
            engFlag6.Image = Properties.Resources.united_kingdom;
            engFlag7.Image = Properties.Resources.united_kingdom;
            engFlag8.Image = Properties.Resources.united_kingdom;
            engFlag9.Image = Properties.Resources.united_kingdom;
            engFlag10.Image = Properties.Resources.united_kingdom;
            engFlag11.Image = Properties.Resources.united_kingdom;
            engFlag12.Image = Properties.Resources.united_kingdom;
            engFlag13.Image = Properties.Resources.united_kingdom;

            vieFlag1.Image = Properties.Resources.vietnam;
            vieFlag2.Image = Properties.Resources.vietnam;
            vieFlag3.Image = Properties.Resources.vietnam;
            vieFlag4.Image = Properties.Resources.vietnam;
            vieFlag5.Image = Properties.Resources.vietnam;
            vieFlag6.Image = Properties.Resources.vietnam;
            vieFlag7.Image = Properties.Resources.vietnam;
            vieFlag8.Image = Properties.Resources.vietnam;
            vieFlag9.Image = Properties.Resources.vietnam;
            vieFlag10.Image = Properties.Resources.vietnam;
            vieFlag11.Image = Properties.Resources.vietnam;
            vieFlag12.Image = Properties.Resources.vietnam;
            vieFlag13.Image = Properties.Resources.vietnam;
        }
        private void loadData()
        {
            loadImageSource();
            if (Database.acction == "showBookmarkList")
                Database.load("select * from bookmark order by id DESC");
            if (Database.loadData.Rows.Count > 0 + 13 * page)
            {
                labelWord1.Text = Database.loadData.Rows[page * 13]["Word"].ToString();
                labelMeaning1.Text = Database.loadData.Rows[page * 13]["meaning"].ToString();
                language1 = Database.loadData.Rows[page * 13]["languages"].ToString();
                speaker1.Visible = true;
                Bookmark1.Visible = true;
                engFlag1.Visible = true;
                vieFlag1.Visible = true;
                if (language1!="English")
                {
                    engFlag1.Image = Properties.Resources.vietnam;
                    vieFlag1.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord1.Visible = false;
                labelMeaning1.Visible = false;
                speaker1.Visible = false;
                Bookmark1.Visible = false;
                engFlag1.Visible = false;
                vieFlag1.Visible = false;
            }
            if (Database.loadData.Rows.Count > 1 + 13 * page)
            {
                labelWord2.Text = Database.loadData.Rows[page * 13 + 1]["Word"].ToString();
                labelMeaning2.Text = Database.loadData.Rows[page * 13 + 1]["meaning"].ToString();
                language2 = Database.loadData.Rows[page * 13 + 1]["languages"].ToString();
                Bookmark2.Visible = true;
                speaker2.Visible = true;
                engFlag2.Visible = true;
                vieFlag2.Visible = true;
                if (language2 != "English")
                {
                    engFlag2.Image = Properties.Resources.vietnam;
                    vieFlag2.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord2.Visible = false;
                labelMeaning2.Visible = false;
                speaker2.Visible = false;
                Bookmark2.Visible = false;
                engFlag2.Visible = false;
                vieFlag2.Visible = false;
            }
            if (Database.loadData.Rows.Count > 2 + 13 * page)
            {
                labelWord3.Text = Database.loadData.Rows[page * 13 + 2]["Word"].ToString();
                labelMeaning3.Text = Database.loadData.Rows[page * 13 + 2]["meaning"].ToString();
                language3 = Database.loadData.Rows[page * 13 + 2]["languages"].ToString();
                Bookmark3.Visible = true;
                speaker3.Visible = true;
                engFlag3.Visible = true;
                vieFlag3.Visible = true;
                if (language3 != "English")
                {
                    engFlag3.Image = Properties.Resources.vietnam;
                    vieFlag3.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord3.Visible = false;
                labelMeaning3.Visible = false;
                speaker3.Visible = false;
                Bookmark3.Visible = false;
                engFlag3.Visible = false;
                vieFlag3.Visible = false;
            }
            if (Database.loadData.Rows.Count > 3 + 13 * page)
            {
                labelWord4.Text = Database.loadData.Rows[page * 13 + 3]["Word"].ToString();
                labelMeaning4.Text = Database.loadData.Rows[page * 13 + 3]["meaning"].ToString();
                language4 = Database.loadData.Rows[page * 13 + 3]["languages"].ToString();
                Bookmark4.Visible = true;
                speaker4.Visible = true;
                engFlag4.Visible = true;
                vieFlag4.Visible = true;
                if (language4 != "English")
                {
                    engFlag4.Image = Properties.Resources.vietnam;
                    vieFlag4.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord4.Visible = false;
                labelMeaning4.Visible = false;
                speaker4.Visible = false;
                Bookmark4.Visible = false;
                engFlag4.Visible = false;
                vieFlag4.Visible = false;
            }
            if (Database.loadData.Rows.Count > 4 + 13 * page)
            {
                labelWord5.Text = Database.loadData.Rows[page * 13 + 4]["Word"].ToString();
                labelMeaning5.Text = Database.loadData.Rows[page * 13 + 4]["meaning"].ToString();
                language5 = Database.loadData.Rows[page * 13 + 4]["languages"].ToString();
                Bookmark5.Visible = true;
                speaker5.Visible = true;
                engFlag5.Visible = true;
                vieFlag5.Visible = true;
                if (language5 != "English")
                {
                    engFlag5.Image = Properties.Resources.vietnam;
                    vieFlag5.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord5.Visible = false;
                labelMeaning5.Visible = false;
                speaker5.Visible = false;
                Bookmark5.Visible = false;
                engFlag5.Visible = false;
                vieFlag5.Visible = false;
            }
            if (Database.loadData.Rows.Count > 5 + 13 * page)
            {
                labelWord6.Text = Database.loadData.Rows[page * 13 + 5]["Word"].ToString();
                labelMeaning6.Text = Database.loadData.Rows[page * 13 + 5]["meaning"].ToString();
                language6 = Database.loadData.Rows[page * 13 + 5]["languages"].ToString();
                Bookmark6.Visible = true;
                speaker6.Visible = true;
                engFlag6.Visible = true;
                vieFlag6.Visible = true;
                if (language6 != "English")
                {
                    engFlag6.Image = Properties.Resources.vietnam;
                    vieFlag6.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord6.Visible = false;
                labelMeaning6.Visible = false;
                speaker6.Visible = false;
                Bookmark6.Visible = false;
                engFlag6.Visible = false;
                vieFlag6.Visible = false;
            }
            if (Database.loadData.Rows.Count > 6 + 13 * page)
            {
                labelWord7.Text = Database.loadData.Rows[page * 13 + 6]["Word"].ToString();
                labelMeaning7.Text = Database.loadData.Rows[page * 13 + 6]["meaning"].ToString();
                language7 = Database.loadData.Rows[page * 13 + 6]["languages"].ToString();
                Bookmark7.Visible = true;
                speaker7.Visible = true;
                engFlag7.Visible = true;
                vieFlag7.Visible = true;
                if (language7 != "English")
                {
                    engFlag7.Image = Properties.Resources.vietnam;
                    vieFlag7.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord7.Visible = false;
                labelMeaning7.Visible = false;
                speaker7.Visible = false;
                Bookmark7.Visible = false;
                engFlag7.Visible = false;
                vieFlag7.Visible = false;
            }
            if (Database.loadData.Rows.Count > 7 + 13 * page)
            {
                labelWord8.Text = Database.loadData.Rows[page * 13 + 7]["Word"].ToString();
                labelMeaning8.Text = Database.loadData.Rows[page * 13 + 7]["meaning"].ToString();
                language8 = Database.loadData.Rows[page * 13 + 7]["languages"].ToString();
                Bookmark8.Visible = true;
                speaker8.Visible = true;
                engFlag8.Visible = true;
                vieFlag8.Visible = true;
                if (language8 != "English")
                {
                    engFlag8.Image = Properties.Resources.vietnam;
                    vieFlag8.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord8.Visible = false;
                labelMeaning8.Visible = false;
                speaker8.Visible = false;
                Bookmark8.Visible = false;
                engFlag8.Visible = false;
                vieFlag8.Visible = false;
            }
            if (Database.loadData.Rows.Count > 8 + 13 * page)
            {
                labelWord9.Text = Database.loadData.Rows[page * 13 + 8]["Word"].ToString();
                labelMeaning9.Text = Database.loadData.Rows[page * 13 + 8]["meaning"].ToString();
                language9 = Database.loadData.Rows[page * 13 + 8]["languages"].ToString();
                Bookmark9.Visible = true;
                speaker9.Visible = true;
                engFlag9.Visible = true;
                vieFlag9.Visible = true;
                if (language9 != "English")
                {
                    engFlag9.Image = Properties.Resources.vietnam;
                    vieFlag9.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord9.Visible = false;
                labelMeaning9.Visible = false;
                speaker9.Visible = false;
                Bookmark9.Visible = false;
                engFlag9.Visible = false;
                vieFlag9.Visible = false;
            }
            if (Database.loadData.Rows.Count > 9 + 13 * page)
            {
                labelWord10.Text = Database.loadData.Rows[page * 13 + 9]["Word"].ToString();
                labelMeaning10.Text = Database.loadData.Rows[page * 13 + 9]["meaning"].ToString();
                language10 = Database.loadData.Rows[page * 13 + 9]["languages"].ToString();
                Bookmark10.Visible = true;
                speaker10.Visible = true;
                engFlag10.Visible = true;
                vieFlag10.Visible = true;
                if (language10 != "English")
                {
                    engFlag10.Image = Properties.Resources.vietnam;
                    vieFlag10.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord10.Visible = false;
                labelMeaning10.Visible = false;
                speaker10.Visible = false;
                Bookmark10.Visible = false;
                engFlag10.Visible = false;
                vieFlag10.Visible = false;
            }
            if (Database.loadData.Rows.Count > 10 + 13 * page)
            {
                labelWord11.Text = Database.loadData.Rows[page * 13 + 10]["Word"].ToString();
                labelMeaning11.Text = Database.loadData.Rows[page * 13 + 10]["meaning"].ToString();
                language11 = Database.loadData.Rows[page * 13 + 11]["languages"].ToString();
                Bookmark11.Visible = true;
                speaker11.Visible = true;
                engFlag11.Visible = true;
                vieFlag11.Visible = true;
                if (language11 != "English")
                {
                    engFlag11.Image = Properties.Resources.vietnam;
                    vieFlag11.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord11.Visible = false;
                labelMeaning11.Visible = false;
                speaker11.Visible = false;
                Bookmark11.Visible = false;
                engFlag11.Visible = false;
                vieFlag11.Visible = false;
            }
            if (Database.loadData.Rows.Count > 11 + 13 * page)
            {
                labelWord12.Text = Database.loadData.Rows[page * 13 + 11]["Word"].ToString();
                labelMeaning12.Text = Database.loadData.Rows[page * 13 + 11]["meaning"].ToString();
                language12 = Database.loadData.Rows[page * 13 + 11]["languages"].ToString();
                Bookmark12.Visible = true;
                speaker12.Visible = true;
                engFlag12.Visible = true;
                vieFlag12.Visible = true;
                if (language12 != "English")
                {
                    engFlag12.Image = Properties.Resources.vietnam;
                    vieFlag12.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord12.Visible = false;
                labelMeaning12.Visible = false;
                speaker12.Visible = false;
                Bookmark12.Visible = false;
                engFlag12.Visible = false;
                vieFlag12.Visible = false;
            }
            if (Database.loadData.Rows.Count > 12 + 13 * page)
            {
                labelWord13.Text = Database.loadData.Rows[page * 13 + 12]["Word"].ToString();
                labelMeaning13.Text = Database.loadData.Rows[page * 13 + 12]["meaning"].ToString();
                language13 = Database.loadData.Rows[page * 13 + 12]["languages"].ToString();
                Bookmark13.Visible = true;
                speaker13.Visible = true;
                engFlag13.Visible = true;
                vieFlag13.Visible = true;
                if (language13 != "English")
                {
                    engFlag13.Image = Properties.Resources.vietnam;
                    vieFlag13.Image = Properties.Resources.united_kingdom;
                }
            }
            else
            {
                labelWord13.Visible = false;
                labelMeaning13.Visible = false;
                speaker13.Visible = false;
                Bookmark13.Visible = false;
                engFlag13.Visible = false;
                vieFlag13.Visible = false;
            }
        }           
        public Bookmark()
        {
            InitializeComponent();
            loadData();
        }

        private void speaker1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();  
            synth.SetOutputToDefaultAudioDevice();
            if (language1 == "English")
                synth.Speak(labelWord1.Text);
            else synth.Speak(labelMeaning1.Text);       
        }

        private void speaker2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language2 == "English")
                synth.Speak(labelWord2.Text);
            else synth.Speak(labelMeaning2.Text);
        }

        private void speaker3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language3 == "English")
                synth.Speak(labelWord3.Text);
            else synth.Speak(labelMeaning3.Text);
        }

        private void speaker4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language4 == "English")
                synth.Speak(labelWord4.Text);
            else synth.Speak(labelMeaning4.Text);
        }

        private void speaker5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language5 == "English")
                synth.Speak(labelWord5.Text);
            else synth.Speak(labelMeaning5.Text);
        }

        private void speaker6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language6 == "English")
                synth.Speak(labelWord6.Text);
            else synth.Speak(labelMeaning6.Text);
        }

        private void speaker7_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language7 == "English")
                synth.Speak(labelWord7.Text);
            else synth.Speak(labelMeaning7.Text);
        }

        private void speaker8_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language8 == "English")
                synth.Speak(labelWord8.Text);
            else synth.Speak(labelMeaning8.Text);
        }

        private void speaker9_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language9 == "English")
                synth.Speak(labelWord9.Text);
            else synth.Speak(labelMeaning9.Text);
        }

        private void speaker10_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language10 == "English")
                synth.Speak(labelWord10.Text);
            else synth.Speak(labelMeaning10.Text);
        }

        private void speaker11_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language11 == "English")
                synth.Speak(labelWord11.Text);
            else synth.Speak(labelMeaning11.Text);
        }

        private void speaker12_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language12 == "English")
                synth.Speak(labelWord12.Text);
            else synth.Speak(labelMeaning12.Text);
        } 

        private void speaker13_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            if (language13 == "English")
                synth.Speak(labelWord13.Text);
            else synth.Speak(labelMeaning13.Text);
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            page = 0;
            loadData();
            Bookmark1.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark2.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark3.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark4.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark5.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark6.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark7.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark8.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark9.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark10.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark11.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark12.IconColor = Color.FromArgb(238, 26, 74);
            Bookmark13.IconColor = Color.FromArgb(238, 26, 74);
        }

        private void Bookmark1_Click(object sender, EventArgs e)
        {
            if (Bookmark1.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord1.Text + "'" + "AND languages=" + "'" + language1 + "'";
                Database.deleteBookmark(command);
                Bookmark1.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark1.IconColor= Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord1.Text, labelMeaning1.Text, language1, time);
            }
        }

        private void Bookmark2_Click(object sender, EventArgs e)
        {
            if (Bookmark2.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord2.Text + "'" + "AND languages=" + "'" + language2 + "'";
                Database.deleteBookmark(command);
                Bookmark2.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark2.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord1.Text, labelMeaning2.Text, language2, time);
            }
        }

        private void Bookmark3_Click(object sender, EventArgs e)
        {
            if (Bookmark3.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord3.Text + "'" + "AND languages=" + "'" + language3 + "'";
                Database.deleteBookmark(command);
                Bookmark3.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark3.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord3.Text, labelMeaning3.Text, language3, time);
            }
        }

        private void Bookmark4_Click(object sender, EventArgs e)
        {
            if (Bookmark4.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord4.Text + "'" + "AND languages=" + "'" + language4 + "'";
                Database.deleteBookmark(command);
                Bookmark4.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark4.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord4.Text, labelMeaning4.Text, language4, time);
            }
        }

        private void Bookmark5_Click(object sender, EventArgs e)
        {
            if (Bookmark5.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord5.Text + "'" + "AND languages=" + "'" + language5 + "'";
                Database.deleteBookmark(command);
                Bookmark5.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark5.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord5.Text, labelMeaning5.Text, language5, time);
            }
        }

        private void Bookmark6_Click(object sender, EventArgs e)
        {
            if (Bookmark6.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord6.Text + "'" + "AND languages=" + "'" + language6 + "'";
                Database.deleteBookmark(command);
                Bookmark6.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark6.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord6.Text, labelMeaning6.Text, language6, time);
            }
        }

        private void Bookmark7_Click(object sender, EventArgs e)
        {
            if (Bookmark7.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord7.Text + "'" + "AND languages=" + "'" + language7 + "'";
                Database.deleteBookmark(command);
                Bookmark7.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark7.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord7.Text, labelMeaning7.Text, language7, time);
            }
        }

        private void Bookmark8_Click(object sender, EventArgs e)
        {
            if (Bookmark8.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord8.Text + "'" + "AND languages=" + "'" + language8 + "'";
                Database.deleteBookmark(command);
                Bookmark8.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark8.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord8.Text, labelMeaning8.Text, language8, time);
            }
        }

        private void Bookmark9_Click(object sender, EventArgs e)
        {
            if (Bookmark9.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord9.Text + "'" + "AND languages=" + "'" + language9 + "'";
                Database.deleteBookmark(command);
                Bookmark9.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark9.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord9.Text, labelMeaning9.Text, language9, time);
            }
        }

        private void Bookmark10_Click(object sender, EventArgs e)
        {
            if (Bookmark10.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord10.Text + "'" + "AND languages=" + "'" + language10 + "'";
                Database.deleteBookmark(command);
                Bookmark10.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark10.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord10.Text, labelMeaning10.Text, language10, time);
            }
        }

        private void Bookmark11_Click(object sender, EventArgs e)
        {
            if (Bookmark11.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord11.Text + "'" + "AND languages=" + "'" + language11 + "'";
                Database.deleteBookmark(command);
                Bookmark11.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark11.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord11.Text, labelMeaning11.Text, language11, time);
            }
        }

        private void Bookmark12_Click(object sender, EventArgs e)
        {
            if (Bookmark12.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord12.Text + "'" + "AND languages=" + "'" + language12 + "'";
                Database.deleteBookmark(command);
                Bookmark12.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark12.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord12.Text, labelMeaning12.Text, language12, time);
            }
        }

        private void Bookmark13_Click(object sender, EventArgs e)
        {
            if (Bookmark13.IconColor == Color.FromArgb(238, 26, 74))
            {
                command = "delete from bookmark where word =" + "'" + labelWord13.Text + "'" + "AND languages=" + "'" + language13 + "'";
                Database.deleteBookmark(command);
                Bookmark13.IconColor = Color.Gainsboro;
            }
            else
            {
                Bookmark13.IconColor = Color.FromArgb(238, 26, 74);
                Database.insertBookmark(labelWord13.Text, labelMeaning13.Text, language13, time);
            }
        }
    }
}
