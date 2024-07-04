using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpinner : MonoBehaviour
{
    public Rigidbody Player;

    //Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
        var locVel = Player.transform.InverseTransformDirection(Player.velocity);
        //find out velocity in local space

        ApplicationData.CurrentZvelocity = locVel.z;//will be used by other scripts later
        ApplicationData.CurrentYvelocity = locVel.y;//will be used by other scripts later
        transform.Rotate(0, 0, locVel.z, Space.Self);
    }
}
