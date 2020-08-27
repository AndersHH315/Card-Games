using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    public class Cards
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Type { get; set; }
        public string Images { get; set; }

        public Cards[] cards = new Cards[52];

        private static Random rnd;
        static Cards() { rnd = new Random(); }
        public Cards[] shuffleCards(Cards[] c)
        {
            Cards[] ShuffleMyArray = cards.OrderBy(x => rnd.Next()).ToArray();
            return c;
        }
        public string drawCard(int a)
        {
            a = rnd.Next(0, 51);
            for (int i = 0; i <= a; i++)
            {
                if (a == i)
                {
                    return cards[a].Images + " " + cards[a].Type + " " + cards[a].Value;
                }

            }

            return " ";
        }
        
        public void generateDeck()
        {
            string speccount = "";
            string image = "";
            int count = 0;
            int id = 0;
            int secondcount = 1;
            int start = 0;
            int set = 13;
            while(count <= 3)
            {
                for (int i = start; i < set; i++)
                {
                    cards[i] =  new Cards { Id = generateId(id) ,Value = secondcount, Type = generateType(speccount, count), Images = generateImages(image, secondcount) } ;
                    secondcount++;
                }
                start = set;
                set = set + 13;
                secondcount = 1;
                count++;
            }
        }

        public int generateId(int i)
        {
            return i + 1;
        }
        public string generateType(string a, int b)
        {
            if (b == 0)
            {
                return a = "Spades";
            }
            else if (b == 1)
            {
                return a = "Clubs";
            }
            else if (b == 2)
            {
                return a = "Hearts";
            }
            else if (b == 3)
            {
                return a = "Diamonds";
            }
            else
                return a;
        }

        public string generateImages(string a, int b)
        {
            if(b == 1)
            {
                return a = "Ace of";
            }
            else if(b == 2)
            {
                return a = "Two of";
            }
            else if(b == 3)
            {
                return a = "Three of";
            }
            else if (b == 4)
            {
                return a = "Four of";
            }
            else if (b == 5)
            {
                return a = "Five of";
            }
            else if (b == 6)
            {
                return a = "Six of";
            }
            else if (b == 7)
            {
                return a = "Seven of";
            }
            else if (b == 8)
            {
                return a = "Eight of";
            }
            else if (b == 9)
            {
                return a = "Nine of";
            }
            else if (b == 10)
            {
                return a = "Tenth of";
            }
            else if(b == 11)
            {
                return a = "Jack of";
            }
            else if(b == 12)
            {
                return a = "Queen of";
            }
            else if(b == 13)
            {
                return a = "King of";
            }
            return a;
        }

        public int generateNumber()
        {           
            int a = rnd.Next(0, 51);

            return a;
        }
    }
}
