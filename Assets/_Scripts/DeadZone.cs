using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//if Player Enter this area will lost one hp
public class DeadZone : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //check the gameObject is Player
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.OnPlayerDead();
        }
    }
}
