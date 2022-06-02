using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used to check the player arrive the end
public class Finish : MonoBehaviour
{
    //Called when a GameObject with Rigidbody&Collider enter Trigger
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //check the gameObject is Player
        if (collision.CompareTag("Player"))
        {
            //Call GameManager and let the game end
            GameManager.Instance.GameOver();
        }
    }
}
