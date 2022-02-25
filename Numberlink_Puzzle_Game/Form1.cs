using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numberlink_Puzzle_Game
{
    public partial class Form1 : Form
    {
        private List<Button> Options = new List<Button>();
        int TotalTime = 0;
        int second = 0;
        int minute = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            List<int> Numbers = new List<int>(); //Reqemlerin tutuldugu list.
            Random RND = new Random();

            for (int m = 1; m <= (int.Parse(TxtHorizontal.Text) * (int.Parse(TxtVertical.Text))) / 2; m++)//Her reqemden iki-iki.
            {
                Numbers.Add(m);
                Numbers.Add(m);
            }

            for (int i = 0; i < Convert.ToInt32(TxtHorizontal.Text); i++)
            {
                for (int a = 0; a < Convert.ToInt32(TxtVertical.Text); a++)
                {
                    int EnteredNumber = RND.Next(0, Numbers.Count);
                    Button BTN = new Button
                    {
                        Name = Numbers[EnteredNumber].ToString(),
                        Text = null,
                        Tag = Numbers[EnteredNumber].ToString(),
                        Height = 45,
                        Width = 45,
                        Left = (i) * 45,//Buttonun olcusunden sonra bashlasin.
                        Top = (a) * 45,
                        Font = new Font("Arial", 12, FontStyle.Bold)
                    };
                    BTN.Click += BTN_Click;
                    GroupGameSpace.Controls.Add(BTN);
                    var ChoosenNumber = Numbers[EnteredNumber];
                    Numbers.Remove(ChoosenNumber);
                }
            }
            if (MessageBox.Show("Are you ready to get started?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                second = 0;
                minute = 0;
                timer1.Enabled = true;
                timer1.Start();
            }

        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender; //BTN-nin ozellikleri birbasha elcatmaz oldugu ucun "BTN"-nin senderini "Bt"-ye beraberleshdirdik.
            if (string.IsNullOrEmpty(Bt.Text))
            {
                Bt.Text = Bt.Name; 
                Bt.Refresh(); //Novbeti emeliyyatlara kecid etmek ucun yenilenme.
                Options.Add(Bt);
            }

            if (Options.Count == 2)
            {
                System.Threading.Thread.Sleep(500);//Emeliyyati 0.5 san gecikdir.
                if (Options[0].Text == Options[1].Text)
                {
                    Options[0].Dispose();
                    Options[1].Dispose();
                    if (GroupGameSpace.Controls.Count == 0)
                    {
                        MessageBox.Show("The game is over");
                        timer1.Enabled = false;
                        timer1.Stop();
                    }
                }
                else
                {
                    Options[0].Text = null;
                    Options[1].Text = null;
                    NumericMistake.Value++;
                }
                Options.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            LblSecond.Text = second.ToString();
            if (second == 60)
            {
                minute++;
                LblMinute.Text = minute.ToString();
                second = 0;
            }
            TotalTime++;
        }

        private void BtnVeryEasy_Click(object sender, EventArgs e)
        {
            TxtHorizontal.Text = "4";
            TxtVertical.Text = "3";
        }

        private void BtnEasy_Click(object sender, EventArgs e)
        {
            TxtHorizontal.Text = "5";
            TxtVertical.Text = "6";
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        {
            TxtHorizontal.Text = "7";
            TxtVertical.Text = "6";
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            TxtHorizontal.Text = "8";
            TxtVertical.Text = "9";
        }

        private void BtnVeryHard_Click(object sender, EventArgs e)
        {
            TxtHorizontal.Text = "10";
            TxtVertical.Text = "10";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (GroupGameSpace.Controls.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to stop playing?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                    GroupGameSpace.Controls.Clear();
                    second = 0;
                    minute = 0;
                    LblSecond.Text = second.ToString();
                    LblMinute.Text = minute.ToString();
                    NumericMistake.Value = 0;
                }
            }
        }
    }
}
