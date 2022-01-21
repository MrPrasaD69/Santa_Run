using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    //What we are Following
    public Transform target;

    //TIme to follow Target
    public float smoothTime = .12f;

    //Zero out the velocity
    Vector3 velocity = Vector3.zero;

    //Enabling and setting the min and max value for x and y
    //for Y
    public bool YMaxEnabled = false;
    public float YMaxValue = 0;
    public bool YMinEnabled = false;
    public float YMinValue = 0;

    //for X
    public bool XMaxEnabled = false;
    public float XMaxValue = 0;
    public bool XMinEnabled = false;
    public float XMinValue = 0;

    void FixedUpdate()
    {
        //Target position
        Vector3 targetPos = target.position;

        //Vertical
        if (YMinEnabled && YMaxEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, YMaxValue);
        }
        else if (YMinEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, target.position.y);
        }
        else if (YMaxEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, target.position.y, YMaxValue);
        }

        //Horizontal
        if (XMinEnabled && XMaxEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, XMaxValue);
        }
        else if (XMinEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, target.position.x);
        }
        else if (XMaxEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, target.position.x, XMaxValue);
        }

        //Align the camera and targets z pos
        targetPos.z = transform.position.z;

        //Using smoothDamp we will gradually change the camera transform position to the target position based on camera transform velocity and our smoothTime
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

       
    }
}
