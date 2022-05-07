using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAnim : MonoBehaviour

{
    BoxCollider2D enemyCollider;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        enemyCollider = GetComponent<BoxCollider2D>();
    }

   internal IEnumerator startDeath(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetBool("isHit", true);
    }

    internal IEnumerator startAttack()
    {
        yield return new WaitForSeconds(0.5f);
        print("start");
        animator.SetBool("attack", true);
    }
    internal void stopAttack()
    {
        animator.SetBool("attack", false);

    }

   [SerializeField] void deathOfCollider()
    {
        enemyCollider.enabled = false;
    }

}
