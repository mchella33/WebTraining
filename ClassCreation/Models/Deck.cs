using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ClassCreation.Models
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            foreach (var suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (var value in Enum.GetValues(typeof(CardValue)))
                {
                    var card = new Card();
                    card.CardSuit = (CardSuit)suit;
                    card.CardValue = (CardValue)value;
                    Cards.Add(card);
                    
                }

            }

        }

    }
}



