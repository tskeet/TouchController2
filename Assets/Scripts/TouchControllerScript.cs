﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControllerScript : MonoBehaviour {

    public Touchable touchable;

    public float spatialThreshold = 0.5f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount == 1)
        {
            Touch currTouch = Input.GetTouch(0);
            if(currTouch.phase == TouchPhase.Began)
            {
                touchable.SingleFingerEnter(currTouch.position);
            }
            else if(currTouch.phase == TouchPhase.Moved)
            {
                if (this.TestSpatialThreshold(currTouch.deltaPosition.magnitude))
                {
                    touchable.SingleFingerDrag(currTouch.position);
                }
            }
            else if(currTouch.phase == TouchPhase.Ended)
            {
                touchable.SingleFingerLeave(currTouch.position);
            } 
            else if(currTouch.phase == TouchPhase.Stationary)
            {
                touchable.SingleFingerHold(currTouch.position);
            }
            else if(currTouch.phase == TouchPhase.Canceled)
            {
                touchable.SingleFingerLeave(currTouch.position);
            }
        }
	}

    private bool TestSpatialThreshold(float magnitude)
    {
        return magnitude >= spatialThreshold;
    }
}
