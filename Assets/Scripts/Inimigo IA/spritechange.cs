using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechange : MonoBehaviour
{
    public float angle;
    Rigidbody2D rb;
    Animator animator;
    UnityEngine.AI.NavMeshAgent nm;
    public GameObject visor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        nm = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        angle = visor.GetComponent<Transform>().rotation.eulerAngles.z;
        if(angle >180) angle = -180+(angle%180);
        if (rb.velocity.magnitude > 0.1f)
        {
            if (angle < 45f && angle >= -45f)
            {
                animator.SetFloat("moveX", 1f);
                animator.SetFloat("moveY", 0f);
            }
            else if (angle < 135f && angle >= 45f)
            {
                animator.SetFloat("moveX", 0f);
                animator.SetFloat("moveY", 1f);
            }
            else if (angle < -45f && angle >= -135f)
            {
                animator.SetFloat("moveX", 0f);
                animator.SetFloat("moveY", -1f);
            }
            else if ((angle <= 180f && angle >= 135f) || (angle >= -180f && angle < -135f))
            {
                animator.SetFloat("moveX", -1f);
                animator.SetFloat("moveY", 0f);
            }
        }
        else
        {
            if (angle < 45f && angle >= -45f)
            {
                animator.SetFloat("moveX", 2f);
                animator.SetFloat("moveY", 0f);
            }
            else if (angle < 135f && angle >= 45f)
            {
                animator.SetFloat("moveX", 0f);
                animator.SetFloat("moveY", 2f);
            }
            else if (angle < -45f && angle >= -135f)
            {
                animator.SetFloat("moveX", 0f);
                animator.SetFloat("moveY", -2f);
            }
            else if ((angle <= 180f && angle >= 135f) || (angle >= -180f && angle < -135f))
            {
                animator.SetFloat("moveX", -2f);
                animator.SetFloat("moveY", 0f);
            }
        }
    }

}