using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnPanel : MonoBehaviour {

    public Game game;
    public Text turnText;

    Game.GameState lastGameState;

    private void Start()
    {
        turnText.text = "Start!";
    }

    private void FixedUpdate()
    {
        if (lastGameState != game.currentGameState)
        {
            switch (game.currentGameState)
            {
                case Game.GameState.GAMESTART:
                    turnText.text = "Start!";
                    break;
                case Game.GameState.CHOOSEMOVESPLAYER:
                    turnText.text = "Player Turn!";
                    break;
                case Game.GameState.CHOOSEMOVESENEMY:
                    turnText.text = "Enemy Turn!";
                    break;
                case Game.GameState.EVALUATEMOVES:
                    turnText.text = "Evaluate Moves!";
                    break;
                default:
                    break;
            }
            
            lastGameState = game.currentGameState;
        }
    }
}
