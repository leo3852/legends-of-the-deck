using System.Collections.Generic;
using UnityEngine;

namespace CardGame
{
    [CreateAssetMenu(fileName = "NewCard", menuName = "Card Game/Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public List<CardType> cardType;
        public int health;
        public int damageMin;
        public int damageMax;
        public List<DamageType> damageType;
        public Sprite cardSprite;
        public enum CardType
        {
            Fire,
            Earth,
            Water,
            Air,
            Neutral
        }

        public enum DamageType
        {
            Physical,
            Magical,
            True
        }

    }
}


