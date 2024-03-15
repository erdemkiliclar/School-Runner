using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlay : MonoBehaviour
{
    GameObject _player,_taptoplay;
    public static bool _taptoplayactive;
    
    

    private void Awake()
    {
        _taptoplayactive = true;
        _taptoplay = GameObject.FindGameObjectWithTag("TapToPlay");
        _player = GameObject.FindGameObjectWithTag("Player");
        _player.GetComponent<JoystickController>().enabled = false;

    }

    public void Tap()
    {
        Time.timeScale = 1;
        _taptoplayactive = false;
        _taptoplay.SetActive(false);
        _player.GetComponent<JoystickController>().enabled = true;
    }


    
    
}
