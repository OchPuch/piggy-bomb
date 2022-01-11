using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnsSurvived : MonoBehaviour
{
    Text text;
    public int turn = 0;
    public void Start()
    {
        text = GetComponent<Text>();
        text.text = "Turns survived: " + turn;
        Turn.TurnEvent += OnTurn;
    }

    private void OnTurn()
    {
        turn++;
        text.text = "Turns survived: " + turn;
    }
}
