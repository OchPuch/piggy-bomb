using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Restart()
    {
        GetComponent<SwipeDetection>().UnSub();
        GetComponent<Turn>().UnSub();
        SceneManager.LoadScene("SampleScene");
        
    }
}
