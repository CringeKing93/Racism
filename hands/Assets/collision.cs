using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public string handhit;
    void OnCollisionEnter2D(Collision2D col)
    {
      
        if (col.gameObject.name.Contains(handhit))
        {
            Destroy(col.gameObject);
            print(handhit);
            Destroy(gameObject);
       

        }
    }

}
    