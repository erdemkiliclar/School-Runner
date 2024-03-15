using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bol2 : MonoBehaviour
{
    GameObject _bag;
    Vector3 scaleChange;
    GameObject _negativePart;
    private void Awake()
    {
        scaleChange = new Vector3(0.6f, 0.6f, 0.6f);
        _negativePart = GameObject.FindGameObjectWithTag("NegativePart");
        _bag = GameObject.FindGameObjectWithTag("Bag");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _negativePart.GetComponent<ParticleSystem>().Play();
            _bag.transform.localScale -= scaleChange;
            Destroy(this.gameObject);
        }
    }
}
