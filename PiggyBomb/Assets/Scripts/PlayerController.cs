using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : LivingCreature
{

    public GameObject deadScreen;

    public override void Start()
    {
        base.Start();
        deadScreen.SetActive(false);
        SwipeDetection.SwipeEvent += OnSwipe;
    }


    protected void OnSwipe(Vector2 direction)
    {
        if (Vector3.Distance(transform.position, trueDestination) <= 0.05f )
        {
            DP.Move(direction);
        }
        lmra.OnMove(direction);

    }

    override public void Update()
    {
        base.Update();
        
        if (health <= 0)
        {
            
        }
    }

    override public void OnTurn()
    {

    }

    public override void Death()
    {
        Turn.TurnEvent -= OnTurn;
        SwipeDetection.SwipeEvent -= OnSwipe;
        base.Death();
        deadScreen.SetActive(true);

    }


}
