using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject hand;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;



    void Update()
    {

        if (Time.time > nextSpawn)
        {

            whatToSpawn = Random.Range(1, 6);

            Debug.Log(whatToSpawn);

            Instantiate(hand, transform.position, Quaternion.identity);

            nextSpawn = Time.time + spawnRate;

           
           
        }
    }
}
