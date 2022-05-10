using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerGoToEnemy : MonoBehaviour
{
    bool isNeedMove = false;
    bool isGoYDone = false;
    bool isGoDownDon = false;
    short dubleClick;
    internal bool isCollisionWithEnemy, wasEnemyDestroy;
    Vector2 sizePlayer;

    float laserLeng = 50f;
    internal GameObject enemy;
    Rigidbody2D rigidbodyComp;

    private void Start()
    {
        sizePlayer = transform.localScale;
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
                        if (hit.collider.gameObject.tag == "enemy" || hit.collider.gameObject.tag == "heavyBandit" || hit.collider.gameObject.tag == "knight" || hit.collider.gameObject.tag == "bringer" || hit.collider.tag == "darkKnight")
                        {

                            enemy = hit.collider.gameObject;
                            dubleClick = 0;
                            dubleClick += 1;
                            isGoYDone = false;
                            isGoDownDon = false;


                        }
                    }


                    if ((hit.collider.gameObject.transform.position.x != gameObject.transform.position.x || hit.collider.gameObject.transform.position.y != gameObject.transform.position.y) && dubleClick == 2 && wasEnemyDestroy == false)
                    {
                        isNeedMove = true;
                    }

                    if ((hit.collider.gameObject.transform.position.x != gameObject.transform.position.x || hit.collider.gameObject.transform.position.y != gameObject.transform.position.y) && dubleClick == 2 && wasEnemyDestroy == true)
                    {
                        isNeedMove = true;
                    }

                }
            }


        }

        if (isNeedMove)
        {
            if (wasEnemyDestroy == false)
            {
                goingToEnemy();
                if (gameObject.transform.position.x > enemy.transform.position.x)
                {
                    gameObject.transform.localScale = new Vector2(-sizePlayer.x, sizePlayer.y);
                }
            }
            if (wasEnemyDestroy)
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

        if (enemy == null)
        {
            isNeedMove = false;
            rigidbodyComp.velocity = Vector2.zero;

        }

    }

    void goBackAfterDestroy()
    {

        rigidbodyComp.velocity = Vector2.zero;
        wasEnemyDestroy = false;
        isNeedMove = true;



    }



    void goingToEnemy()
    {
        if (enemy.tag != "bringer" && enemy.tag != "knight" && enemy.tag != "darkKnight")
        {
            if (gameObject.transform.position.y < enemy.gameObject.transform.position.y)
            {
                goUp();
            }

            if (gameObject.transform.position.y > enemy.gameObject.transform.position.y)
            {

                goDown();
            }


            if (isGoYDone && gameObject.transform.position.x < enemy.transform.position.x)
            {
                goRight();
            }
            if (isGoYDone && gameObject.transform.position.x > enemy.transform.position.x)
            {
                goLeft();
            }
        }

        if (enemy.tag == "bringer")
        {
            if (gameObject.transform.position.y + 0.3f < enemy.gameObject.transform.position.y)
            {
                goUp();
                print("goup");
            }

            if (gameObject.transform.position.y - 0.2f> enemy.gameObject.transform.position.y)
            {

                goDown();
            }


            if (isGoYDone && gameObject.transform.position.x < enemy.transform.position.x)
            {
                goRight();
            }
            if (isGoYDone && gameObject.transform.position.x > enemy.transform.position.x)
            {
                goLeft();
            }
        }
        if ( enemy.tag == "knight")
        {
            if (gameObject.transform.position.y + 0.1f < enemy.gameObject.transform.position.y)
            {
                goUp();
                print("goup");
            }

            if (gameObject.transform.position.y - 0.45f > enemy.gameObject.transform.position.y )
            {

                goDown();
            }


            if (isGoYDone && gameObject.transform.position.x < enemy.transform.position.x)
            {
                goRight();
            }
            if (isGoYDone && gameObject.transform.position.x > enemy.transform.position.x)
            {
                goLeft();
            }
        }


        if(enemy.tag == "darkKnight")
        {
            if (gameObject.transform.position.y - 0.1f< enemy.gameObject.transform.position.y)
            {
                goUp();
                print("goup");
            }

            if (gameObject.transform.position.y + 0.45f  > enemy.gameObject.transform.position.y)
            {

                goDown();
            }


            if (isGoYDone && gameObject.transform.position.x < enemy.transform.position.x)
            {
                goRight();
            }
            if (isGoYDone && gameObject.transform.position.x > enemy.transform.position.x)
            {
                goLeft();
            }
        }
    }


   
   
    void goUp()
    {
        print("goUp");
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
        if (enemy.tag == "bringer")
        {
            if (gameObject.transform.position.y + 0.4f > enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;

            }
            if (enemy.tag == "darkKnight")
            {
                if (gameObject.transform.position.y > enemy.gameObject.transform.position.y)
                {
                    isNeedMove = false;
                    rigidbodyComp.velocity = Vector2.zero;
                    isGoYDone = true;

                }
            }
         }
    }


    void goDown()
    {
        isGoDownDon = true;
        rigidbodyComp.velocity = new Vector2(0, -0.6f);
        if (enemy.tag == "heavyBandit")
        {
            if (gameObject.transform.position.y - 0.02f < enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;
                isGoDownDon = false;

            }
        }
        if (enemy.tag == "bringer")
        {
            if (gameObject.transform.position.y   < enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;
                isGoDownDon = true;


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
            if (gameObject.transform.position.y  < enemy.gameObject.transform.position.y)
            {
             //   gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.15f , -1f);
              //  print("F");
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
                isGoYDone = true;
                print("isYDone " + isGoYDone);

            }
        }
        if (enemy.tag == "darkKnight")
        {
            if (gameObject.transform.position.y + 0.4f < enemy.gameObject.transform.position.y)
            {
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

    void goLeft()
    {
        if (gameObject.transform.position.x > enemy.transform.position.x && isCollisionWithEnemy == false)
        {
            rigidbodyComp.velocity = new Vector2(-0.6f, 0);
        }
        else if (gameObject.transform.position.x > enemy.transform.position.x && isCollisionWithEnemy == true)
        {
            rigidbodyComp.velocity = Vector2.zero;
        }
    }

}
