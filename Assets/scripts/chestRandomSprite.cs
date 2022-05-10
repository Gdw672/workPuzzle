using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestRandomSprite : MonoBehaviour
{
   static System.Random rnd = new System.Random();

    public Sprite sprite1, sprite2, sprite3, sprite4, sprite5, sprite6;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        int nubOfChest = rnd.Next(1 , 7);

        if(nubOfChest == 1)
        {
            spriteRenderer.sprite = sprite1;
        }
        if (nubOfChest == 2)
        {
            spriteRenderer.sprite = sprite2;
        }
        if (nubOfChest == 3)
        {
            spriteRenderer.sprite = sprite3;
        }
        if (nubOfChest == 4)
        {
            spriteRenderer.sprite = sprite4;
        }
        if (nubOfChest == 5)
        {
            spriteRenderer.sprite = sprite5;
        }
        if (nubOfChest == 6)
        {
            spriteRenderer.sprite = sprite6;
        }


    }

    void Update()
    {
        
    }
}
