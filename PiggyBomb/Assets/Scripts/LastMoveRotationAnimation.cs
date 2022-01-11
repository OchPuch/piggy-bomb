using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LastMoveRotationAnimation : MonoBehaviour
{
    SpriteRenderer sr;
    private int CurrentSprite;
    public Sprite[] sprite = new Sprite[4];
    // Start is called before the first frame update
    void Start()
    {
        
        sr = GetComponent<SpriteRenderer>();
        CurrentSprite = 0;
    }

    public void OnMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            if (direction.y == 0)
            {
                if (direction.x > 0)
                {
                    CurrentSprite = 0;
                }
                else
                {
                    CurrentSprite = 1;
                }

            }
            else
            {
                if (direction.y > 0)
                {
                    CurrentSprite = 3;
                }
                else
                {
                    CurrentSprite = 2;
                }
            }
        }
    }

    public void Update()
    {
        sr.sprite = sprite[CurrentSprite];
    }

}
