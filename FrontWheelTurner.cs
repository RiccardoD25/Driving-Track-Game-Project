using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontWheelTurner : MonoBehaviour
{
    public float maxAngle = 30;

    public GameObject FrontRW;
    public GameObject FrontLW;
    void Start()
    {

    }
    //Update is called once per frame
    void Update()
    {
        float targetAngle = Input.GetAxis("Horizontal") * maxAngle;
        //Calculate angle based on how much the stick is "bent" sideways

        FrontRW.transform.localRotation = Quaternion.Euler(0, targetAngle + 90, 0);
        FrontLW.transform.localRotation = Quaternion.Euler(0, targetAngle + 90, 0);

    }
}
