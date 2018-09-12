using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName;
    public enum CardType { ATTACK, DEFEND }
    public enum CardSpeed { SLOW, MEDIUM, FAST }
    public enum CardHeight { LOW, MID, HIGH }
    public enum CardStrength { WEAK, MODERATE, STRONG }

    public CardType cardType;
    public CardSpeed cardSpeed;
    public CardHeight cardHeight;
    public CardStrength cardStrength;

    public void AssignMoveStruct (string type, string speed, string height, string strength, string name)
    {
        cardName = name;

        switch (type)
        {
            case "ATTACK":
                cardType = CardType.ATTACK;
                break;
            case "DEFEND":
                cardType = CardType.DEFEND;
                break;
            default:
                Debug.LogError("Unknown Move Type!");
                break;
        }
        switch (speed)
        {
            case "FAST":
                cardSpeed = CardSpeed.FAST;
                break;
            case "MEDIUM":
                cardSpeed = CardSpeed.MEDIUM;
                break;
            case "SLOW":
                cardSpeed = CardSpeed.SLOW;
                break;
            default:
                Debug.LogError("Unknown Move Speed!");
                break;
        }
        switch (height)
        {
            case "HIGH":
                cardHeight = CardHeight.HIGH;
                break;
            case "MID":
                cardHeight = CardHeight.MID;
                break;
            case "LOW":
                cardHeight = CardHeight.LOW;
                break;
            default:
                Debug.LogError("Unknown Move Height!");
                break;
        }
        switch (strength)
        {
            case "STRONG":
                cardStrength = CardStrength.STRONG;
                break;
            case "MODERATE":
                cardStrength = CardStrength.MODERATE;
                break;
            case "WEAK":
                cardStrength = CardStrength.WEAK;
                break;
            default:
                Debug.LogError("Unknown Move Strength!");
                break;
        }
    }
}
