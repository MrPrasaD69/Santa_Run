using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector3 minValues, maxValues;

    public void FixedUpdate()
    {
        Follow();
  
    }
    void Follow()
    {
        Vector3 desiredPosition = target.position + offset;
        //Verify if the target position is out of bound or not.
        //Limit it to the Min and Max values.
        Vector3 boundPosition = new Vector3(Mathf.Clamp(desiredPosition.x, minValues.x, maxValues.x),
                                            Mathf.Clamp(desiredPosition.y, minValues.y, maxValues.y),
                                            Mathf.Clamp(desiredPosition.z, minValues.z, maxValues.z));
        //Here in the above code, we have limited the x,y and z axes wrp to the desiredPosition(Player's pos)

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
