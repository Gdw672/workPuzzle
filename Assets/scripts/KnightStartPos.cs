using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightStartPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.05f , gameObject.transform.position.y + 1.4f, -6.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
