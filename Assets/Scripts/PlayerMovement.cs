using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 10;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //bool isWalking = animator.GetBool("isWalking");

        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        if (horizontalInput != 0 || verticalInput != 0)
        {
            animator.SetBool("isWalking", true);
            transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
            //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
            transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
           
        }
        else
        {
            animator.SetBool ("isWalking",false);
        }

        
    }
}
