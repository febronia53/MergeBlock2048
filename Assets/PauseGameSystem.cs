using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameSystem : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetKeyDown("Jump"))
        {
            GameState currentGameState = GameStateManager.Instance.CurrentGameState;
            GameState newGameState = currentGameState == GameState.Gameplay
                ? GameState.Paused
                : GameState.Gameplay;

            GameStateManager.Instance.SetState(newGameState);
        }
    }
}

