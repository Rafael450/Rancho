using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour
{
    public float startTime;
    private float waitTime;
    NavMeshAgent nm;
    public Transform[] patrolSpots;
    public GameObject parent;
    int randomS;
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.updateRotation = false;
        nm.updateUpAxis = false;
        randomS = Random.Range(0, patrolSpots.Length-1);
        waitTime = startTime;
    }

    void Update()
    {
        transform.position = parent.GetComponent<Transform>().position - new Vector3(0,0.7f,0);
        nm.SetDestination(patrolSpots[randomS].position);
        if(Vector3.Distance(transform.position, patrolSpots[randomS].position) <= 0.1f)
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
