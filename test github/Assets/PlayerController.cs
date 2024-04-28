using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;

    int RunForwardHash;
    public CharacterController controller;
    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        RunForwardHash = Animator.StringToHash("RunForward");
    }




    // Update is called once per frame
    void Update()
    {
        bool RunForward = animator.GetBool(RunForwardHash);
        bool forwardPressed = Input.GetKey("w");
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
        
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
    }
}
