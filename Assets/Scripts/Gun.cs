﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource portalSound;
    public AudioSource errorSound;
<<<<<<< HEAD
    public GameObject bluePortal;
    public GameObject orangePortal;
=======
    public GameObject orangePortal;
    public GameObject bluePortal;
>>>>>>> matt-10-19-2020-class-setup
    public Transform firingPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FirePortal(false);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            FirePortal(true);
        }
    }

    void FirePortal(bool isOrange)
    {
        RaycastHit raycastHit;

        if (Physics.Raycast(firingPoint.position, transform.TransformDirection(Vector3.forward), out raycastHit, Mathf.Infinity))
        {
            portalSound.Play();

            if (isOrange)
            {
<<<<<<< HEAD
                //Fire Orange Portal
                orangePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
            }
            else
            {
                //Fire Blue Portal
                bluePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
            }
        }
        else
=======
                print("ORANGE");
                orangePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
            }
            else
            {
                print("BLUE");
                bluePortal.transform.SetPositionAndRotation(raycastHit.point, Quaternion.FromToRotation(Vector3.forward, raycastHit.normal));
            }
        }
        else
>>>>>>> matt-10-19-2020-class-setup
        {
            errorSound.Play();
        }
    }
}
