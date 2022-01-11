using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject movePoint;
    public float gridSize = 1.215f;
    protected Vector3 trueDestination;
    public float moveSpeed = 5f;

    public virtual void Start()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("Level").transform);
        transform.localRotation = Quaternion.identity;
    }
    public virtual void Update()
    {
        if (movePoint != null)
        {
            trueDestination = new Vector3(movePoint.transform.position.x, movePoint.transform.position.y, 0f);
            transform.position = Vector3.MoveTowards(transform.position, trueDestination, moveSpeed * Time.deltaTime);
        }
        
    }
}
