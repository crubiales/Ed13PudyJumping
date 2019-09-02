using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSmooth : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 1.5f, -10.0f);
    public float smoothTime = .3f;

    public float maxHigh = 10;
    public float maxLow = -10;
    public float maxLeft = 0;
    public float maxRight = 10;

    Vector3 speed;

    private void LateUpdate()
    {
        if (target == null)
        {
            Debug.Log("There is no player to follow!!");
            return;
        }


        Vector3 newPosition = target.position + offset;

        newPosition = new Vector3(Mathf.Clamp(newPosition.x, maxLeft, maxRight), Mathf.Clamp(newPosition.y, maxLow, maxHigh), newPosition.z);

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref speed, smoothTime);
    }

}
