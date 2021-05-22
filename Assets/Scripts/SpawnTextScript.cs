using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnTextScript : MonoBehaviour

{

    Text MyText;
    // Start is called before the first frame update
    void Start()
    {
        //call SpawnText function
        StartCoroutine(SpawnText());
        
        

    }

    IEnumerator SpawnText()
    {
        //get the text object
        MyText = GetComponent<Text>();
        //countdown for users to look around
        MyText.text = "Spawning balloons in 4";
        yield return new WaitForSeconds(1f);
        MyText.text = "Spawning balloons in 3";
        yield return new WaitForSeconds(1f);
        MyText.text = "Spawning balloons in 2";
        yield return new WaitForSeconds(1f);
        MyText.text = "Spawning balloons in 1" + Environment.NewLine + "Look around!";

        yield return new WaitForSeconds(1f);
        //destory text as otherwise you can't click the button crosshair
        Destroy(MyText);
    }
}
