using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;
    int RunForwardHash;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        RunForwardHash = Animator.StringToHash("RunForward");
    }

    public void input()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool RunForward = animator.GetBool(RunForwardHash);
        bool forwardPressed = Input.GetKey("w");

     

        //if player presses w key
        if (!RunForward && forwardPressed)
        {
            animator.SetBool(RunForwardHash, true);
        }

        //if plyer is not pressing w
        if (RunForward && !forwardPressed) 
        {
            animator.SetBool(RunForwardHash, false);
        }

        input();
    }
}
