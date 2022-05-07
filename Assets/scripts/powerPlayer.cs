using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerPlayer : MonoBehaviour

{
    enemyAnim enemyAnimComp;
    playerGoToEnemy playerGo;
    playerAnim anim;
    public static int powerOfPlayer = 20;

    void Start()
    {
        playerGo = GetComponent<playerGoToEnemy>();
        anim = GetComponent<playerAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void checkPower(GameObject enemy)
    {
        enemyAnimComp = enemy.GetComponent<enemyAnim>();

        if (powerOfPlayer > enemy.gameObject.GetComponent<powerEnemy>().powerEnemyInt)
        {

            if (enemy.tag == "knight")
            {
                
                StartCoroutine(enemyAnimComp.startDeath(0.45f));
            }
            if(enemy.tag == "heavyBandit")
            {
                StartCoroutine(enemyAnimComp.startDeath(0.42f));

            }

            playerGo.wasEnemyDestroy = true;
            anim.startAttack();
        }
 
        if(powerOfPlayer < enemy.gameObject.GetComponent<powerEnemy>().powerEnemyInt)
        {
             StartCoroutine(enemyAnimComp.startAttack());
            StartCoroutine(anim.getHurt());
        }

    }


}
