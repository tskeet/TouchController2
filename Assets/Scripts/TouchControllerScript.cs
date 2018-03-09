﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControllerScript : MonoBehaviour {

    public Touchable touchable;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount == 1)
        {
            Touch currTouch = Input.GetTouch(0);
            if(currTouch.phase == TouchPhase.Ended)
            {
                Vector3 tempPosition = new Vector3(currTouch.position.x, currTouch.position.y, 0.0f);
                touchable.Tap(tempPosition);
            }
        }
	}
}