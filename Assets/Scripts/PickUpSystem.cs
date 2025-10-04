using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpSystem : MonoBehaviour, IInteractable
{
    bool Pickedup;
    Rigidbody body;

    public string GetInteractText()
    {
        return "PICK UP ITEM";
       
    }

    public void Interact()
    {
        if (Pickedup == false)
        {
           body.isKinematic = true;
            body.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
            Pickedup = true;
        }
        else
        {
            body.isKinematic = false;
            body.transform.parent = null;
            Pickedup = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
