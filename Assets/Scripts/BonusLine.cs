using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BonusLine : MonoBehaviour
{

    [SerializeField] GameObject x2L, x2R, x3L, x3R, x4L, x4R, x5;
    [SerializeField] TextMeshProUGUI _getText;
    [SerializeField] GameObject _nextLevelPanel;
    bool x2, x3, x4, xx5;
    Color _currentColor;
    GameObject _player;
    int _level;
    


    private void Awake()
    {
        _level = PlayerPrefs.GetInt("Level", _level);
        _player = GameObject.FindGameObjectWithTag("Player");
        _currentColor = x2L.GetComponent<TextMeshProUGUI>().color;
    }

    private void Update()
    {
        GemX();
    }

    void GemX()
    {
        if ((this.transform.position.x >= 144 && transform.position.x <= 237) || (this.transform.position.x > 830 && transform.position.x <= 936))
        {
            x2L.GetComponent<TextMeshProUGUI>().color = Color.white;
            x2R.GetComponent<TextMeshProUGUI>().color = Color.white;
            _getText.text = "Get 2X! " + GemCount.currentCount * 2;
            x2 = true;
        }
        else
        {
            x2L.GetComponent<TextMeshProUGUI>().color = _currentColor;
            x2R.GetComponent<TextMeshProUGUI>().color = _currentColor;
            x2 = false;
        }
        if ((this.transform.position.x > 237 && transform.position.x <= 366) || (this.transform.position.x > 704 && transform.position.x <= 830))
        {
            x3L.GetComponent<TextMeshProUGUI>().color = Color.white;
            x3R.GetComponent<TextMeshProUGUI>().color = Color.white;
            _getText.text = "Get 3X! " + GemCount.currentCount * 3;
            x3 = true;
        }
        else
        {
            x3L.GetComponent<TextMeshProUGUI>().color = _currentColor;
            x3R.GetComponent<TextMeshProUGUI>().color = _currentColor;
            x3 = false;
        }
        if ((this.transform.position.x > 366 && transform.position.x <= 474) || (this.transform.position.x > 594.5 && transform.position.x <= 704))
        {
            x4L.GetComponent<TextMeshProUGUI>().color = Color.white;
            x4R.GetComponent<TextMeshProUGUI>().color = Color.white;
            _getText.text = "Get 4X! " + GemCount.currentCount * 4;
            x4 = true;
        }
        else
        {
            x4L.GetComponent<TextMeshProUGUI>().color = _currentColor;
            x4R.GetComponent<TextMeshProUGUI>().color = _currentColor;
            x4 = false;

        }
        if (this.transform.position.x > 474 && transform.position.x <= 594.5)
        {
            x5.GetComponent<TextMeshProUGUI>().color = Color.white;
            _getText.text = "Get 5X! " + GemCount.currentCount * 5;
            xx5 = true;
        }
        else
        {
            x5.GetComponent<TextMeshProUGUI>().color = _currentColor;
            xx5 = false;
        }


    }
    public void GetGem()
    {
        GetComponent<Animator>().enabled = false;

        XX();


        if (Stopping._homeworkComplete == true)
        {

            _player.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, _player.transform.position.z + 15);
            _player.GetComponent<JoystickController2>().enabled = true;
            _nextLevelPanel.SetActive(false);
        }
        else
        {
            _level = _level + 1;
            PlayerPrefs.SetInt("Level", _level);

            SceneManager.LoadScene(0);
        }
    }


    void XX()
    {
        if (x2 == true)
        {

            SaveManager.instance.money += GemCount.currentCount;
            SaveManager.instance.Save();


        }
        if (x3 == true)
        {

            SaveManager.instance.money += (GemCount.currentCount * 3) - GemCount.currentCount;
            SaveManager.instance.Save();


        }
        if (x4 == true)
        {

            SaveManager.instance.money += (GemCount.currentCount * 4) - GemCount.currentCount;
            SaveManager.instance.Save();


        }
        if (xx5 == true)
        {

            SaveManager.instance.money += (GemCount.currentCount * 5) - GemCount.currentCount;
            SaveManager.instance.Save();


        }
    }
}
