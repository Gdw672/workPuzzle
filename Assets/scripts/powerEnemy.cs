using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerEnemy : MonoBehaviour
{
    public static int sumOfEnemy;
   [SerializeField] internal int powerEnemyInt;
    private void Awake()
    {
        sumOfEnemy += 1;
        
    }

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
