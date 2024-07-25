using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{


    private PlatformEffector2D effector;


    public float startWaitTime;

    private float WaitedTime;



    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.DownArrow) ||  Input.GetKeyUp ("s"))
        {
            WaitedTime = startWaitTime;
        }



        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            if (WaitedTime <= 0)
            {

                effector.rotationalOffset = 180f;
                WaitedTime = startWaitTime;


            }
            else
            {
                WaitedTime -= Time.deltaTime;
            }
        }
            if (Input.GetKey("space"))

            {

                effector.rotationalOffset = 0;
            }


        
    }
}