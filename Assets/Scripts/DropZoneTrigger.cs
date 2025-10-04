using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZoneTrigger : SwitchCamera
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Image _SwitchCamera;
    public GameObject Timeline;

    void Start()
    {
        Timeline.SetActive(false);
        _SwitchCamera = GetComponent<Image>();
    }
    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("KeyItem"))
        {
            Timeline.SetActive(true);
            ChangeCamera();
            Debug.Log("Sphere has dropped on zone");
        }
    }
}
