using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawnofEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy1, enemy2, enemy3, enemy4, enemy5, enemy6;
   static System.Random rnd = new System.Random();

   

   public GameObject randomSpqn()
    {
        int numberOfGO = rnd.Next(1, 7);
        if (numberOfGO == 1)
        {
            return enemy1;
        }
        else if (numberOfGO == 2)
        {
            return enemy2;
        }
        else if (numberOfGO == 3)
        {
            return enemy3;
        }
        else if (numberOfGO == 4)
        {
            return enemy4;
        }
        else if(numberOfGO == 5)
        {
            return enemy5;
        }
        else 
        {
            return enemy6;
        }
        
    }

    private void Start()
    {
        var clone = Instantiate(randomSpqn(), new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -6), Quaternion.identity) ;
    }
}
