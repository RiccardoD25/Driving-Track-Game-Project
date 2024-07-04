using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTriggerScript : MonoBehaviour
{

    public GameObject StartTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FrontBumper")
        {
            //print("lap complete");
            ApplicationData.LapCount++;//up by one
                                       // print(ApplicationData.Lapcount);

            if (ApplicationData.MyTime < ApplicationData.Bestlap || ApplicationData.Bestlap == 0f)
            {//if we beat the best so far, or it is our first...
                ApplicationData.Bestlap = ApplicationData.MyTime;//new best record!
            }

            ApplicationData.MyTime = 0; //reset clock for next lap
            StartTrigger.SetActive(true);//re activate the start trigger
            this.gameObject.SetActive(false);//de activate finish trigger (self).
            //it will be re- activated when we trigger the start line again...
        }//end if
    }//end on trigger
}//end class

