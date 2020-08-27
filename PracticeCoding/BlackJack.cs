using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    public class BlackJack : Cards
    {
        public string PlayerName { get; set; }
        public int Points { get; set; }
        public int Sum { get; set; }
        public int Black = 21;
        public Cards[] DealerCards = new Cards[5];
        public Cards[] PlayersCards = new Cards[5];

        int playersSpotInArray = 0;
        int dealersSpotInArray = 0;
        int countdraws = 0;


        public Cards[] blackJackDeck(Cards[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if(c[i].Value > 10)
                {
                    c[i].Value = 10;
                }
            }
            return c;
        }
        public Cards[] startBlackJack(Cards[] player, Cards[] dealer, Cards[] deck)
        {
            
            while (countdraws <= 1)
            {

                player[playersSpotInArray] = deck[generateNumber()];
                dealer[dealersSpotInArray] = deck[generateNumber()];

                countdraws++;
                playersSpotInArray++;
                dealersSpotInArray++;
            }

            return player;
        }

        public int playerSumPoints(Cards[] c)
        {
            Points = 0;
            for (int i = 0; i < playersSpotInArray; i++)
            {
                Points += c[i].Value;
                if (PlayersCards[i].Value == 1 && Points <= 21)
                {
                    c[i].Value = 10;
                    Points--;
                    Points += c[i].Value;
                }

                if(Points > 21)
                {
                    checkForAcePlayer(PlayersCards);
                }
            }

            return Points;

        }

        int checkForAcePlayer(Cards[] c)
        {
            for (int i = 0; i < playersSpotInArray; i++)
            {
                if(PlayersCards[i].Images == "Ace of" && PlayersCards[i].Value == 10)
                {
                    c[i].Value = 1;
                    Points = Points - 9;
                }
                    
            }
            return Points;
        }

        public int dealerSumPoints(Cards[] c)
        {
            Points = 0;
            for (int i = 0; i < dealersSpotInArray; i++)
            {
                Points += c[i].Value;
                if (DealerCards[i].Value == 1 && Points <= 21)
                {
                    c[i].Value = 10;
                    Points--;
                    Points += c[i].Value;
                }
            }
            return Points;
        }

        int checkForAceDealer(Cards[] c)
        {
            for (int i = 0; i < dealersSpotInArray; i++)
            {
                if (DealerCards[i].Images == "Ace of" && DealerCards[i].Value == 10)
                {
                    c[i].Value = 1;
                    Points = Points - 9;
                }

            }
            return Points;
        }

        public Cards[] drawBlackJackPlayer(Cards[] player, Cards[] deck)
        {
            
            if (playersSpotInArray < 5)
            {
                player[playersSpotInArray] = deck[generateNumber()];
                playersSpotInArray++;
            }
            return player;
        }

        public Cards[] drawBlackJackDealer(Cards[] dealer, Cards[] deck)
        {
            if(dealersSpotInArray < 5)
            {
                dealer[dealersSpotInArray] = deck[generateNumber()];
                dealersSpotInArray++;
            }
            return dealer;
        }
       
    }
}
