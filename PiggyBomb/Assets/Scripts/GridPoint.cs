using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPoint : MonoBehaviour
{
    public float gridSize = 1.215f;
    private Transform grid;
    private int gridX;
    private int gridY;
    // Start is called before the first frame update
    void Start()
    {
        grid = GameObject.FindGameObjectWithTag("Grid").transform;
        transform.SetParent(grid);
        Vector3 startPos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        gridX = Mathf.RoundToInt(startPos.x / gridSize);
        gridY = Mathf.RoundToInt(startPos.y / gridSize);
        startPos = new Vector3(gridX * gridSize,gridY * gridSize, transform.localPosition.z);
        transform.localPosition = startPos;
        transform.localScale = new Vector3(1, 1, 0);
        transform.localRotation = Quaternion.identity;
    }

}
