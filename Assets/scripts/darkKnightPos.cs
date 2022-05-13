using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkKnightPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x -0.5f, gameObject.transform.position.y - 0.13f, -6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
