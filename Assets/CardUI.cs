using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour {

    Card[] drawnCards;

	// Use this for initialization
	void Start () {

        drawnCards = this.GetComponentsInChildren<Card>();
        Debug.Log(drawnCards.Length);

        foreach (Card c in drawnCards)
        {
            Text[] cardText = c.GetComponentsInChildren<Text>();

            //Debug.Log(c.cardName.ToString());

            cardText[0].text = c.cardName.ToString();
            cardText[1].text = c.cardType.ToString();
            cardText[2].text = c.cardSpeed.ToString();
            cardText[3].text = c.cardHeight.ToString();
            cardText[4].text = c.cardStrength.ToString();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
