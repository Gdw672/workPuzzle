using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class classLvlAndScore : MonoBehaviour
{
    public GameObject controller;
    powerEnemyConrollerScript powerEnemyConrollerScript;
    public static int sumOfDestroyEnemy;
 public static int lvl;
   public static int score;
    public static bool isWasLvlDone;


    private void Awake()
    {

        saves save = new saves();

        lvl = save.loadLvl();
        score = save.loadScore();
        if(lvl == 0)
        {
            lvl = 1;
        }
        
        powerEnemyConrollerScript = controller.GetComponent<powerEnemyConrollerScript>();
        sumOfDestroyEnemy = 0;
    }

    private void Update()
    {

     if (sumOfDestroyEnemy == powerEnemyConrollerScript.powerEnemyMass.Length)
        {
            isWasLvlDone = true;
        }
     else
        {
            isWasLvlDone = false;
        }
    }

}
