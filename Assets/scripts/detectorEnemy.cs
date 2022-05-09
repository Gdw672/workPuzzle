using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorEnemy : MonoBehaviour
{
    powerPlayer power;
    playerGoToEnemy playerGo;
    Rigidbody2D playerRigidbody;
    void Start()
    {
        power = gameObject.transform.parent.GetComponent<powerPlayer>();
        playerRigidbody =gameObject.transform.parent.GetComponent<Rigidbody2D>();
        playerGo = gameObject.transform.parent.GetComponent<playerGoToEnemy>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if((collision.tag == "heavyBandit" || collision.tag == "knight") && collision.gameObject == playerGo.enemy)
            {
            print("detect");
            StartCoroutine(stop());
            power.checkPower(collision.gameObject);
            
            }
    }
    IEnumerator stop()
    {
        yield return new WaitForSeconds(0.1f);
        playerRigidbody.velocity = Vector2.zero;

    }
   
}
