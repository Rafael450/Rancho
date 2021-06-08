using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolXicara : MonoBehaviour
{
    public GameObject player;
    public GameObject EE;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        EE = GameObject.Find("EEEE");
        EE.SetActive(false);

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player" && Input.GetKey(KeyCode.E))
            player.GetComponent<Movimento>().isfourcup = true;
        if(other.tag == "Player" && player.GetComponent<Movimento>().isfourcup == false) 
            EE.SetActive(true);
        else
            EE.SetActive(false);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        EE.SetActive(false);
    }

}
