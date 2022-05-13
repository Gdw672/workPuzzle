using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletStartPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.55f, -6.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
