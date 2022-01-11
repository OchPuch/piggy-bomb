using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : InteractableObject
{
    protected Vector3 keepMove;
    public int turnsToBlow= 3;
    public GameObject body;
    public Vector2 blowSize;
    private bool alreadyDestroyed = false;
    BoxCollider2D thisCollider;
    protected Collider2D[] blowed;
    public GameObject Particle;
    public override void Start()
    {
        base.Start();
        thisCollider = GetComponent<BoxCollider2D>();
        keepMove = Vector3.zero;
        Turn.TurnEvent += OnTurn;
        
    }

    private void OnTurn()
    {
        turnsToBlow--;
        if (!alreadyDestroyed)
        {
            KeepGoing();
        }
        
    }

    public void LateUpdate()
    {
        if (turnsToBlow == 0 && !alreadyDestroyed)
        {

            goNuke();
            Destroy(body);
            alreadyDestroyed = true;
            
        }

        if (turnsToBlow < 0)
        {
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);
        }
    }

    override public void GetPunched(Vector2 direction)
    {
        Vector3 move = direction * gridSize;
        if (!bc.IsThereBorder(move))
        {
            keepMove = move;
            KeepGoing();
        }
        
    }

    private void KeepGoing()
    {

        if (!bc.IsThereBorder(keepMove))
        {
            transform.localPosition += keepMove;
        }
        else
        {
            keepMove = Vector3.zero;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.CompareTag("Player")||other.CompareTag("Enemy")) && transform.CompareTag("Bomb"))
        {
            other.gameObject.GetComponent<DestinationPoint>().GetHit();
        }
    }

    public void goNuke()
    {
        transform.tag = "Bomb";
        thisCollider.size = blowSize;
        Instantiate(Particle, transform.position, Quaternion.identity);
    }

    

    

}
