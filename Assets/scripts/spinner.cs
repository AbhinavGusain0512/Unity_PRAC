using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float yVal = 0.3f;
    
    void Update()
    {
        transform.Rotate(0, yVal, 0);
    }
}
