using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPrincipal : MonoBehaviour
{
    public NavMeshAgent nm;
    Rigidbody2D rb;
    public GameObject AI;
    int mode;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mode = 0;
        AI.GetComponent<patrol>().enabled=true;
    }

    void Update()
    {
        rb.velocity = nm.velocity;
        if(mode == 0 && AI.GetComponent<patrol>().enabled==false)
        {
            AI.GetComponent<patrol>().enabled=true;
        }
    }
}
