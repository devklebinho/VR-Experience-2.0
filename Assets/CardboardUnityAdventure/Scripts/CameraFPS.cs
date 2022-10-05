using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CameraFPS : MonoBehaviour
{
    public Transform characterBody;

    float rotationY = 0;
    float rotationX = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalDelta = Input.GetAxisRaw("Mouse Y");
        float horizontalDelta = Input.GetAxisRaw("Mouse X");

        rotationY += verticalDelta;
        rotationX += horizontalDelta;

        characterBody.localEulerAngles = new Vector3(0, rotationX, 0);
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
