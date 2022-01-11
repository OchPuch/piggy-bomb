using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherConditionSpriteSetter : MonoBehaviour
{

    
    LastMoveRotationAnimation lmra;
    private int cond = 0;
    private Sprite[] defaultSprite = new Sprite[4];
    public Sprite[] angrySprite = new Sprite[4];
    public Sprite[] dirtySprite = new Sprite[4];
    void Start()
    {
        lmra = GetComponent<LastMoveRotationAnimation>();
        defaultSprite = lmra.sprite;
    }
    public void SetCondition(int condition)
    {
        cond = condition;
        // 0 - default 1 - angry 2 - dirty
        switch (condition)
        {
            case 0:
                lmra.sprite = defaultSprite;
                break;
            case 1:
                lmra.sprite = angrySprite;
                break;
            case 2:
                lmra.sprite = dirtySprite;
                break;

            default:
                break;
        } 


    }
    
    public int GetCondition()
    {
        return cond;
    }
}
