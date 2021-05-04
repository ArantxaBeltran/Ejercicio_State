using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameState_ currentGameSate = GameState_.Menu;
    static GameManager gm;
    public Transform positionin;
    public Transform cube;
    public MovementPlayer MovementPlayer;


    private void Awake()
    {
       
        gm = this;
    }
    public static GameManager GetIns()
    {
        return gm;
    }

    public enum GameState_
    {
        Menu,
        InGame,
        GameOver,
    }
    void ChangeGameState(GameState_ newGameSate_)
    {
        switch (newGameSate_)
        {
            case GameState_.Menu:

                break;



            case GameState_.InGame:

                

                break;


            case GameState_.GameOver:

               
                
                break;

            default:

                currentGameSate = GameState_.Menu;
                break;

        }

        
    }
    public void StartGame_()
    {
        
        ChangeGameState(GameState_.InGame);
        MovementPlayer.Movimiento();
        


    }
    public void GameOver()
    {
        ChangeGameState(GameState_.GameOver);

        cube.position = positionin.position;
        
    }


    public void Backintomenu()
    {
        ChangeGameState(GameState_.Menu);
    }


    private void Update()
    {
       if(currentGameSate != GameState_.InGame && Input.GetKey(KeyCode.B))
        {
            ChangeGameState(GameState_.InGame);
            StartGame_();
            
        }
       


    }
    


}
