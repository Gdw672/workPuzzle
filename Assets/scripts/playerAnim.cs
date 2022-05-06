using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerAnim : MonoBehaviour, IPointerDownHandler
{
    Animator animator;
    Rigidbody2D rigidbodyOfPlayer;

    private void Start()
    {
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
        if (rigidbodyOfPlayer.velocity.x > 0 || (rigidbodyOfPlayer.velocity.y > 0 || rigidbodyOfPlayer.velocity.y < 0))
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }
    }
}
