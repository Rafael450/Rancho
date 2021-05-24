using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Player : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = GameObject.FindWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Player.GetComponent<Transform>().position-(new Vector3(0,0,10));
    }
}
