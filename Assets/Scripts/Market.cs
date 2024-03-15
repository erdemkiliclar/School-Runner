using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    
    public GameObject _marketingPanel,  _marketCam,_exitButton,_marketButton;
    GameObject _player,respawn,_levelImage;
    public static bool _marketOn;

    private void Awake()
    {
        _marketOn = false;
        _player = GameObject.FindGameObjectWithTag("Player");
        respawn = GameObject.FindGameObjectWithTag("Respawn");
        _levelImage = GameObject.FindGameObjectWithTag("LevelBackImage");
        

    }


    private void Update()
    {
        if (_marketOn==true)
        {
            _player.transform.Rotate(0, 360 * Time.deltaTime / 2, 0);
        }
        
        
    }

    public void ExitButton()
    {
        _marketOn = false;
        _marketingPanel.SetActive(false);
        _marketCam.SetActive(false);
        _exitButton.SetActive(false);
        _marketButton.SetActive(true);
        _levelImage.SetActive(true);
        _player.transform.position = new Vector3(0, 0, 0);
        _player.transform.rotation = Quaternion.identity;

    }

    public void MarketPanel()
    {
        _marketOn = true;
        _marketingPanel.SetActive(true);
        _marketCam.SetActive(true);
        _exitButton.SetActive(true);
        _marketButton.SetActive(false);
        _levelImage.SetActive(false);
        _player.transform.position = respawn.transform.position;
    }

}
