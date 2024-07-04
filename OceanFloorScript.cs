using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanFloorScript : MonoBehaviour
{
    private bool BangPlayed = false; //sound not played

    void OnCollisionEnter(Collision MyPlayer)
    {
        //check for a match with the tag "player"
        if (MyPlayer.gameObject.tag == "Player")
        {
            if (BangPlayed == false)//is this the first impact?
            {
                GetComponent<AudioSource>().Play();
                BangPlayed = true;//no more sounds
            }
            print("hit");

            Invoke("LetBounceOnOceanFloor", 3f);//call func with delay, to let sound play out
        }

    }//end collision enter

    public void LetBounceOnOceanFloor()
    {
        ApplicationData.HitOceanFloor = true;//tell app manager we hit the floor!
        print("reload");
    }

}
