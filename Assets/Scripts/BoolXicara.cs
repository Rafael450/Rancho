using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolXicara : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            
            player.GetComponent<Movimento>().isfourcup = true;
        }
    }
}
