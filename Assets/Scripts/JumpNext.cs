using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class JumpNext : MonoBehaviour
{

    public Transform _endPosition;
    public float _jumpForce;
    public float _duration;
    public float _jumpPower;
    public int _jumpCount;
    GameObject _runLine;


    private void Awake()
    {
        _runLine = GameObject.FindGameObjectWithTag("RunLine");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Ground._isJumpActive = true;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 700);
            collision.gameObject.transform.DOJump(_runLine.transform.position, _jumpPower, _jumpCount, _duration);
            collision.gameObject.GetComponent<JoystickController>().enabled = false;
        }


    }
}
