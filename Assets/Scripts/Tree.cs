using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private float speed = 3f; 
    [SerializeField] private float distance = 11f;
    private float initialPosition; 

    void Start()
    { 
        initialPosition = transform.position.y;
        
    }

    void Update()
    {
        float distanceMoved = Mathf.Abs(transform.position.y - initialPosition);
        if (distanceMoved < distance)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
