using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    [SerializeField] private string interactText;

    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
        Debug.Log("Interact!");

    }

    public string GetInteractText()
    {
        return interactText;
    }
}
