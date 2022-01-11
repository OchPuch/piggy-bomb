using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject deadScreen;
    public void Start()
    {
        deadScreen.SetActive(false);
    }
    public void EndGame()
    {
        deadScreen.SetActive(true);
    }
}
