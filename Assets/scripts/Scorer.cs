using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits=0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "hit")
        {
            hits++;
            Debug.Log("You have bumped into something this many times: " + hits);
        }
        
    }
}
