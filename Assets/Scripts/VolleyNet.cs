using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VolleyNet : MonoBehaviour
{
    GameObject _bag;
    [SerializeField] GameObject _checkList;
    Vector3 scaleChange;
    GameObject _filePart;
    private void Awake()
    {
        _filePart = GameObject.FindGameObjectWithTag("FilePart");
        _bag = GameObject.FindGameObjectWithTag("Bag");
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            _filePart.GetComponent<ParticleSystem>().Play();
            _bag.GetComponent<Transform>().localScale -= scaleChange;
            GetComponent<BoxCollider>().enabled = false;
            Destroy(this.gameObject);
        }
    }


    
}
