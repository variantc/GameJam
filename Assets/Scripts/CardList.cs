using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CardList {

    public enum CardNames { JabHigh, SwingHigh, PunchMid, KickMid, KickLow, BlockHigh,
                            BlockMid, CheckLow, WeaveHigh, DodgeMid, CounterHigh, CounterMid }

    public static string[] GetMoveStrings (CardNames moveName)
    {
        switch (moveName)
        {
            case CardNames.JabHigh:
                return JabHigh();
            case CardNames.SwingHigh:
                return SwingHigh();
            case CardNames.PunchMid:
                return PunchMid();
            case CardNames.KickMid:
                return KickMid();
            case CardNames.KickLow:
                return KickLow();
            case CardNames.BlockHigh:
                return BlockHigh();
            case CardNames.BlockMid:
                return BlockMid();
            case CardNames.CheckLow:
                return CheckLow();
            case CardNames.WeaveHigh:
                return WeaveHigh();
            case CardNames.DodgeMid:
                return DodgeMid();
            case CardNames.CounterHigh:
                return CounterHigh();
            case CardNames.CounterMid:
                return CounterMid();
            default:
                Debug.LogError("Invalid MoveName tag" + moveName);
                return new string[0];
        }
    }
    
    // ATTACKS:
    public static string[] JabHigh ()
    {
        string[] str = { "ATTACK", "FAST", "HIGH", "WEAK", "Jab" };
        return str;
    }
    public static string[] SwingHigh()
    {
        string[] str = { "ATTACK", "MEDIUM", "HIGH", "MODERATE", "High Swing" };
        return str;
    }
    public static string[] PunchMid()
    {
        string[] str = { "ATTACK", "FAST", "MID", "WEAK", "Body Punch" };
        return str;
    }
    public static string[] KickMid()
    {
        string[] str = { "ATTACK", "SLOW", "MID", "STRONG", "Body Kick" };
        return str;
    }
    public static string[] KickLow()
    {
        string[] str = { "ATTACK", "MEDIUM", "LOW", "MODERATE", "Leg Kick" };
        return str;
    }

    // DEFENDS:
    public static string[] BlockHigh()
    {
        string[] str = { "DEFEND", "MEDIUM", "HIGH", "MODERATE", "High Block" };
        return str;
    }
    public static string[] BlockMid()
    {
        string[] str = { "DEFEND", "MEDIUM", "MID", "MODERATE", "Low Block" };
        return str;
    }
    public static string[] CheckLow()
    {
        string[] str = { "DEFEND", "FAST", "LOW", "MODERATE", "Leg Check" };
        return str;
    }
    public static string[] WeaveHigh()
    {
        string[] str = { "DEFEND", "FAST", "HIGH", "STRONG", "Head Weave" };
        return str;
    }
    public static string[] DodgeMid()
    {
        string[] str = { "DEFEND", "MEDIUM", "MID", "STRONG", "Dodge" };
        return str;
    }
    public static string[] CounterHigh()
    {
        string[] str = { "DEFEND", "MEDIUM", "HIGH", "WEAK", "High Counter" };
        return str;
    }
    public static string[] CounterMid()
    {
        string[] str = { "DEFEND", "MEDIUM", "MID", "WEAK", "Mid Counter" };
        return str;
    }
}
