using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus125 : MonoBehaviour
{
    GameObject _bag;
    Vector3 scaleChange;
    GameObject _positivePart;
    private void Awake()
    {
        _positivePart = GameObject.FindGameObjectWithTag("PositivePart");
        _bag = GameObject.FindGameObjectWithTag("Bag");
        scaleChange = new Vector3(0.35f, 0.35f, 0.35f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _positivePart.GetComponent<ParticleSystem>().Play();
            _bag.transform.localScale += scaleChange;
            Destroy(this.gameObject);
        }
    }
}
