using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Gambiarra : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent nm;
    public GameObject parent;
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.updateRotation = false;
        nm.updateUpAxis = false;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        nm.SetDestination(target.position);
        transform.position = parent.GetComponent<Transform>().position;
    }
}
