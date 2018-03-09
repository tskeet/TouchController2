using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchableInterfaceScript : Touchable {

    public GameObject tapCircle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Tap(Vector3 position)
    {
        Debug.Log("in Tap, creating circle at: " + position);
        GameObject clone = Object.Instantiate(tapCircle, position, Quaternion.identity);
        GameObject.Destroy(clone, 2.0f);
    }
}
