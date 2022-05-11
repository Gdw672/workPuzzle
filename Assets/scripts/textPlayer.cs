using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textPlayer : MonoBehaviour
{
    TextMeshPro text;
    void Start()
    {
        takePower();

    }

    void Update()
    {
    }

   internal void takePower()
    {
        text = GetComponent<TextMeshPro>();
        text.text = powerPlayer.powerOfPlayer.ToString();
    }
}
