using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerPlayer : MonoBehaviour

{
    public static int powerOfPlayer = 100;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public static void checkPower(GameObject enemy)
    {
        if(powerOfPlayer > enemy.gameObject.GetComponent<powerEnemy>().powerEnemyInt)
        {
            Destroy(enemy.gameObject);
        }
    }
}
