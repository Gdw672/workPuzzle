using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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


        power = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt;
        textmesh = GetComponent<TextMeshPro>();
        scaleOfText = gameObject.transform.localScale;
         textmesh = GetComponent<TextMeshPro>();
        randonNums = rnd.Next(1, 8);
      
    }
    private void Update()
    {

        if (wasDoneFunc == false)
        {
            changeText();
            wasDoneFunc = true;
        }
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x, gameObject.transform.localScale.y);

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
    }
    private void LateUpdate()
    {
        gameObject.transform.localScale = scaleOfText;
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
            degree();
        }
       if(numOfChange == 3)
        {
            sqrtText();
        }
       if(numOfChange == 4)
        {
            toPlus();
        }
       if(numOfChange == 5)
        {
            toMinus();
        }
    }


    void toSimple()
    {
        power = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt;
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

    void degree()
    {
        power = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt;
        textmesh.text = power.ToString();
        double num = Mathf.Sqrt(power);
        string[] array = num.ToString().Split(',');
        if (array.Length == 1)
        {
            print(power);
            textmesh.text = $"{ Mathf.Sqrt(power)}² ";
        }
    }

    void sqrtText()
    {
        power = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt;
        if(power < 20)
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
        power = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt;

        textmesh.text = power.ToString();

        
        if (power > 10)
        {
            textmesh.text = $"{power - randonNums} + {randonNums}";
        }
    }
  
    void toMinus()
    {
        power = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt;

        textmesh.text = power.ToString();


            textmesh.text = $"{power + randonNums} - {randonNums}";
        


    }

}
