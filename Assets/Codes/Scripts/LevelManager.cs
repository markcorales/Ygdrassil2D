using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager main;
    public static bool GameIsOver;
    //public GameObject gameOverUI;
 
    //public GameObject completeLevelUI;
  
    
    public Transform startPoint;
    public Transform[] path;

   private void Awake () {
    main = this;
   } 

   private void Start() {
    GameIsOver = false; 
   }
   void Update()
    {
        if (GameIsOver)
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }
        
        if (PlayerStats.Lives <= 0 )
        {
            EndGame();
        }

    }
    
    public void IncreaseCurrency(int amount) {
        PlayerStats.Money += amount;
    }

    public bool SpendCurrency(int amount) {
        if (amount <= PlayerStats.Money) {
            PlayerStats.Money -= amount;
            return true;

        } else {
            Debug.Log ("Insufficient Balance");
            return false;
        }
    }


    public void EndGame()
    {
        GameIsOver = true;
        Debug.Log("You Lose");
        //gameOverUI.SetActive(true);
        return;
    }

    public void WinLevel () 
   {
       GameIsOver = true;
       Debug.Log("You Won");
        //completeLevelUI.SetActive(true);
        return;
    }
}
