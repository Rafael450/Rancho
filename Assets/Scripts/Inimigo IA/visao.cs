using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visao : MonoBehaviour
{
    public GameObject parent;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") parent.GetComponent<IAPrincipal>().mode = 1;
    }
}
