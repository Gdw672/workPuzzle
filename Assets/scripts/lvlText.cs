using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

[SerializeField]
public class lvlText : MonoBehaviour
{
    classLvlAndScore classLvlAndScore;

    TextMeshProUGUI lvlTextT;
    void Start()
    {
        lvlTextT = GetComponent<TextMeshProUGUI>();
        saves save = new saves();
        lvlTextT.text = $"LVL: {classLvlAndScore.lvl}";
    }

    // Update is called once per frame
    void Update()
    {

    }

  


    

}

