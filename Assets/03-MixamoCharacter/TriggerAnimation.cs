using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
        var jump = Input.GetAxis("Jump");

        if ((vertical != 0  || horizontal != 0) && !animator.GetBool("Walk"))
        {
            animator.SetBool("Walk", true);
            return;
        }
        else
        {
            animator.SetBool("Walk", false);
        }

        if (jump != 0)
        {
            animator.SetBool("Kick", true);
            return;
        }
        else
        {
            animator.SetBool("Kick", false);
        }
    }
}
