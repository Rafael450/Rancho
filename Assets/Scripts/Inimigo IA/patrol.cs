using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float speed, startTime;
    private float waitTime;
    Rigidbody2D rb;
    public Transform[] patrolSpots;
    int randomS;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        randomS = Random.Range(0, patrolSpots.Length);
        transform.position = patrolSpots[randomS].position;
        waitTime = startTime;
    }

    void Update()
    {
        rb.velocity = Vector3.MoveTowards(transform.position, patrolSpots[randomS].position, 1);
        if(Vector3.Distance(transform.position, patrolSpots[randomS].position) <= 0.1f)
        {
            if(waitTime <= 0)
            {
                waitTime = startTime;
                if(randomS == patrolSpots.Length - 1)
                    randomS = 0;
                else 
                    randomS++;
            } 
            else 
            {
                startTime -= Time.deltaTime;
            }
        }
    }
}
