using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerGoToEnemy : MonoBehaviour, IPointerDownHandler
{
    float laserLeng = 50f;
    public GameObject cube;
   [SerializeField] private Camera camera;


    public void OnPointerDown(PointerEventData eventData)

    {

       
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
                Vector2 touchPos = camera.ScreenToWorldPoint(new Vector2(touch.position.x , touch.position.y));

                Instantiate(cube, touchPos , Quaternion.identity);
              
                    RaycastHit2D hit = Physics2D.Raycast(touchPos, Vector2.zero);


                if (hit.collider != null)
                {
                    if(hit.collider.gameObject.tag == "enemy")
                    {
                        hit.collider.gameObject.transform.position = new Vector2(hit.collider.gameObject.transform.position.x + 0.1f, hit.collider.gameObject.transform.position.y);
                        print("enemy");
                    }
                }
                   
                    
                
                
            }


        }
        
          
        
    }

}
