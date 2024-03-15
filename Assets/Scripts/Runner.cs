using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    [SerializeField] GameObject _vcam1, _vcam2;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Ground._isJumpActive = false;
            collision.gameObject.GetComponent<RuntoGo>().enabled = true;
            collision.gameObject.GetComponent<JoystickController>().enabled = false;
            //collision.gameObject.GetComponent<Ground>().enabled = false;
            _vcam1.SetActive(false);
            _vcam2.SetActive(true);
        }


    }
}
