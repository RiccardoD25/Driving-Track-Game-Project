using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWaterSplash : MonoBehaviour
{
    public class ApplicationData
    {
        public static bool DidIHitWater;
    }

    // Start is called before the first frame update
    void Start()
    {
        ApplicationData.DidIHitWater = false;
    }

    void OnCollisionEnter(Collision MyPlayer)
    {
        //Check for a match with the tag "player"
        if (MyPlayer.gameObject.tag == "Player")
        {
            if (ApplicationData.DidIHitWater == false)
            {
                print("hit water");
                GetComponent<AudioSource>().Play();
                //Play splash sound
                ApplicationData.DidIHitWater = true;

            }//End if DidIHitWater==false
        }//End if tag==player
    }//End collision enter
}//End class
