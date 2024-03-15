using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGate : MonoBehaviour
{
    
    [SerializeField] GameObject[] _gates;
    public int gatesIndex;


    private void Awake()
    {
        gatesIndex = Random.Range(0,_gates.Length);
        Instantiate(_gates[gatesIndex], new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }
}
