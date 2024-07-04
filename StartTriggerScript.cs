using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTriggerScript : MonoBehaviour
{
    public AudioSource StartSound;
    public GameObject FinishTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FrontBumper")
        {
            // print("gate");
            StartSound.Play();
            FinishTrigger.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
