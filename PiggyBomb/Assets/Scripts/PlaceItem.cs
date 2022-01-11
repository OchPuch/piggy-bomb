using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    public GameObject item;
    
    public void Place()
    {
        Instantiate(item, transform.position, Quaternion.identity);

    }
    
   
}
