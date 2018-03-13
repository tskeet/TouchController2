using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchableInterfaceScript : Touchable {

    public GameObject tapCircle;

    private GameObject touchCircle;

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

    public override void SingleFingerEnter(Vector2 enterPosition)
    {
        Vector3 tempPosition = Camera.main.ScreenToWorldPoint(new Vector3(enterPosition.x, enterPosition.y, 0.0f));
        tempPosition.z = 0.0f;
        touchCircle = Object.Instantiate(tapCircle, tempPosition, Quaternion.identity);
    }

    public override void SingleFingerLeave(Vector2 position)
    {
        Object.Destroy(touchCircle);
    }

    public override void SingleFingerHold(Vector2 position)
    {
        throw new System.NotImplementedException();
    }

    public override void SingleFingerDrag(Vector2 newPosition)
    {
        Vector3 tempPosition = Camera.main.ScreenToWorldPoint(new Vector3(newPosition.x, newPosition.y));
        tempPosition.z = 0.0f;
        touchCircle.transform.SetPositionAndRotation(tempPosition, Quaternion.identity);
    }
}
