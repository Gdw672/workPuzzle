using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
