using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textPlayer : MonoBehaviour
{
    TextMesh text;
    void Start()
    {
        text = GetComponent<TextMesh>();
        text.text = powerPlayer.powerOfPlayer.ToString();

    }

    // Update is called once per frame
    void Update()
    {
    }
}
