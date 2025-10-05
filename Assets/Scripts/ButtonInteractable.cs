using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : MonoBehaviour, IInteractable
{
    public AudioSource SFX;
    public string GetInteractText()
    {
        return "Turn ON";
    }

    public void Interact()
    {
        SFX.Play();
    }

    

}
