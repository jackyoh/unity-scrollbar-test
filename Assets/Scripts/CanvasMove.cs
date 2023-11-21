using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMove : MonoBehaviour {
    public float moveSpeed = 5.0f;
    private float initialFingerDistance;

    void Update() {
        int touchCount = Input.touchCount;
        if (touchCount >= 2) {
            for (int i = 0 ; i < touchCount ; i++) {
                Touch touch = Input.GetTouch(i);
                if (touch.phase == TouchPhase.Moved) {
                    Debug.Log("Move test..........");
                    Vector2 deltaPosition = touch.deltaPosition;
                    transform.Translate(deltaPosition * moveSpeed * Time.deltaTime);
                }

                if (touch.phase == TouchPhase.Began) {
                    if (i == 1) {
                        initialFingerDistance = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
                    }
                }
            }

        }


    }
}
