using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerPlayer : MonoBehaviour

{
    private System.Random rnd = new System.Random();
    enemyAnim enemyAnimComp;
    playerGoToEnemy playerGo;
    playerAnim anim;
    textPlayer text;
    GameObject enemyTime;
    bool isWas = false;
   
    public static int powerOfPlayer;

    private void Awake()
    {

    }
    void Start()
    {
        text = transform.parent.GetChild(0).GetComponent<textPlayer>();
        playerGo = GetComponent<playerGoToEnemy>();
        anim = GetComponent<playerAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isWas == false)
        {
            powerOfPlayer = rnd.Next(5, 9 + classLvlAndScore.lvl);
            isWas = true;
        }
    }

  public void checkPower(GameObject enemy)
    {
        enemyAnimComp = enemy.GetComponent<enemyAnim>();

        if (powerOfPlayer >= enemy.gameObject.GetComponent<powerEnemy>().powerEnemyInt)
        {
            enemyTime = enemy;

        
            powerOfPlayer += enemy.GetComponent<powerEnemy>().powerEnemyInt;
            playerGo.wasEnemyDestroy = true;
            anim.startAttack();
            classLvlAndScore.score += enemy.GetComponent<powerEnemy>().powerEnemyInt;
            StartCoroutine(playMusic());
            
        }
 
        if(powerOfPlayer < enemy.gameObject.GetComponent<powerEnemy>().powerEnemyInt)
        {
             StartCoroutine(enemyAnimComp.startAttack());
            StartCoroutine(anim.getHurt());
        }

    }

    IEnumerator playMusic()
    {
        yield return new WaitForSeconds(0.3f);
        var play = Camera.main.GetComponent<audioPlay>();
        play.playAudio(play.hit);
    }
   [SerializeField] void enemyStartDeath()
    {
        enemyTime.GetComponent<Animator>().SetBool("isHit", true);
        text.takePower();
    }

}
