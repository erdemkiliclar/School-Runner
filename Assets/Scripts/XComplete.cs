using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XComplete : MonoBehaviour
{
    public static bool _x5Complete;

    private void Awake()
    {
        _x5Complete = false;
    }


    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _x5Complete = true;
        }
    }
}
