using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;//New!!!

public class MyUnderwater : MonoBehaviour
{
    public int underwaterLevel;

    void Update()
    {
        if (transform.position.y < underwaterLevel)
        {

            this.GetComponent<UnityEngine.Rendering.PostProcessing.PostProcessVolume>().enabled = true;

        }
            else//Not lower than 60 water level
            {

                this.GetComponent<UnityEngine.Rendering.PostProcessing.PostProcessVolume>().enabled = false;

            }
    }
}
