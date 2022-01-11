using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPoint : MonoBehaviour
{
    protected BorderCheck bc;
    public float gridSize = 1.215f;
    public Vector2 checkSize = new Vector2(1, 1);
    protected Collider2D[] facing = new Collider2D[1];
    protected LivingCreature lc;
    public GameObject body;
    public bool canInteract;
    protected bool hittedThisTurn = false;
    virtual public void Start()
    {
        Turn.TurnEvent += OnTurn;
        bc = GetComponent<BorderCheck>();
        lc = body.GetComponent<LivingCreature>();
    }

    virtual protected void OnTurn()
    {
        
    }

  
    virtual public void Move()
    {

    }
    virtual public void Move(Vector2 direction)
    {
        Vector3 move = direction * gridSize;
        if (!bc.IsThereBorder(move))
        {
            if (Physics2D.OverlapBoxNonAlloc(new Vector2(transform.position.x + move.x, transform.position.y + move.y), checkSize, 0f, facing) != 0)
            {
                if (facing[0].gameObject.CompareTag("Interactable") && canInteract)
                {
                    facing[0].gameObject.GetComponent<InteractableObject>().GetPunched(direction);

                }
            }
            else
            {
                transform.localPosition += move;
            }

        }
    }

   

    virtual public void GetHit()
    {
        
        body.GetComponent<LivingCreature>().GetHit();
    }
}
