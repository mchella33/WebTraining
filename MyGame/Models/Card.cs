using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGame.Models
{
    public class Card
    {
        public CardValue CardValue { get; set; }
        public CardSuit CardSuit { get; set; }
    }

    public enum CardSuit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum CardValue
    {
        Ace,
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
        King

    }
}