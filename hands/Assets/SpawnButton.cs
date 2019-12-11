using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButton : MonoBehaviour
{

    public GameObject yellow, yellow2, black, black2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SpawnHand(int color) { 

        GameObject emptyGO = new GameObject();
        Transform newTransform = emptyGO.transform;
        if (color == 0)
        {
            Instantiate(yellow, newTransform.position, Quaternion.identity);
        }
        if (color == 1)
        {
            Instantiate(yellow, transform.position, Quaternion.identity);
        }
        if (color == 2)
        {
            Instantiate(yellow, transform.position, Quaternion.identity);
        }
        if (color == 3)
        {
            Instantiate(yellow, transform.position, Quaternion.identity);
       }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
