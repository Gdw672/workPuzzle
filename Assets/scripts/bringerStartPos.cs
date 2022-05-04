using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bringerStartPos : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.25f, gameObject.transform.position.y);
    }
}
