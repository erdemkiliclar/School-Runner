using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _levelText, _countText, _freeText;
    [SerializeField] GameObject _gemImage, _videoImage;
    static int _levelCount = 1;
    static int _count = 50;
    static bool enable;
    GameObject _player;


    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _levelCount = PlayerPrefs.GetInt("SpeedLevelCount", _levelCount);
        _count = PlayerPrefs.GetInt("LevelupCount", _count);
    }

    private void Update()
    {
        _levelText.text = "LEVEL " + PlayerPrefs.GetInt("SpeedLevelCount", _levelCount);
        _countText.text = PlayerPrefs.GetInt("LevelupCount", _count) + "";
        _freeText.text = "FREE ";
        Active();
    }

    public void Buy()
    {
        if (enable == true)
        {
            _player.GetComponent<JoystickController>().speed += 0.05f;
            _levelCount++;
            _count += 10;
            SaveManager.instance.money -= PlayerPrefs.GetInt("LevelupCount", _count);
            SaveManager.instance.Save();
            PlayerPrefs.SetInt("LevelupCount", _count);
            PlayerPrefs.SetInt("SpeedLevelCount", _levelCount);
        }
        else if (enable == false)
        {
            
            _player.GetComponent<JoystickController>().speed += 0.05f;
            _levelCount++;
            PlayerPrefs.SetInt("SpeedLevelCount", _levelCount);
        }


    }

    void Active()
    {
        if (SaveManager.instance.money >= _count)
        {
            enable = true;
            _gemImage.SetActive(true);
            _videoImage.SetActive(false);
        }
        else
        {
            enable = false;
            _gemImage.SetActive(false);
            _videoImage.SetActive(true);
        }
    }

}
