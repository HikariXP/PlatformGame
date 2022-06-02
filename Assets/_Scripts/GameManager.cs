using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The script build for game management
public class GameManager : MonoBehaviour
{
    //Declare a global static reference, and assign in Awake()
    public static GameManager Instance;
    //record the score
    public float score;
    //Player's HP,the value will be 3 at start
    public int HP = 3;
    //Get the reference of player
    public GameObject Player;
    //Store references to global coins
    public List<GameObject> Coins = new List<GameObject>();
    //The reference of the UI-GameOverPanel
    public GameObject GameOverPanel;
    //Display the Score
    public Text Score_Text;
    //Control the HP_icons Display
    public List<GameObject> HP_Icons = new List<GameObject>();

    //Assign the global static reference,then can be call with "GameManager.Instance" in everywhere
    private void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        RefreshHPDisplay();
    }

    //Called when the game is over
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        Score_Text.text = Convert.ToInt32(score).ToString();
    }
    //Called when Player Fall to the DeadZone
    public void OnPlayerDead()
    {
        HP -= 1;
        if (HP >= 0)
        {
            //Reset Player Position
            Player.transform.position = new Vector3(-3f, 1f, 0f);
        }
        else
        {
            GameOver();
        }
    }

    //Reset all the GameObject in scene
    public void ResetGame()
    {
        //Reset Socre
        score = 0f;

        //Reset Coin's Status;
        if (Coins.Count > 0)
        {
            foreach (GameObject gameObject in Coins)
            {
                gameObject.SetActive(true);
            }
        }

        //Reset Player Position
        Player.transform.position = new Vector3(-3f,1f,0f);

        HP = 3;
    }

    //Refresh the HP Display
    public void RefreshHPDisplay()
    {
        if (HP_Icons.Count <= 0) return;
        for (int i = 0; i < 3; i++)
        {
            if (HP > i)
            {
                HP_Icons[i].SetActive(true);
            }
            else
            {
                HP_Icons[i].SetActive(false);
            }
        }
    }
}
