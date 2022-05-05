using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerGoToEnemy : MonoBehaviour
{
    bool isNeedMove = false;
    bool isGoY = false;
    float laserLeng = 50f;
    GameObject enemy;
    Rigidbody2D rigidbodyComp;

    private void Start()
    {
        rigidbodyComp = GetComponent<Rigidbody2D>();
    }




    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = new Touch();

            touch = Input.GetTouch(0);

            
            if(touch.phase == TouchPhase.Began)
            {
                touch.radius = 0.02f;
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(new Vector2(touch.position.x , touch.position.y));
              
                    RaycastHit2D hit = Physics2D.Raycast(touchPos, Vector2.zero);


                if (hit.collider != null)
                {
                    if(hit.collider.gameObject.tag == "enemy" || hit.collider.gameObject.tag == "heavyBandit" || hit.collider.gameObject.tag == "knight")
                    {
                        enemy = hit.collider.gameObject;

                        if(hit.collider.gameObject.transform.position.x != gameObject.transform.position.x || hit.collider.gameObject.transform.position.y!= gameObject.transform.position.y)
                        {
                            isNeedMove = true;

                        }
                    
                    }
                }
                   
                    
                
                
            }


        }

       if(isNeedMove)
        {
            goingToEnemy();

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


       

    }


    void goingToEnemy()
    {

        if (gameObject.transform.position.y < enemy.gameObject.transform.position.y)
        {


            goUp();


        }

        if (gameObject.transform.position.y > enemy.gameObject.transform.position.y)
            {

                goDown();
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
            }
        }
        if (enemy.tag == "enemy")
        {
            if (gameObject.transform.position.y + 0.25f > enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
            }
        }
        if (enemy.tag == "knight")
        {
            if (gameObject.transform.position.y + 0.15f > enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
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
            }
        }
        if (enemy.tag == "enemy")
        {
            if (gameObject.transform.position.y - 0.25f < enemy.gameObject.transform.position.y)
            {
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
            }
        }
        if (enemy.tag == "knight")
        {
            if (gameObject.transform.position.y -0.02f  < enemy.gameObject.transform.position.y)
            {
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.15f);
                isNeedMove = false;
                rigidbodyComp.velocity = Vector2.zero;
            }
        }
    }

   
}
