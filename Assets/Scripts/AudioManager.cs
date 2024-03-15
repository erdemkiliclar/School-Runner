using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RDG;
using Lofelt.NiceVibrations;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource _coinSource, _sizeUpSource, _jumpSource;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Time.timeScale = 0;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gem"))
        {
            _coinSource.Play();
            //Vibration.Vibrate(50, -1, false);
            HapticPatterns.PlayEmphasis(1.0f, 0.0f);
        }
        if (collision.gameObject.CompareTag("Gate"))
        {
            _sizeUpSource.Play();
            //Vibration.Vibrate(50, -1, false);
            HapticPatterns.PlayEmphasis(1.0f, 0.0f);

        }
        if (collision.gameObject.CompareTag("JumpPosition"))
        {
            _jumpSource.Play();
            //Vibration.Vibrate(50, -1, false);
            HapticPatterns.PlayEmphasis(1.0f, 0.0f);


        }
        if (collision.gameObject.CompareTag("Block"))
        {
            //Vibration.Vibrate(50, -1, false);
            HapticPatterns.PlayEmphasis(1.0f, 0.0f);
        }
        if (collision.gameObject.CompareTag("VolleyNet"))
        {
            //Vibration.Vibrate(50, -1, false);
            HapticPatterns.PlayEmphasis(1.0f, 0.0f);
        }
        if (collision.gameObject.CompareTag("Milk"))
        {
            //Vibration.Vibrate(50, -1, false);
            HapticPatterns.PlayEmphasis(1.0f, 0.0f);
        }

    }





}
