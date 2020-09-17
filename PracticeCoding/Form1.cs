using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeCoding
{
    public partial class Form1 : Form
    {
        Methods m = new Methods();
        Cards c = new Cards();
        BlackJack b = new BlackJack();
        public Form1()
        {
            InitializeComponent();
            c.generateDeck();
            c.shuffleCards(c.cards);
        }

        private void drawCardPlayer_Click(object sender, EventArgs e)
        {
            b.drawBlackJackPlayer(b.PlayersCards, c.cards);
            b.drawBlackJackDealer(b.DealerCards, c.cards);

            label2.Text = b.playerSumPoints(b.PlayersCards).ToString();
            label4.Text = b.dealerSumPoints(b.DealerCards).ToString();

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (Cards item in b.PlayersCards)
            {
                if (item != null)
                {
                    listBox1.Items.Add(item.Images + " " + item.Type + " " + item.Value);
                }

            }

            foreach (Cards item in b.DealerCards)
            {
                if (item != null)
                {
                    listBox2.Items.Add(item.Images + " " + item.Type + " " + item.Value);
                }
            }
        }

        private void rndCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.drawCard(c.Value) + " ");
        }

        private void blackJack_Click(object sender, EventArgs e)
        {
            b.blackJackDeck(c.cards);
            b.startBlackJack(b.PlayersCards, b.DealerCards, c.cards);

            label2.Text = b.playerSumPoints(b.PlayersCards).ToString();
            label4.Text = b.dealerSumPoints(b.DealerCards).ToString();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (Cards item in b.PlayersCards)
            {
                if (item != null)
                {
                    listBox1.Items.Add(item.Images + " " + item.Type + " " + item.Value);
                }
            }
            foreach (Cards item in b.DealerCards)
            {
                if (item != null)
                {
                    listBox2.Items.Add(item.Images + " " + item.Type + " " + item.Value);
                }
            }
        }

    }
}