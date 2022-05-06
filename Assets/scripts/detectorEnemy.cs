using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorEnemy : MonoBehaviour
{
    playerGoToEnemy playerGo;
    void Start()
    {
        playerGo = gameObject.transform.parent.GetComponent<playerGoToEnemy>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if(collision.tag == "heavyBandit" || collision.tag == "knight")
            {
            print("detect");
               playerGo.isCollisionWithEnemy = true;
            powerPlayer.checkPower(collision.gameObject);
            }
    }

   
}
