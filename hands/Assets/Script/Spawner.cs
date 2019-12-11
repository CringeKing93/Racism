using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject yellow, yellow2, black, black2;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;



    void Update()
    {

        if (Time.time > nextSpawn)
        {

            whatToSpawn = Random.Range(1, 6);

            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(yellow, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(yellow2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(black, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(black2, transform.position, Quaternion.identity);
                    break;

            }
            nextSpawn = Time.time + spawnRate;

           
           
        }
    }
}
