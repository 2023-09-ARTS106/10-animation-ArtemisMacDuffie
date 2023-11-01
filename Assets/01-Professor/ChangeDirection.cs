using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        if (vertical == 0 && horizontal == 0)
        {
            animator.SetInteger("Direction", 4);
        }
        else if (vertical > 0)
        {
            animator.SetInteger("Direction", 2);
            animator.SetFloat("IdleFace", 0.5f);
        }
        else if (vertical < 0)
        {
            animator.SetInteger("Direction", 0);
            animator.SetFloat("IdleFace", 0f);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("Direction", 3);
            animator.SetFloat("IdleFace", 0.75f);
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("Direction", 1);
            animator.SetFloat("IdleFace", 0.25f);
        }
    }
}
