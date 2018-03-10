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

    public override void Tap(Vector2 tapPosition)
    {
        Vector3 tempPosition = Camera.main.ScreenToWorldPoint(new Vector3(tapPosition.x, tapPosition.y, 0.0f));
        tempPosition.z = 0.0f;
        GameObject clone = Object.Instantiate(tapCircle, tempPosition, Quaternion.identity);
        GameObject.Destroy(clone, 2.0f);
    }
}
