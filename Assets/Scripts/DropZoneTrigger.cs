using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZoneTrigger : SwitchCamera
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Image _SwitchCamera;

    void Start()
    {
        _SwitchCamera = GetComponent<Image>();
    }
    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("KeyItem"))
        {
            ChangeCamera();
            Debug.Log("Sphere has dropped on zone");
        }
    }
}
