using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerPlayer : MonoBehaviour

{
    enemyAnim enemyAnimComp;
    playerGoToEnemy playerGo;
    playerAnim anim;
    textPlayer text;
    GameObject enemyTime;
   
    public static int powerOfPlayer = 9;

    void Start()
    {
        text = transform.GetChild(1).GetComponent<textPlayer>();
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

        if (powerOfPlayer >= enemy.gameObject.GetComponent<powerEnemy>().powerEnemyInt)
        {
            enemyTime = enemy;

            if (enemy.tag == "knight")
            {
                
              //  StartCoroutine(enemyAnimComp.startDeath(0.45f));
            }
            if(enemy.tag == "heavyBandit")
            {
            //    StartCoroutine(enemyAnimComp.startDeath(0.42f));

            }

            powerOfPlayer += enemy.GetComponent<powerEnemy>().powerEnemyInt;
            playerGo.wasEnemyDestroy = true;
            anim.startAttack();
        }
 
        if(powerOfPlayer < enemy.gameObject.GetComponent<powerEnemy>().powerEnemyInt)
        {
             StartCoroutine(enemyAnimComp.startAttack());
            StartCoroutine(anim.getHurt());
        }

    }

   [SerializeField] void enemyStartDeath()
    {
        enemyTime.GetComponent<Animator>().SetBool("isHit", true);
        text.takePower();
    }

}
