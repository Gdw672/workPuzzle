using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerGoToEnemy : MonoBehaviour
{
    bool isNeedMove = false; 
    bool isGoYDone = false;
    short dubleClick;
   internal bool isCollisionWithEnemy, wasEnemyDestroy;
   
    float laserLeng = 50f;
    GameObject enemy;
    Rigidbody2D rigidbodyComp;

    private void Start()
    {
        dubleClick = 0;
        rigidbodyComp = GetComponent<Rigidbody2D>();
    }




    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = new Touch();

            touch = Input.GetTouch(0);


            if (touch.phase == TouchPhase.Began)
            {
                touch.radius = 0.02f;
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(new Vector2(touch.position.x, touch.position.y));

                RaycastHit2D hit = Physics2D.Raycast(touchPos, Vector2.zero);

                if (hit.collider != null)
                {







                    if (hit.collider.gameObject == enemy)
                    {
                        dubleClick += 1;
                    }

                    if (hit.collider.gameObject != enemy)
                    {
                        if (hit.collider.gameObject.tag == "enemy" || hit.collider.gameObject.tag == "heavyBandit" || hit.collider.gameObject.tag == "knight")
                        {

                            enemy = hit.collider.gameObject;
                            dubleClick = 0;
                            dubleClick += 1;
                            isGoYDone = false;


                        }
                    }


                    if ((hit.collider.gameObject.transform.position.x != gameObject.transform.position.x || hit.collider.gameObject.transform.position.y != gameObject.transform.position.y) && dubleClick == 2 && wasEnemyDestroy == false)
                    {
                        isNeedMove = true;
                    }

                    if ((hit.collider.gameObject.transform.position.x != gameObject.transform.position.x || hit.collider.gameObject.transform.position.y != gameObject.transform.position.y) && dubleClick == 2 && wasEnemyDestroy == true)
                    {
                        isNeedMove = true;
                        print("yes");
                    }

                }
            }
        
        
        }

       if(isNeedMove)
        {
            if(wasEnemyDestroy == false)
            {
                goingToEnemy();

            }
            if(wasEnemyDestroy)
            {
                goBackAfterDestroy();
            }

           /* if(enemy.tag == "heavyBandit")
            {
                if (gameObject.transform.position.y  > enemy.gameObject.transform.position.y)
                {
                    isNeedMove = false;
                    rigidbodyComp.velocity = Vector2.zero;
                }
           }
            if (enemy.tag == "enemy")
            {
                if (gameObject.transform.position.y + 0.25f > enemy.gameObject.transform.position.y)
                {
                    isNeedMove = false;
                    rigidbodyComp.velocity = Vector2.zero;
                }
            }*/

           

        }
        
    }

    private void FixedUpdate()
    {

        

       /* if (isCollisionWithEnemy)
        {
            isNeedMove = false;
            rigidbodyComp.velocity = Vector2.zero;

        }*/

        if( enemy == null)
        {
            isNeedMove = false;
            rigidbodyComp.velocity = Vector2.zero;

        }

    }

    void goBackAfterDestroy()
    {
        Vector2 nowPosition = gameObject.transform.position;
        rigidbodyComp.velocity = new Vector2(-0.6f, 0);
        if(gameObject.transform.position.x < enemy.transform.position.x - 0.6f)
        {
            rigidbodyComp.velocity = Vector2.zero;
            wasEnemyDestroy = false;
            isNeedMove = true;
        }
    

    }



    void goingToEnemy()
    {

        print("go");


        if (gameObject.transform.position.y < enemy.gameObject.transform.position.y )
        {
            goUp();
            print("goup");
        }

        if (gameObject.transform.position.y > enemy.gameObject.transform.position.y)
            {

                goDown();
            }


        if (isGoYDone && gameObject.transform.position.x < enemy.transform.position.x && isGoYDone == true)
        {
            goRight();
        }

       
       
    }


   
   
    void goUp()
    {
        rigidbodyComp.velocity = new Vector2(0, 0.6f);
        if (enemy.tag == "heavyBandit")
        {
            if (gameObject.transform.position.y + 0.02f > enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;
            }
        }
        if (enemy.tag == "enemy")
        {
            if (gameObject.transform.position.y + 0.25f > enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;

            }
        }
        if (enemy.tag == "knight")
        {
            if (gameObject.transform.position.y + 0.15f > enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;

            }
        }
    }


    void goDown()
    {
        rigidbodyComp.velocity = new Vector2(0, -0.6f);
        if (enemy.tag == "heavyBandit")
        {
            if (gameObject.transform.position.y - 0.02f < enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;

            }
        }
        if (enemy.tag == "enemy")
        {
            if (gameObject.transform.position.y - 0.25f < enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;

            }
        }
        if (enemy.tag == "knight")
        {
            if (gameObject.transform.position.y -0.02f  < enemy.gameObject.transform.position.y)
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.15f);
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;

            }
        }
    }
    void goRight()
    {
        if (gameObject.transform.position.x < enemy.transform.position.x && isCollisionWithEnemy == false)
        {
            rigidbodyComp.velocity = new Vector2(0.6f, 0);
        }
        else if (gameObject.transform.position.x < enemy.transform.position.x && isCollisionWithEnemy == true)
        {
            rigidbodyComp.velocity = Vector2.zero;
        }
    }

}
