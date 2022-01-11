using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour
{
    public LayerMask stopMove;
    
    public Vector2 checkSize;

    public bool IsThereBorder(Vector3 move)
    {
        if (Physics2D.OverlapBox(new Vector2(transform.position.x + move.x, transform.position.y + move.y), checkSize, 0f, stopMove))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
