using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Gambiarra : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent nm;
    public GameObject parent, alerta;
    float delay = 0;
    float angle;
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        nm.updateRotation = false;
        nm.updateUpAxis = false;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (delay == 0) 
        {
            GameObject x = Instantiate(alerta,transform.position+new Vector3(0, 2.5f, 0), Quaternion.identity).gameObject;
            Destroy(x,3f);
        }
        if (delay <= 3f)
        {
            delay += Time.deltaTime;
            return;
        }
        nm.SetDestination(target.position);
        transform.position = parent.GetComponent<Transform>().position - new Vector3(0, 0.7f, 0);
    }
    
}
