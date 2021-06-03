using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPrincipal : MonoBehaviour
{
    public NavMeshAgent nm;
    Rigidbody2D rb;
    public GameObject AI;
    public GameObject vison;
    public int mode;
    float angle;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mode = 0;
        AI.GetComponent<patrol>().enabled=true;
        
    }

    void Update()
    {
        rb.velocity = nm.velocity;
        angle = Vector3.SignedAngle(Vector3.right, rb.velocity, Vector3.forward);
        if(rb.velocity.magnitude>=0.5f) vison.GetComponent<Transform>().rotation = Quaternion.Euler(0,0,angle);
        if(mode == 0 && AI.GetComponent<patrol>().enabled==false)
        {
            AI.GetComponent<patrol>().enabled=true;
            AI.GetComponent<Gambiarra>().enabled=false;
        }
        if(mode == 1 && AI.GetComponent<Gambiarra>().enabled==false)
        {
            AI.GetComponent<NavMeshAgent>().SetDestination(transform.position);;
            rb.velocity = Vector3.zero;
            nm.velocity = Vector3.zero;
            AI.GetComponent<Gambiarra>().enabled=true;
            AI.GetComponent<patrol>().enabled=false;
        }

    }
}
