using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerAnim : MonoBehaviour, IPointerDownHandler
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

  public void OnPointerDown(PointerEventData eventData)
    {
        if(animator.GetBool("isClick") == false)
        {
            animator.SetBool("isClick", true);

        }
    }


    void endAnimBlock()
    {
        animator.SetBool("isClick", false);

    }
    
}
