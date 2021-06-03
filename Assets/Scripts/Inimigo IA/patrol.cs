using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour
{
    public float startTime;
    public float waitTime;
    NavMeshAgent nm;
    Rigidbody2D rb;
    public Transform[] patrolSpots;
    [SerializeField] Transform target;
    public GameObject parent, player;
    int randomS;
    Vector3 memory;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = parent.GetComponent<Rigidbody2D>();
        nm = GetComponent<NavMeshAgent>();
        nm.updateRotation = false;
        nm.updateUpAxis = false;
        randomS = Random.Range(0, patrolSpots.Length-1);
        waitTime = startTime;
        target=patrolSpots[randomS];
    }

    void Update()
    {
        nm.SetDestination(target.position);
        transform.position = parent.GetComponent<Transform>().position - new Vector3(0,0.7f,0);
        target=patrolSpots[randomS];
        
        if(Vector3.Distance(transform.position, patrolSpots[randomS].position) <= 0.5f)
        {
            if(waitTime <= 0)
            {
                waitTime = startTime;
                randomS = Random.Range(0, patrolSpots.Length-1);
            } 
            else 
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}

