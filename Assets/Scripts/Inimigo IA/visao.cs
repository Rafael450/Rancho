using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visao : MonoBehaviour
{
    public GameObject parent;
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && player.GetComponent<Movimento>().isfourcup == true) parent.GetComponent<IAPrincipal>().mode = 1;
    }
}
