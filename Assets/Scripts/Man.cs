using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    [SerializeField] private Animator anime;
    [SerializeField] private float speed = 5f; 
    [SerializeField] private float distance = 10f;
    private float initialPosition; 
    // Start is called before the first frame update
    void Start()
    { 
        initialPosition = transform.position.z;
        
    }

    void Update()
    {
        anime.SetBool("near", false);
        float distanceMoved = transform.position.z - initialPosition;
        if (distanceMoved < distance)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }
}