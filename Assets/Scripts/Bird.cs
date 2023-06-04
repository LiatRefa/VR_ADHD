using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float speed = 5f; 
    [SerializeField] private float distance = 10f;
    private float initialPosition; 

    void Start()
    { 
        initialPosition = transform.position.z;
        
    }

    void Update()
    {
        float distanceMoved = transform.position.z - initialPosition;
        if (distanceMoved < distance)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
