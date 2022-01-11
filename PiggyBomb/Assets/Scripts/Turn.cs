using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public static event OnTurn TurnEvent;
    public delegate void OnTurn ();
    
    public void Start()
    {
        SwipeDetection.SwipeEvent += OnSwipe;
    }

    private void OnSwipe(Vector2 direction)
    {
        if (TurnEvent != null)
        {
            TurnEvent();
            
        }
        
    }

    public void SkipTurn()
    {
        if (TurnEvent != null)
        {
            TurnEvent();
            
        }

    }
    public void UnSub()
    {
        TurnEvent = null;
    }


}
