using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CardGame;
public class CardDisplay : MonoBehaviour
{
    public Card cardData; // Reference to the Card ScriptableObject
    public Image cardImage; // UI Image to display the card sprite
    public TMP_Text cardName; // UI Text to display the card name    
    public TMP_Text healthText; // UI Text to display the card health
    public TMP_Text damageText; // UI Text to display the card damage range
    private Color[] typeColors = { Color.red, Color.blue, Color.green, Color.yellow };
    public Image[] typeImages;


    void Start()
    {
        UpdateCardDisplay();
        // Card newCard = ScriptableObject.CreateInstance<Card>();
        // newCard.cardName = "Fire Elemental";
        // newCard.cardType = new List<Card.CardType> { Card.CardType.Fire };
        // newCard.health = 5;
        // newCard.damageMin = 2;
        // newCard.damageMax = 4;
        // newCard.damageType = new List<Card.DamageType> { Card.DamageType.Magical };
        // Assign a sprite if needed
        // newCard.cardSprite = someSprite;

    }

    public void UpdateCardDisplay()
    {

        cardImage.color = typeColors[(int)cardData.cardType[0]];
        cardName.text = cardData.cardName;
        healthText.text = cardData.health.ToString();
        damageText.text = cardData.damageMin.ToString() + "-" + cardData.damageMax.ToString();
        for (int i = 0; i < typeImages.Length; i++){

        }

    }


}
