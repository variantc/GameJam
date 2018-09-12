using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    public Card cardPrefab;
    public Card[] cardChoices;
    public int numChoices = 5;

    private void Start()
    {
        CardList.CardNames[] cardListFull = (CardList.CardNames[])System.Enum.GetValues(typeof(CardList.CardNames));

        cardChoices = new Card[numChoices];
        
        for (int i=0; i < cardChoices.Length; i++)
        {
            // Get a random move from the array of the enums of MoveNames
            CardList.CardNames randomCard = cardListFull[Random.Range(0, cardListFull.Length - 1)];

            string[] str = CardList.GetMoveStrings(randomCard);

            cardChoices[i] = Instantiate(cardPrefab,this.transform);
            cardChoices[i].AssignMoveStruct(str[0], str[1], str[2], str[3], str[4]);
        }
    }
}
