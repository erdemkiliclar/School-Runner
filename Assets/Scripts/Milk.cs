using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk : MonoBehaviour
{
    GameObject _bag,_player;
    Vector3 scaleChange;
    GameObject _milkPart;

    private void Awake()
    {
        _milkPart = GameObject.FindGameObjectWithTag("MilkPart");
        _bag = GameObject.FindGameObjectWithTag("Bag");
        _player = GameObject.FindGameObjectWithTag("Player");
        scaleChange = new Vector3(1f, 1f, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _milkPart.GetComponent<ParticleSystem>().Play();   
            _player.transform.localScale += scaleChange;

            
            Destroy(this.gameObject);
        }
    }
}

