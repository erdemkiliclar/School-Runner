using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RDG;
using Lofelt.NiceVibrations;

public class FinishLine : MonoBehaviour
{
    
    public static bool _levelComplete = false;
    GameObject _finishPart;

    private void Awake()
    {
        _finishPart = GameObject.FindGameObjectWithTag("FinishPart");
        _levelComplete = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _finishPart.GetComponent<ParticleSystem>().Play();
            HapticPatterns.PlayEmphasis(1.0f, 0.0f);
            _levelComplete = true;
            GOPanel._restart = false;
            SaveManager.instance.Save();
        }
    }

}
