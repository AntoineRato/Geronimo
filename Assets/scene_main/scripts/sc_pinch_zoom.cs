using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_pinch_zoom : MonoBehaviour
{
    private float ratioScale = 0.03f;
    private float rotationSpeed = 0.03f;

    private float scaleLimit = 0.2f;
    private float previousPosition;
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            previousPosition += Input.GetTouch(0).deltaPosition.x;
            transform.Rotate(Vector3.up, -previousPosition * rotationSpeed);
        }
        else if(Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);

            Vector2 firstTouchPreviousPosition = firstTouch.position - firstTouch.deltaPosition;
            Vector2 secondTouchPreviousPosition = secondTouch.position - secondTouch.deltaPosition;

            float previousTouchDeltaMagnitude = (firstTouchPreviousPosition - secondTouchPreviousPosition).magnitude;
            float newTouchDeltaMagnitude = (firstTouch.position - secondTouch.position).magnitude;

            float deltaMagnitudeDifference = previousTouchDeltaMagnitude - newTouchDeltaMagnitude;

            this.transform.localScale += new Vector3(deltaMagnitudeDifference * ratioScale, deltaMagnitudeDifference * ratioScale, deltaMagnitudeDifference * ratioScale);
            if (this.transform.localScale.x < scaleLimit)
                this.transform.localScale = new Vector3(scaleLimit, scaleLimit, scaleLimit);
        }
	}
}
