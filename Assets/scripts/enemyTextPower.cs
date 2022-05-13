using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[SelectionBase]
public class enemyTextPower : MonoBehaviour
{
  
    bool wasDoneFunc = false;
    int randonNums;
    float power;
    Vector2 scaleOfText;
    TextMeshPro textmesh;
   static System.Random rnd = new System.Random();

    private void Start()
    {


        power = transform.parent.GetChild(1).GetComponent<powerEnemy>().powerEnemyInt;

        textmesh = GetComponent<TextMeshPro>();
        scaleOfText = gameObject.transform.localScale;
         textmesh = GetComponent<TextMeshPro>();
        randonNums = rnd.Next(1, 8);

    }
  
    
void choosePositionText()
    { 
        if (gameObject.transform.parent.tag == "knight")
        {
            gameObject.transform.localPosition = new Vector2(0.1f, 0.35f);

        }
        if (gameObject.transform.parent.tag == "heavyBandit")
        {
            gameObject.transform.localPosition = new Vector2(-0.13f, 1.6f);

      
        }
        if (gameObject.transform.parent.tag == "bringer")
        {
            gameObject.transform.localPosition = new Vector2(0.272f, 0.25f);

        }
        if (gameObject.transform.parent.GetChild(1).tag == "darkKnight")
        {
            gameObject.transform.localPosition = new Vector2(-0.02f, -0.01f);

        }
    }
    private void LateUpdate()
    {
        gameObject.transform.localScale = scaleOfText;
        if (wasDoneFunc == false)
        {
            changeText();
            wasDoneFunc = true;
        }
    }

    void changeText()
    {
        int numOfChange = rnd.Next(1, 6);
        if(numOfChange == 1)
        {
            toSimple();
        }
        if(numOfChange == 2)
        {
            toMinus();
        }
       if(numOfChange == 3)
        {
            sqrtText();
        }
       if(numOfChange == 4)
        {
            toPlus();
        }
       
    }


    void toSimple()
    {
        power = transform.parent.GetChild(1).GetComponent<powerEnemy>().powerEnemyInt;

        textmesh.text = power.ToString();

        if (power % 2 == 0)
        {
            textmesh.text = $"{power / 2} * 2";
        }
        else if (power % 3 == 0)
        {
            textmesh.text = $"{power / 3} * 3";
        }
        else if (power % 5 == 0)
        {
            textmesh.text = $"{power / 5} * 5";

        }
    }

   

    void sqrtText()
    {

        power = transform.parent.GetChild(1).GetComponent<powerEnemy>().powerEnemyInt;

        if (power < 20)
        {
            textmesh.text = $"√{power * power}";

        }
        else
        {
            textmesh.text = power.ToString();
        }


    }

    void toPlus()
    {
        power = transform.parent.GetChild(1).GetComponent<powerEnemy>().powerEnemyInt;

        textmesh.text = power.ToString();

        
        if (power > 10)
        {
            textmesh.text = $"{power - randonNums} + {randonNums}";
        }
    }
  
    void toMinus()
    {
        power = transform.parent.GetChild(1).GetComponent<powerEnemy>().powerEnemyInt;

        textmesh.text = power.ToString();


            textmesh.text = $"{power + randonNums} - {randonNums}";
        


    }

}
