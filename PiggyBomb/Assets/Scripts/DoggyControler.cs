using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggyControler : LivingCreature
{
    AnotherConditionSpriteSetter acss;
    public override void Start()
    {
        base.Start();
        acss = Sprite.GetComponent<AnotherConditionSpriteSetter>();
    }
    override public void LastMove(Vector2 direction)
    {
        lmra.OnMove(direction);
    }

    public override void OnTurn()
    {
        if (acss.GetCondition()!=0)
        {
            acss.SetCondition(acss.GetCondition()-1);

        }
        else
        {
            base.OnTurn();
        }
        
    }

    override public void GetHit()
    {
        Sprite.GetComponent<AnotherConditionSpriteSetter>().SetCondition(2);
    }

}
