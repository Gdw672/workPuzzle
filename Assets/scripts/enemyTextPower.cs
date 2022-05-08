using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTextPower : MonoBehaviour
{
    Vector2 scaleOfText;
    TextMesh textmesh;
    int power;
    string powerToString;
    System.Random rnd = new System.Random();

    private void Start()
    {
        scaleOfText = gameObject.transform.localScale;
        power = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt;
        textmesh = GetComponent<TextMesh>();
         textmesh.text = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt.ToString();
        choosePositionText();
    }
    private void Update()
    {
        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x, gameObject.transform.localScale.y);
        textmesh.text = transform.parent.gameObject.GetComponent<powerEnemy>().powerEnemyInt.ToString();
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
    }
    private void LateUpdate()
    {
        gameObject.transform.localScale = scaleOfText;
    }



}
