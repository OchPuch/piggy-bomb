using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class InteractableObject : MonoBehaviour
{
    public float gridSize = 1.215f;
    protected BorderCheck bc;
    public virtual void Start()
    {
        bc = GetComponent<BorderCheck>();
    }
    virtual public void GetPunched(Vector2 direction)
    {
        
        Vector3 move = direction * gridSize;
        if (!bc.IsThereBorder(move))
        {
            transform.localPosition += move;
        }
    }
    

}
