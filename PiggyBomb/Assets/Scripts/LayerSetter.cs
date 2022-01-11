using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSetter : MonoBehaviour
{
    SpriteRenderer sr;
    public float gridSize = 1.215f;
    public float lowestPoint = -6f;
    public float offsetY = 0f;
    public int adittionalLayerCount = 1;
    
    private int startLayer;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        startLayer = sr.sortingOrder;
    }

   
    void Update()
    {
        sr.sortingOrder = -Mathf.RoundToInt((transform.position.y + offsetY - lowestPoint)/gridSize) * (adittionalLayerCount+1) + startLayer;
    }
}
