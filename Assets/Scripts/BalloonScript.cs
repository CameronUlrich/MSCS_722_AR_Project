using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //This moves the balloons up after they spawn.
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
    }
}
