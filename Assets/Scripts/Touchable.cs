using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Touchable : MonoBehaviour {

    public abstract void SingleFingerEnter(Vector2 position);
    public abstract void SingleFingerLeave(Vector2 position);
    public abstract void Tap(Vector2 position);
    public abstract void SingleFingerHold(Vector2 position);
    public abstract void SingleFingerDrag(Vector2 newPosition);
}
