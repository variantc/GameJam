using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public enum GameState { NULL, GAMESTART, CHOOSEMOVESPLAYER, CHOOSEMOVESENEMY, EVALUATEMOVES}

    public GameState currentGameState = GameState.GAMESTART;
    public bool gameStateChanged = false;

    //public Card cardClass;

    private void Update()
    {
        gameStateChanged = false;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentGameState == GameState.GAMESTART || currentGameState == GameState.NULL)
            {
                currentGameState = GameState.CHOOSEMOVESPLAYER;
                gameStateChanged = true;
                return;
            }
            if (currentGameState == GameState.CHOOSEMOVESPLAYER)
            {
                currentGameState = GameState.CHOOSEMOVESENEMY;
                gameStateChanged = true;
                return;
            }
            if (currentGameState == GameState.CHOOSEMOVESENEMY)
            {
                currentGameState = GameState.EVALUATEMOVES;
                gameStateChanged = true;
                return;
            }
            if (currentGameState == GameState.EVALUATEMOVES)
            {
                currentGameState = GameState.GAMESTART;
                gameStateChanged = true;
                return;
            }
        }
    }
}
