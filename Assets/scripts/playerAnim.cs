using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerAnim : MonoBehaviour, IPointerDownHandler
{    
    Animator animator;
    Rigidbody2D rigidbodyOfPlayer;
    Vector2 playerSize;
    private void Start()
    {
        playerSize = gameObject.transform.localScale;
        rigidbodyOfPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (animator.GetBool("isClick") == false)
        {
            animator.SetBool("isClick", true);

        }
    }


    void endAnimBlock()
    {
        animator.SetBool("isClick", false);

    }

    private void Update()
    {
        if ((rigidbodyOfPlayer.velocity.x > 0 || rigidbodyOfPlayer.velocity.x < 0) || (rigidbodyOfPlayer.velocity.y > 0 || rigidbodyOfPlayer.velocity.y < 0))
        {
            animator.SetBool("isRun", true);
            if (rigidbodyOfPlayer.velocity.x ==  -0.6f )
            {
                gameObject.transform.localScale = new Vector2(-playerSize.x , playerSize.y);
            }
            if (rigidbodyOfPlayer.velocity.x == 0.6f || rigidbodyOfPlayer.velocity.y == 0.6f || rigidbodyOfPlayer.velocity.y == -0.6f )
            {
                gameObject.transform.localScale = playerSize;
            }
        }

       
       
        else
        {
            animator.SetBool("isRun", false);
        }
    }

 [SerializeField] internal void startAttack()
    {
        animator.SetBool("attack", true);
    }

    [SerializeField] void stopAttackAnim()
    {
        animator.SetBool("attack", false);

    }

   internal IEnumerator getHurt()
    {
        yield return new WaitForSeconds(0.3f);
        animator.SetBool("isHit", true);
        
    }
    void stopHurt()
    {
        animator.SetBool("isHit", false);

    }
}
