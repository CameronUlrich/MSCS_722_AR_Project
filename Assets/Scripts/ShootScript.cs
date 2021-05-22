using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;
    
    

    public void Shoot()
    {
        //use this for hitboxes to detect if a balloon is in the crosshair
        RaycastHit hit;

        //if balloon is in crosshair we destroy that balloon
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)")
            {
                Destroy(hit.transform.gameObject);
                
                
                //we then have smoke play where the balloon was destroyed.
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
    
}
