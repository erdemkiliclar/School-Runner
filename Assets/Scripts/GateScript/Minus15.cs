using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minus15 : MonoBehaviour
{
    GameObject _bag;
    Vector3 scaleChange;
    GameObject _negativePart;
    private void Awake()
    {
        _negativePart = GameObject.FindGameObjectWithTag("NegativePart");
        _bag = GameObject.FindGameObjectWithTag("Bag");
        scaleChange = new Vector3(0.075f, 0.075f, 0.075f);
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
