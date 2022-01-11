using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingCreature : Follower
{
    protected DestinationPoint DP;
    public GameObject Sprite;
    protected LastMoveRotationAnimation lmra;
    public int health = 1;

    override public void Start()
    {
        Turn.TurnEvent += OnTurn;
        base.Start();
        DP = movePoint.GetComponent<DestinationPoint>();
        lmra = Sprite.GetComponent<LastMoveRotationAnimation>();
    }

    override public void Update()
    {
        base.Update();
        if (health<=0)
        {
            Death();
        }
    }

    virtual public void OnTurn()
    {
        DP.Move();
    }

    virtual public void GetHit()
    {
        health--;
    }

    virtual public void Death()
    {
        Destroy(DP.transform.gameObject);
        Destroy(gameObject);
    }

    virtual public void LastMove(Vector2 direction)
    {

    }
}
