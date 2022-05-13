using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bringerStartPos : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.53f, gameObject.transform.position.y + 0.4f, -6.2f);
    }
}
