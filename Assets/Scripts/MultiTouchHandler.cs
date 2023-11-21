using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTouchHandler : MonoBehaviour {
    public float moveSpeed = 5.0f;
    
    void Update() {
        /*float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 firstFingerMovement = new Vector3(horizontal, 0, vertical);
        Vector3 secondFingerMovement = Input.GetMouseButton(1) ? new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0) : Vector3.zero;
        
        if (secondFingerMovement.x > 0 || secondFingerMovement.y > 0) {
            Vector3 combinedMovement = firstFingerMovement + secondFingerMovement;
            transform.Translate(combinedMovement * moveSpeed * Time.deltaTime);
        }*/

        /*int touchCount = Input.touchCount;
        if (touchCount >= 2) {
            for (int i = 0 ; i < touchCount ; i++) {
                Touch touch = Input.GetTouch(i);

                if(touch.phase == TouchPhase.Moved){
                    float moveX = touch.deltaPosition.x;
                    float moveY = touch.deltaPosition.y;

                    Debug.Log("MoveX:" + moveX + ", MoveY:" + moveY);
                }
            }
        }*/
    }
}
