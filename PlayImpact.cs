using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayImpact : MonoBehaviour
{
    public AudioSource ImpactSound;
    public float ImpactMinSpeed;

    void OnCollisionEnter(Collision MyPlayer)
    {
        //Check for a match with the specified tag
        if (MyPlayer.gameObject.tag == "Player")

        {
            // print (Yvelocity is:"+ Mathf.Abs(ApplicationData.CurrentYvelocity));
            if (Mathf.Abs(ApplicationData.CurrentYvelocity) > ImpactMinSpeed)

            {
                ImpactSound.Play();
            }
        }
    }
}
