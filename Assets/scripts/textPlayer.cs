using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textPlayer : MonoBehaviour
{
    TextMesh text;
    void Start()
    {
        takePower();

    }

    void Update()
    {
    }

   internal void takePower()
    {
        text = GetComponent<TextMesh>();
        text.text = powerPlayer.powerOfPlayer.ToString();
    }
}
