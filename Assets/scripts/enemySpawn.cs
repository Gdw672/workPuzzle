using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy, randomSpawn;
    private System.Random rnd = new System.Random();
    private randomSpawnofEnemy enemyRnd;
    


    private void Awake()
    {

        enemyRnd = randomSpawn.GetComponent<randomSpawnofEnemy>();


       // spawnEnemyes();
       


    }


    void spawnEnemyes()
    {
        GameObject firsEnemy = null;
        int sumRow = getSumOfRow(5, 11);
        for (int i = 1; i <= sumRow; i++)
        {

            if(i == 1)
            {
              firsEnemy = Instantiate(enemyRnd.randomSpqn());

              firsEnemy.transform.position = Vector2.zero;

              spawnGoRow(firsEnemy, 2 , 4);

            }

            if (sumRow > 1)
            {
                var othersEnemies = Instantiate(enemyRnd.randomSpqn());
                othersEnemies.transform.position = new Vector2(firsEnemy.transform.position.x + 1, firsEnemy.transform.position.y);
                firsEnemy = othersEnemies;
                spawnGoRow(othersEnemies,3,6);

            }
        }
    }

    void spawnGoRow(GameObject enemy , int minInt, int maxInt)
    {
        int sumEnemyOnRow = getSumOfRow(minInt, maxInt);
        for (int i = 1;  i < sumEnemyOnRow; i++)
        {
            var clone = Instantiate(enemyRnd.randomSpqn());
            clone.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y - 0.8f);
            enemy = clone;
        }


    }

    int getSumOfRow(int a , int b)
    {
        int randomNum = rnd.Next(a, b);


        return randomNum;
    }
}
