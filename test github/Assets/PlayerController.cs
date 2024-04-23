using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;


    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("stop");
            playerAnim.SetBool("RunForward", false);
            playerAnim.SetBool("Jump", false);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("run");
            playerAnim.SetBool("RunForward", true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Jump");
            playerAnim.SetBool("Jump", true);
        }
    }
}
