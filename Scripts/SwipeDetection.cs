using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    public Player player;
    private Vector2 startPos;
    public int pixelDistToDetect = 20;
    private bool fingerDown;


    void Update ()
    {
        if (fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            fingerDown = true;
        }

        if(fingerDown)
        {
            if(Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe up");
            }
        }

        // TESTING

        // if (fingerDown == false && Input.GetMouseButtonDown(0))
        // {
        //     startPos = Input.mousePosition;
        //     fingerDown = true;
        // }

        // if(fingerDown)
        // {
        //     if(Input.mousePosition.y >= startPos.y + pixelDistToDetect)
        //     {
        //         fingerDown = false;
        //         Debug.Log("Swipe up");
        //     }
        // }

        // if(fingerDown && Input.GetMouseButtonDown(0))
        // {
        //     fingerDown = false;
        // }
    }
} 
