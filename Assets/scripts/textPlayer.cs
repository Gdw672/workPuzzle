using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textPlayer : MonoBehaviour
{
    GameObject player;
    TextMeshPro text;
    bool isWas = false;
    void Start()
    {
        player = transform.parent.GetChild(1).gameObject;
    }

    void Update()
    {
        gameObject.transform.position = new Vector2(player.transform.position.x + 0.55f, player.transform.position.y + 0.3f);
    }
    private void LateUpdate()
    {
        if(isWas == false)
        {
            takePower();
            isWas = true;

        }

    }

    internal void takePower()
    {
        text = GetComponent<TextMeshPro>();
        text.text = powerPlayer.powerOfPlayer.ToString();
    }
}
