using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting_Bingo
{
    public partial class startupForm : Form
    {
        static void Shuffle(Button bingoButton1, Button bingoButton2, Button bingoButton3, Button bingoButton4, Button bingoButton5, 
                Button bingoButton6, Button bingoButton7, Button bingoButton8, Button bingoButton9, Button bingoButton10,
                Button bingoButton11, Button bingoButton12, Button bingoButton14, Button bingoButton15, Button bingoButton16, 
                Button bingoButton17, Button bingoButton18, Button bingoButton19, Button bingoButton20, Button bingoButton21, 
                Button bingoButton22, Button bingoButton23,Button bingoButton24, Button bingoButton25)
            {
                List<string> space = new List<string>();
                space.Add("\"Can you hear me! ? \"");
                space.Add("Joe asking someone a question after their answer");
                space.Add("Joe one-liner");
                space.Add("Joe putting someone on the spot");
                space.Add("Request from AV brother denied");
                space.Add("American Gothic painting");
                space.Add("Carl Garrett won't take it");
                space.Add("Unmuted During the Song");
                space.Add("Poor Video");
                space.Add("Too Quiet");
                space.Add("The Danko Singing Group");
                space.Add("JW Wiki");
                space.Add("Another Sing-Along Announced");
                space.Add("Accidental Unmuting");
                space.Add("Raising Literal Hand");
                space.Add("Awful Green Screen");
                space.Add("Comment Longer than 1 Minute");
                space.Add("\"These trying and uncertain times\"");
                space.Add("Sprititual Pet");
                space.Add("Awful Lighting");
                space.Add("Joe's Phone Going Off");
                space.Add("*Chirp*");
                space.Add("Bad Camera Angle");
                space.Add("Overtime");
                space.Add("\"Technical Difficulties\"");
                space.Add("\"Let the attendant know and he will give you a call\"");
                space.Add("*Echo*");
                space.Add("Bombastic Balmaceda");
                space.Add("Unintelligible Comment");
                space.Add("Conductor clearing throat during reading");
                space.Add("Impatient Conductor");
                space.Add("I did the research");
                space.Add("\"You're muted\"");
                space.Add("*Awkward Silence*");

            Random rand = new Random();

                int index1 = rand.Next(0, space.Count);
                bingoButton1.Text = space[index1];
                space.RemoveAt(index1);

                int index2 = rand.Next(0, space.Count);
                bingoButton2.Text = space[index2];
                space.RemoveAt(index2);

                int index3 = rand.Next(0, space.Count);
                bingoButton3.Text = space[index3];
                space.RemoveAt(index3);

                int index4 = rand.Next(0, space.Count);
                bingoButton4.Text = space[index4];
                space.RemoveAt(index4);

                int index5 = rand.Next(0, space.Count);
                bingoButton5.Text = space[index5];
                space.RemoveAt(index5);

                int index6 = rand.Next(0, space.Count);
                bingoButton6.Text = space[index6];
                space.RemoveAt(index6);

                int index7 = rand.Next(0, space.Count);
                bingoButton7.Text = space[index7];
                space.RemoveAt(index7);

                int index8 = rand.Next(0, space.Count);
                bingoButton8.Text = space[index8];
                space.RemoveAt(index8);

                int index9 = rand.Next(0, space.Count);
                bingoButton9.Text = space[index9];
                space.RemoveAt(index9);

                int index10 = rand.Next(0, space.Count);
                bingoButton10.Text = space[index10];
                space.RemoveAt(index10);

                int index11 = rand.Next(0, space.Count);
                bingoButton11.Text = space[index11];
                space.RemoveAt(index11);

                int index12 = rand.Next(0, space.Count);
                bingoButton12.Text = space[index12];
                space.RemoveAt(index12);

                int index14 = rand.Next(0, space.Count);
                bingoButton14.Text = space[index14];
                space.RemoveAt(index14);

                int index15 = rand.Next(0, space.Count);
                bingoButton15.Text = space[index15];
                space.RemoveAt(index15);

                int index16 = rand.Next(0, space.Count);
                bingoButton16.Text = space[index16];
                space.RemoveAt(index16);

                int index17 = rand.Next(0, space.Count);
                bingoButton17.Text = space[index17];
                space.RemoveAt(index17);

                int index18 = rand.Next(0, space.Count);
                bingoButton18.Text = space[index18];
                space.RemoveAt(index18);

                int index19 = rand.Next(0, space.Count);
                bingoButton19.Text = space[index19];
                space.RemoveAt(index19);

                int index20 = rand.Next(0, space.Count);
                bingoButton20.Text = space[index20];
                space.RemoveAt(index20);

                int index21 = rand.Next(0, space.Count);
                bingoButton21.Text = space[index21];
                space.RemoveAt(index21);

                int index22 = rand.Next(0, space.Count);
                bingoButton22.Text = space[index22];
                space.RemoveAt(index22);

                int index23 = rand.Next(0, space.Count);
                bingoButton23.Text = space[index23];
                space.RemoveAt(index23);

                int index24 = rand.Next(0, space.Count);
                bingoButton24.Text = space[index24];
                space.RemoveAt(index24);

                int index25 = rand.Next(0, space.Count);
                bingoButton25.Text = space[index25];
                space.RemoveAt(index25);
            }

        public bool button1WasClicked = false;
        public bool button2WasClicked = false;
        public bool button3WasClicked = false;
        public bool button4WasClicked = false;
        public bool button5WasClicked = false;
        public bool button6WasClicked = false;
        public bool button7WasClicked = false;
        public bool button8WasClicked = false;
        public bool button9WasClicked = false;
        public bool button10WasClicked = false;
        public bool button11WasClicked = false;
        public bool button12WasClicked = false;
        public bool button14WasClicked = false;
        public bool button15WasClicked = false;
        public bool button16WasClicked = false;
        public bool button17WasClicked = false;
        public bool button18WasClicked = false;
        public bool button19WasClicked = false;
        public bool button20WasClicked = false;
        public bool button21WasClicked = false;
        public bool button22WasClicked = false;
        public bool button23WasClicked = false;
        public bool button24WasClicked = false;
        public bool button25WasClicked = false;
        public int bingoWins = 0;
        public int shuffleButtonPress = 0;
        public startupForm()

        {
            InitializeComponent();
        }

        private void startupForm_Load(object sender, EventArgs e)
        {
            Shuffle(bingoButton1, bingoButton2, bingoButton3, bingoButton4, bingoButton5,
                    bingoButton6, bingoButton7, bingoButton8, bingoButton9, bingoButton10,
                    bingoButton11, bingoButton12, bingoButton14, bingoButton15, bingoButton16,
                    bingoButton17, bingoButton18, bingoButton19, bingoButton20, bingoButton21,
                    bingoButton22, bingoButton23, bingoButton24, bingoButton25);

            bingoWinBox.ReadOnly = true;
        }

        private void bingoButton1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            bingoButton1.Enabled = false;
            bingoButton1.BackColor = Color.FromArgb(125, Color.Red);

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) ||
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true) ||
                (button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) ||
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) ||
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            bingoButton2.Enabled = false;
            bingoButton2.BackColor = Color.FromArgb(125, Color.Red);

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) ||
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            bingoButton3.Enabled = false;
            bingoButton3.BackColor = Color.FromArgb(125, Color.Red);

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) ||
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            bingoButton4.Enabled = false;
            bingoButton4.BackColor = Color.FromArgb(125, Color.Red);

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) ||
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            bingoButton5.Enabled = false;
            bingoButton5.BackColor = Color.FromArgb(125, Color.Red);

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) ||
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true) ||
                (button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true) ||
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) ||
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            bingoButton6.Enabled = false;
            bingoButton6.BackColor = Color.FromArgb(125, Color.Red);

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) ||
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton7_Click(object sender, EventArgs e)
        {
            button7WasClicked = true;
            bingoButton7.Enabled = false;
            bingoButton7.BackColor = Color.FromArgb(125, Color.Red);

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) ||
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true) ||
                (button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) ||
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) ||
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton8_Click(object sender, EventArgs e)
        {
            button8WasClicked = true;
            bingoButton8.Enabled = false;
            bingoButton8.BackColor = Color.FromArgb(125, Color.Red);

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) ||
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton9_Click(object sender, EventArgs e)
        {
            button9WasClicked = true;
            bingoButton9.Enabled = false;
            bingoButton9.BackColor = Color.FromArgb(125, Color.Red);

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) ||
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true) ||
                (button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) ||
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) ||
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton10_Click(object sender, EventArgs e)
        {
            button10WasClicked = true;
            bingoButton10.Enabled = false;
            bingoButton10.BackColor = Color.FromArgb(125, Color.Red);

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) &&
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button6WasClicked == true && button7WasClicked == true && button8WasClicked == true && button9WasClicked == true && button10WasClicked == true) ||
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton11_Click(object sender, EventArgs e)
        {
            button11WasClicked = true;
            bingoButton11.Enabled = false;
            bingoButton11.BackColor = Color.FromArgb(125, Color.Red);

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) &&
                (button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) ||
                (button1WasClicked == true && button2WasClicked == true && button3WasClicked == true && button4WasClicked == true && button5WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton12_Click(object sender, EventArgs e)
        {
            button12WasClicked = true;
            bingoButton12.Enabled = false;
            bingoButton12.BackColor = Color.FromArgb(125, Color.Red);

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) &&
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) ||
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton14_Click(object sender, EventArgs e)
        {
            button14WasClicked = true;
            bingoButton14.Enabled = false;
            bingoButton14.BackColor = Color.FromArgb(125, Color.Red);

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) &&
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) ||
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton15_Click(object sender, EventArgs e)
        {
            button15WasClicked = true;
            bingoButton15.Enabled = false;
            bingoButton15.BackColor = Color.FromArgb(125, Color.Red);

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) &&
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button11WasClicked == true && button12WasClicked == true && button14WasClicked == true && button15WasClicked == true) ||
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton16_Click(object sender, EventArgs e)
        {
            button16WasClicked = true;
            bingoButton16.Enabled = false;
            bingoButton16.BackColor = Color.FromArgb(125, Color.Red);

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) ||
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton17_Click(object sender, EventArgs e)
        {
            button17WasClicked = true;
            bingoButton17.Enabled = false;
            bingoButton17.BackColor = Color.FromArgb(125, Color.Red);

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) ||
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true) ||
                (button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) ||
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true) ||
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton18_Click(object sender, EventArgs e)
        {
            button18WasClicked = true;
            bingoButton18.Enabled = false;
            bingoButton18.BackColor = Color.FromArgb(125, Color.Red);

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) ||
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton19_Click(object sender, EventArgs e)
        {
            button19WasClicked = true;
            bingoButton19.Enabled = false;
            bingoButton19.BackColor = Color.FromArgb(125, Color.Red);

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) ||
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true) ||
                (button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) ||
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true) ||
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());            
            }
        }

        private void bingoButton20_Click(object sender, EventArgs e)
        {
            button20WasClicked = true;
            bingoButton20.Enabled = false;
            bingoButton20.BackColor = Color.FromArgb(125, Color.Red);

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) &&
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button16WasClicked == true && button17WasClicked == true && button18WasClicked == true && button19WasClicked == true && button20WasClicked == true) ||
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton21_Click(object sender, EventArgs e)
        {
            button21WasClicked = true;
            bingoButton21.Enabled = false;
            bingoButton21.BackColor = Color.FromArgb(125, Color.Red);

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) ||
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true) ||
                (button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) ||
                (button1WasClicked == true && button6WasClicked == true && button11WasClicked == true && button16WasClicked == true && button21WasClicked == true) ||
                (button5WasClicked == true && button9WasClicked == true && button17WasClicked == true && button21WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton22_Click(object sender, EventArgs e)
        {
            button22WasClicked = true;
            bingoButton22.Enabled = false;
            bingoButton22.BackColor = Color.FromArgb(125, Color.Red);

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) ||
                (button2WasClicked == true && button7WasClicked == true && button12WasClicked == true && button17WasClicked == true && button22WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton23_Click(object sender, EventArgs e)
        {
            button23WasClicked = true;
            bingoButton23.Enabled = false;
            bingoButton23.BackColor = Color.FromArgb(125, Color.Red);

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) ||
                (button3WasClicked == true && button8WasClicked == true && button18WasClicked == true && button23WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton24_Click(object sender, EventArgs e)
        {
            button24WasClicked = true;
            bingoButton24.Enabled = false;
            bingoButton24.BackColor = Color.FromArgb(125, Color.Red);

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) ||
                (button4WasClicked == true && button9WasClicked == true && button14WasClicked == true && button19WasClicked == true && button24WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void bingoButton25_Click(object sender, EventArgs e)
        {
            button25WasClicked = true;
            bingoButton25.Enabled = false;
            bingoButton25.BackColor = Color.FromArgb(125, Color.Red);

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 3);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("TRIPLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) ||
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true) ||
                (button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) &&
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 2);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("DOUBLE BINGO!   Bingo Wins: " + bingoWins.ToString());
                return;
            }

            if ((button21WasClicked == true && button22WasClicked == true && button23WasClicked == true && button24WasClicked == true && button25WasClicked == true) ||
                (button5WasClicked == true && button10WasClicked == true && button15WasClicked == true && button20WasClicked == true && button25WasClicked == true) ||
                (button1WasClicked == true && button7WasClicked == true && button19WasClicked == true && button25WasClicked == true))
            {
                bingoWins = (bingoWins + 1);
                bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                MessageBox.Show("BINGO!   Bingo Wins: " + bingoWins.ToString());
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Are you sure you want to reset the card?",
                    "Comfirm Reset...",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bingoButton1.Enabled = true;
                    bingoButton2.Enabled = true;
                    bingoButton3.Enabled = true;
                    bingoButton4.Enabled = true;
                    bingoButton5.Enabled = true;
                    bingoButton6.Enabled = true;
                    bingoButton7.Enabled = true;
                    bingoButton8.Enabled = true;
                    bingoButton9.Enabled = true;
                    bingoButton10.Enabled = true;
                    bingoButton11.Enabled = true;
                    bingoButton12.Enabled = true;
                    bingoButton14.Enabled = true;
                    bingoButton15.Enabled = true;
                    bingoButton16.Enabled = true;
                    bingoButton17.Enabled = true;
                    bingoButton18.Enabled = true;
                    bingoButton19.Enabled = true;
                    bingoButton20.Enabled = true;
                    bingoButton21.Enabled = true;
                    bingoButton22.Enabled = true;
                    bingoButton23.Enabled = true;
                    bingoButton24.Enabled = true;
                    bingoButton25.Enabled = true;

                    bingoButton1.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton2.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton3.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton4.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton5.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton6.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton7.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton8.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton9.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton10.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton11.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton12.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton14.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton15.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton16.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton17.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton18.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton19.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton20.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton21.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton22.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton23.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton24.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton25.BackColor = Color.FromArgb(0, Color.Red);

                    button1WasClicked = false;
                    button2WasClicked = false;
                    button3WasClicked = false;
                    button4WasClicked = false;
                    button5WasClicked = false;
                    button6WasClicked = false;
                    button7WasClicked = false;
                    button8WasClicked = false;
                    button9WasClicked = false;
                    button10WasClicked = false;
                    button11WasClicked = false;
                    button12WasClicked = false;
                    button14WasClicked = false;
                    button15WasClicked = false;
                    button16WasClicked = false;
                    button17WasClicked = false;
                    button18WasClicked = false;
                    button19WasClicked = false;
                    button20WasClicked = false;
                    button21WasClicked = false;
                    button22WasClicked = false;
                    button23WasClicked = false;
                    button24WasClicked = false;
                    button25WasClicked = false;

                    bingoWins = 0;

                    bingoWinBox.Text = "Bingo Wins: " + bingoWins.ToString();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                "Comfirm Exit...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("Bingo Wins: " + bingoWins.ToString());
                Application.Exit();
            }
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Are you sure you want to shuffle?",
                    "Comfirm Shuffle...",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bingoButton1.Enabled = true;
                    bingoButton2.Enabled = true;
                    bingoButton3.Enabled = true;
                    bingoButton4.Enabled = true;
                    bingoButton5.Enabled = true;
                    bingoButton6.Enabled = true;
                    bingoButton7.Enabled = true;
                    bingoButton8.Enabled = true;
                    bingoButton9.Enabled = true;
                    bingoButton10.Enabled = true;
                    bingoButton11.Enabled = true;
                    bingoButton12.Enabled = true;
                    bingoButton14.Enabled = true;
                    bingoButton15.Enabled = true;
                    bingoButton16.Enabled = true;
                    bingoButton17.Enabled = true;
                    bingoButton18.Enabled = true;
                    bingoButton19.Enabled = true;
                    bingoButton20.Enabled = true;
                    bingoButton21.Enabled = true;
                    bingoButton22.Enabled = true;
                    bingoButton23.Enabled = true;
                    bingoButton24.Enabled = true;
                    bingoButton25.Enabled = true;

                    bingoButton1.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton2.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton3.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton4.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton5.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton6.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton7.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton8.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton9.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton10.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton11.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton12.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton14.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton15.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton16.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton17.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton18.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton19.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton20.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton21.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton22.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton23.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton24.BackColor = Color.FromArgb(0, Color.Red);
                    bingoButton25.BackColor = Color.FromArgb(0, Color.Red);

                    button1WasClicked = false;
                    button2WasClicked = false;
                    button3WasClicked = false;
                    button4WasClicked = false;
                    button5WasClicked = false;
                    button6WasClicked = false;
                    button7WasClicked = false;
                    button8WasClicked = false;
                    button9WasClicked = false;
                    button10WasClicked = false;
                    button11WasClicked = false;
                    button12WasClicked = false;
                    button14WasClicked = false;
                    button15WasClicked = false;
                    button16WasClicked = false;
                    button17WasClicked = false;
                    button18WasClicked = false;
                    button19WasClicked = false;
                    button20WasClicked = false;
                    button21WasClicked = false;
                    button22WasClicked = false;
                    button23WasClicked = false;
                    button24WasClicked = false;
                    button25WasClicked = false;

                    Shuffle(bingoButton1, bingoButton2, bingoButton3, bingoButton4, bingoButton5,
                        bingoButton6, bingoButton7, bingoButton8, bingoButton9, bingoButton10,
                        bingoButton11, bingoButton12, bingoButton14, bingoButton15, bingoButton16,
                        bingoButton17, bingoButton18, bingoButton19, bingoButton20, bingoButton21,
                        bingoButton22, bingoButton23, bingoButton24, bingoButton25);

                    shuffleButtonPress = (shuffleButtonPress + 1);

                if (shuffleButtonPress == 2)
                {
                    shuffleButton.Enabled = false;
                }
            }
        }

        private void bingoButtonFree_Click(object sender, EventArgs e)
        {
            uwuForm frm = new uwuForm();
            frm.ShowDialog();
        }
    }
}
