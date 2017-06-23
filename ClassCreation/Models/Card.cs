using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassCreation.Models
{
    public class Card
    {
        public CardValue CardValue { get; set; }
        public CardSuit CardSuit { get; set; }


    }

    public enum CardValue
    {
       Two,
       Three,
       Four,
       Five,
       Six,
       Seven,
       Eight,
       Nine,
       Ten,
       Jack,
       Queen,
       King,
       Ace
     
    }

    public enum CardSuit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

}


