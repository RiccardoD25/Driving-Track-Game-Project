    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using System;
    using UnityEngine.UI;
    using UnityEngine.UIElements;
    using UnityEngine.SceneManagement;
    

    public static class ApplicationData
    {
        public static bool HitOceanFloor = false; //for future use
        public static bool DidItHitWater = false; //for future use
        public static float CurrentZvelocity; //velocity forward/backward
        public static float CurrentYvelocity; //velocity upDown, vertical, such as falling


        //new for stage 6//
        public static bool TimerIsRunning = false;
        public static bool GatePassed = false;
        public static int LapCount = 0;
        public static float MyTime = 0;
        public static float Bestlap = 0;
        public static bool CounDownIsRunning = true;
        //end of new for stage 6//
    }

    public class DriveMainScript : MonoBehaviour
    {
        ////Start vars
        //start with define input
        public float HorizAxis;
        public float VertAxis;


        public GameObject MyPlayer; //define what is the moving object to be controlled
        public float ForwardForce;
        public float TurnForce;


        void Awake()
        {
            //for future stuff
        }

        void Start()
        {
            //for future stuff
        }


        //Update is called once per frame
        void Update()
        {
            HorizAxis = Input.GetAxis("Horizontal"); //default controller, left
            VertAxis = Input.GetAxis("Vertical"); //default controller, left
            ////////////////assign functions to inputs////////////////
            if (VertAxis > 0)
            {
                GoForward();
            }
            if (VertAxis < 0)
            {
                GoBack();
            }

            if (VertAxis == 0) ///if user let go of either up or down
            {
                NoGas();
            }
            if (HorizAxis < 0)
            {
                TurnLeft();
            }
            if (HorizAxis > 0)
            {
                TurnRight();
            }

        if (ApplicationData.HitOceanFloor == true)//if hit floor 
        {
            ApplicationData.HitOceanFloor = false;//reset
            //ApplicationData.TimerIsRunning = false;//for future use
            //ApplicationData.GatePassed = false;//for future use
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//go to same scene we are  on now, reload
        }

    }   //end update


        ////////////////////NOW DEFINE FINCTIONS//////////////////////


        //functions for moving. will be called by key/buttons

        public void GoForward()
        {
            MyPlayer.GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, ForwardForce);
        }

        public void NoGas()
        {
            MyPlayer.GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, 0);
        }

        public void GoBack()
        {
            MyPlayer.GetComponent<ConstantForce>().relativeForce = new Vector3(0, 0, -ForwardForce);
        }

        public void TurnLeft()
        {
            MyPlayer.transform.Rotate(Vector3.down * Time.deltaTime * TurnForce * Mathf.Abs(HorizAxis));
        }

        public void TurnRight()
        {
            MyPlayer.transform.Rotate(Vector3.up * Time.deltaTime * TurnForce * Mathf.Abs(HorizAxis));
        }
    }//end class