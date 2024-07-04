using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SoundController : MonoBehaviour

{

    public AudioSource CarSound;
    //Update is caled once per frame
    void Update()

    {
        // print (ApplicationData.CurrentZvelocity);
        CarSound.volume = Mathf.Abs(ApplicationData.CurrentZvelocity / 20.0f);

        CarSound.pitch = Mathf.Abs(ApplicationData.CurrentZvelocity / 20.0f) + 0.3f;
        // (speed/expected max speed)+"bump,never lower than"
    }

}

