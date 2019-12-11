using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandScript : MonoBehaviour
{
    public GameObject BlackHand, BrownHand, WhiteHand, YellowHand, sling;

    public void SpawnBlackHand()
    {
        MassErase();
        GameObject h = Instantiate(BlackHand);
        h.GetComponent<SpringJoint2D>().connectedBody = sling.GetComponent<Rigidbody2D>();
    }

    public void SpawnBrownHand()
    {
        MassErase();
        GameObject h = Instantiate(BrownHand);
        h.GetComponent<SpringJoint2D>().connectedBody = sling.GetComponent<Rigidbody2D>();
    }

    public void SpawnWhiteHand()
    {
        MassErase();
        GameObject h = Instantiate(WhiteHand);
        h.GetComponent<SpringJoint2D>().connectedBody = sling.GetComponent<Rigidbody2D>();
    }

    public void SpawnYellowHand()
    {
        MassErase();
        GameObject h = Instantiate(YellowHand);
        h.GetComponent<SpringJoint2D>().connectedBody = sling.GetComponent<Rigidbody2D>();
    }

    private void MassErase()
    {
        GameObject[] pHand = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject hand in pHand)
        {
            Destroy(hand);
        }
    }
}
