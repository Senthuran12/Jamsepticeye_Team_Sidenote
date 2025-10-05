using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCutsceneTrigger : SwitchCamera
{
    [SerializeField] private Animator anim;
    [SerializeField] private Image SwitchBackCamera;
    public GameObject Timeline;
    

    void Start()
    {
        Timeline.SetActive(true);
        SwitchBackCamera = GetComponent<Image>();
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("NPC"))
        {
            Timeline.SetActive(false);
            ChangeCamera();
            Debug.Log("cutscene has ended");
        }
    }
}
