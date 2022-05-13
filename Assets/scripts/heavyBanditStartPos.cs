using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heavyBanditStartPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.45f, gameObject.transform.position.y - 0.8f, -6.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
