using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkComplete : MonoBehaviour
{
    public static bool _milkComplete;
    static int _milkCount;

    private void Awake()
    {
        _milkCount = 0;
        _milkComplete = false;
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _milkCount++;
            if (_milkCount>=2)
            {
                _milkComplete = true;
            }
            
        }
    }
}
