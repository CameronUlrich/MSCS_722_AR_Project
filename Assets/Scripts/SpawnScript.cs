using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] balloons;
    public float xPos;
    public float zPos;

    // Start is called before the first frame update
    void Start()
    {
        //call StartSpawning function
        StartCoroutine(StartSpawning());
        
    }

    IEnumerator StartSpawning()
    {
        //wait 4 seconds
        yield return new WaitForSeconds(4f);

        //for loop that spawns three different balloons at random x and z positions around the camera
        for (int i = 0; i < 3; i++)
        {
            xPos = Random.Range(-7, 7);
            zPos = Random.Range(-3, 3);
            Instantiate(balloons[i], new Vector3(xPos, -1, zPos), Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }

    
}
