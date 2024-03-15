using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    GameObject _bag;
    [SerializeField] GameObject _checkList;
    Vector3 scaleChange;
    GameObject _tablePart;

    private void Awake()
    {
        _tablePart = GameObject.FindGameObjectWithTag("TablePart");
        _bag = GameObject.FindGameObjectWithTag("Bag");
        scaleChange = new Vector3(0.075f, 0.075f, 0.075f);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _tablePart.GetComponent<ParticleSystem>().Play();
            if (_bag.transform.localScale.x < 0.5)
            {

                collision.gameObject.GetComponent<RuntoGo>().speed = 0;
                collision.gameObject.GetComponent<RuntoGo>().enabled = false;
                collision.gameObject.GetComponent<Animator>().SetBool("_isSprint", false);
                collision.gameObject.GetComponent<Animator>().SetFloat("_isRun", 0);
                _checkList.SetActive(true);
            }
            _bag.GetComponent<Transform>().localScale -= scaleChange;
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().AddForce(250, 300, 400);
            StartCoroutine(Destroy());
        }
    }


    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
    
}
