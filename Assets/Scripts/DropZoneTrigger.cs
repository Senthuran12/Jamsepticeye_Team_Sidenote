using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZoneTrigger : MonoBehaviour
{
    public GameObject SwitchCamera;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("has been interacted");
        if (other.CompareTag("KeyItem"))
        {
            //SwitchCamera.ChangeCamera(other.gameObject);
            Debug.Log("Sphere has dropped on zone");
        }
    }
}
