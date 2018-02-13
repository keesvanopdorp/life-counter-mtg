using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int lifetotalA = 20;
        int lifetotalB = 20;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = lifetotalA.ToString();
            textBox2.Text = lifetotalB.ToString();
            Player1 = textBox4.Text;
            Player2 = textBox1.Text;

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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (lifetotalB <= 0)
            {
                string player1 = textBox4.Text;
                MessageBox.Show(string.Format("{0} has won the game",player1));
                reset();
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
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        
    }
}
