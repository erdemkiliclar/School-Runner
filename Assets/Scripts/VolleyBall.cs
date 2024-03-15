using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBall : MonoBehaviour
{
    GameObject _bag;
    [SerializeField] GameObject _checkList;
    Vector3 scaleChange;
    
    GameObject _ballPart;
    private void Awake()
    {
        _ballPart = GameObject.FindGameObjectWithTag("BallPart");
        _bag = GameObject.FindGameObjectWithTag("Bag");
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _ballPart.GetComponent<ParticleSystem>().Play();
            if (_bag.transform.localScale.x < 0.5)
            {

                
                collision.gameObject.GetComponent<RuntoGo>().enabled = false;
                collision.gameObject.GetComponent<Animator>().SetBool("_isSprint", false);
                _checkList.SetActive(true);
             
            }
            _bag.GetComponent<Transform>().localScale -= scaleChange;
            GetComponent<SphereCollider>().enabled = false;
            Destroy(this.gameObject);
        }
    }


    


    
}
