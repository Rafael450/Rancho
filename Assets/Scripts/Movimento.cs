using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float speed;
    public GameObject[] xicara;
    public Vector3 change;
    public Vector3 last;
    Rigidbody2D rb;
    public Animator animator;
    public bool isfourcup;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isfourcup = false;
        xicara[0].SetActive(false);
        xicara[1].SetActive(false);
        xicara[2].SetActive(false);
        xicara[3].SetActive(false);
    }
    float abs(float n)
    {
        if(n >= 0) return n;
        else return -n;
    }

    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");
        if(Input.GetAxisRaw("Horizontal")!=0 && Input.GetAxisRaw("Vertical")==0)
        {
            last.x = 2*Input.GetAxisRaw("Horizontal");
            last.y = 0;
        }
        if(Input.GetAxisRaw("Vertical")!=0 && Input.GetAxisRaw("Horizontal")==0)
        {
            last.y = 2*Input.GetAxisRaw("Vertical");
            last.x = 0;
        }
        rb.velocity = speed*change;
        
        if(change != Vector3.zero)
        {
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
        }
        else
        {
            animator.SetFloat("moveX", last.x);
            animator.SetFloat("moveY", last.y);
        }
        if((last.x == 2 && change.y == 0) && isfourcup)
        {
            xicara[0].SetActive(false);
            xicara[1].SetActive(false);
            xicara[2].SetActive(false);
            xicara[3].SetActive(true);
        }
        if((last.x == -2 && change.y == 0) && isfourcup)
        {
            xicara[0].SetActive(false);
            xicara[1].SetActive(false);
            xicara[2].SetActive(true);
            xicara[3].SetActive(false);
        }
        if(((last.y == 2 && change.x == 0) || (abs(last.x) == 2 && change.y == 1)) && isfourcup)
        {
            xicara[0].SetActive(true);
            xicara[1].SetActive(false);
            xicara[2].SetActive(false);
            xicara[3].SetActive(false);
        }
        if(((last.y == -2 && change.x == 0)|| (abs(last.x) == 2 && change.y == -1)) && isfourcup)
        {
            xicara[0].SetActive(false);
            xicara[1].SetActive(true);
            xicara[2].SetActive(false);
            xicara[3].SetActive(false);
        }
    }
}
