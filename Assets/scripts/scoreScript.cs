using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{
    TextMeshProUGUI text;
   
    private void Update()
    {
        text = GetComponent<TextMeshProUGUI>();
        saves save = new saves();
        text.text = save.loadScore().ToString();
    }
}
