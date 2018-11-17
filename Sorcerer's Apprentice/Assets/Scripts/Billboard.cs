using UnityEngine;
using System;
using System.Collections;
[ExecuteInEditMode]
public class Billboard : MonoBehaviour
    {
    public bool flipDirection;



    //Orient the camera after all movement is completed this frame to avoid jittering
    void LateUpdate  ()
        {

        if (flipDirection)
            {
            transform.LookAt (transform.position + Camera.main.transform.rotation * Vector3.back, Vector3.up);
            }
            else
            {
        transform.LookAt (transform.position + Camera.main.transform.rotation * Vector3.forward, Vector3.up);
            }
            transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
        }
    }
