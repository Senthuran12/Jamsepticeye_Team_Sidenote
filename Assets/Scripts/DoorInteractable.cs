using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : MonoBehaviour,IInteractable 
{
    private Animator animator;
    private bool isOpen;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ToggleDoor()
    {
        if(isOpen = !isOpen)
        {
            animator.SetBool("IsOpen", isOpen);

        }
        else
        {
            animator.SetBool("IsOpen",false);
        }
        
    }

    public void Interact()
    {
       ToggleDoor();
    }

    public string GetInteractText()
    {
        return "Open/Close";
    }
}
