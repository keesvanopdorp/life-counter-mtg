using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Threading;

namespace life_counter
{
    public partial class Form1 : Form
    {
       
        public string Player2
        {
            get;
            set;
        }
        string Player1
        {
            set;
            get; 
        }
        public int sec;
        public int min;
        public int uur;
        int lifetotalA = 20;
        int lifetotalB = 20;
        public bool win_counter = true;
        public int winA;
        public int winB;
        public int GNFTW=2; // stands for Games Needed For The Win
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = lifetotalA.ToString();
            textBox2.Text = lifetotalB.ToString();
            Player1 = textBox4.Text;
            Player2 = textBox1.Text;
            textBox7.Text = winA.ToString();
            textBox8.Text = winB.ToString();

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
        void reset()
        {
            lifetotalA = 20;
            lifetotalB = 20;
            textBox3.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox3.Text = lifetotalA.ToString();
            textBox2.Text = lifetotalB.ToString();
            timer1.Stop();
            sec = 0;
            textBox6.Text = sec.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox5.Text += (string.Format("{0} has lost 2 live", Player1)) + System.Environment.NewLine;
            lifetotalA = lifetotalA - 2;
            textBox3.Text = lifetotalA.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.Text += (string.Format("{0} has gained 2 lives", Player1)) + System.Environment.NewLine;
            lifetotalA = lifetotalA + 2;
            textBox3.Text = lifetotalA.ToString();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox5.Text = (string.Format("{0} has gained 5 lives", Player1)) + System.Environment.NewLine;
            lifetotalA = lifetotalA + 5;
            textBox3.Text = lifetotalA.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox5.Text += (string.Format("{0} has gained 1 live",Player1)) + System.Environment.NewLine;
            lifetotalA = lifetotalA + 1;
            textBox3.Text = lifetotalA.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string player1 = textBox4.Text;
            textBox3.Clear();
            textBox5.Text += (string.Format("{0} has lost 1 live",Player1)) + System.Environment.NewLine;
            lifetotalA = lifetotalA - 1;
            textBox3.Text = lifetotalA.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            lifetotalA = 20;
            textBox3.Text = lifetotalA.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if(lifetotalA <= 0){
                MessageBox.Show(string.Format("{0} has won the game", Player2));
                reset();
                if (win_counter == true)
                {
                    winB = winB + 1;
                    textBox8.Text = winB.ToString();

                    if (winB== GNFTW)
                    {
                        MessageBox.Show(string.Format("{0} has won the match",Player2));
                        reset();
                        winA = 0;
                        winB = 0;
                        textBox7.Text = winA.ToString();
                        textBox8.Text = winB.ToString();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Text += (string.Format("{0} has lost 5 lives", Player2)) + System.Environment.NewLine;
            lifetotalB = lifetotalB - 5;
            textBox2.Text = lifetotalB.ToString();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Text += (string.Format("{0} has lost 2 lives", Player2)) + System.Environment.NewLine;
            lifetotalB = lifetotalB - 2;
            textBox2.Text = lifetotalB.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Text += (string.Format("{0} has gainded 2 lives", Player2)) + System.Environment.NewLine;
            lifetotalB = lifetotalB + 2;
            textBox2.Text = lifetotalB.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Text += (string.Format("{0} has gainded 5 lives", Player2)) + System.Environment.NewLine;
            lifetotalB = lifetotalB + 5;
            textBox2.Text = lifetotalB.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Text += (string.Format("{0} has lost 1 live", Player2)) + System.Environment.NewLine;
            lifetotalB = lifetotalB - 1;
            textBox2.Text = lifetotalB.ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox5.Text += (string.Format("{0} has lost 5 lives", Player1)) + System.Environment.NewLine;
            lifetotalA = lifetotalA - 5;
            textBox3.Text = lifetotalA.ToString();  
                }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string p1 = "Player 1";
            string p2 = "Player 2";
            textBox1.Clear();
            textBox4.Clear();
            textBox1.Text = p2;
            textBox4.Text = p1 ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            lifetotalA = 20;
            textBox2.Text = lifetotalB.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Text += (string.Format("{0} has gained 1 live",Player2)) + System.Environment.NewLine;
            lifetotalB = lifetotalB + 1;
            textBox2.Text = lifetotalB.ToString();
        }

        private void button19_Click(object sender, EventArgs e) {
            MessageBox.Show("The game is reset");
            reset();
            winA = 0;
            winB = 0;
            textBox7.Text = winA.ToString();
            textBox8.Text = winB.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (lifetotalB <= 0)
            {
                string player1 = textBox4.Text;
                MessageBox.Show(string.Format("{0} has won the game",player1));
                reset();
                if(win_counter== true)
                {
                    winA = winA + 1;
                    textBox7.Text = winA.ToString();

                    if (winA == GNFTW)
                    {
                        MessageBox.Show(string.Format("{0} has won the Match",player1));
                        reset();
                        winA = 0;
                        winB = 0;
                        textBox7.Text = winA.ToString();
                        textBox8.Text = winB.ToString();
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Player1 = textBox4.Text;
            Player2 = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Player1 = textBox4.Text;
            Player2 = textBox1.Text;
        }

        private void darkCyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkCyan;
            textBox6.BackColor = Color.DarkCyan;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            textBox6.BackColor = Color.Cyan;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            textBox6.BackColor = Color.Blue;
        }

        private void darkBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
            textBox6.BackColor = Color.DarkBlue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            textBox6.BackColor = Color.Yellow;
        }

        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
            textBox6.BackColor = Color.Gold;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darkRedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
         

        }

        
         
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sec++;
            textBox6.Clear();
            textBox6.Text += sec.ToString();

            if (sec == 60)
            {
                min++;
                textBox6.Text = ":";
                textBox6.Text = min.ToString();

            }
            
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            min = min + 1;
            textBox6.Text += min.ToString();
            textBox6.Text = ":";

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          
            uur++;
        }

        private void disableWincounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            win_counter = false;
        }

       

        private void enableWinCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            win_counter = true;
        }

        private void resetWinCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            winB = 0;
            winA = 0;
            textBox7.Text = winA.ToString();
            textBox8.Text = winB.ToString();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GNFTW = 1;
            win_counter = true;
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GNFTW = 2;
            win_counter = true;
        }

        private void gamesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GNFTW = 3;
            win_counter = true;
        }

        private void gamesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GNFTW = 4;
            win_counter = true;
        }

        private void gamesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GNFTW = 5;
            win_counter = true;
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void startTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void resetTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sec = 0;
            textBox6.Text = sec.ToString();
        }
    }
}
