using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used to add score for Coin after being picked up
public class Coin : MonoBehaviour
{
    //score will add
    public float score = 10f;

    //Called when a GameObject with Rigidbody&Collider enter Trigger
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //check the gameObject is Player
        if (collision.CompareTag("Player"))
        {
            //add score
            GameManager.Instance.score += score;
            //disable this gameObject(Coin)
            gameObject.SetActive(false);
        }
    }
}
