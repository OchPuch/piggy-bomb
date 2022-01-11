using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPointDoggy : DestinationPoint
{

    System.Random rand = new System.Random();
    
    override public void Move()
    {
        Vector2 direction = PickRandomDirection();
        Vector3 move = direction * gridSize;

        if (Physics2D.OverlapBoxNonAlloc(new Vector2(transform.position.x + move.x, transform.position.y + move.y), checkSize, 0f, facing) != 0)
        {
            if (facing[0].gameObject.CompareTag("Player"))
            {
                facing[0].gameObject.GetComponent<DestinationPointPlayer>().GetHit();
            }
        }
        else
        {
            transform.localPosition += move;
        }
        lc.LastMove(direction);

    }

   

    public Vector2 PickRandomDirection()
    {
        
        var canMove = new List<Vector2>();
        
        bool noMoves = true;
        if (!bc.IsThereBorder(Vector2.right))
        {
            canMove.Add(Vector2.right);
            noMoves = false;
        }
        if (!bc.IsThereBorder(Vector2.left))
        {
            canMove.Add(Vector2.left);
            noMoves = false;
        }
        if (!bc.IsThereBorder(Vector2.down))
        {
            canMove.Add(Vector2.down);
            noMoves = false;
        }
        if (!bc.IsThereBorder(Vector2.up))
        {
            canMove.Add(Vector2.up);
            noMoves = false;
        }

        
        
        if (noMoves)
        {
            return Vector2.zero;
        }

        
        int r = rand.Next(canMove.Count);
        return canMove[r];
    }
}
