using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SizeUp : MonoBehaviour
{
   
    [SerializeField] TextMeshProUGUI _levelText,_countText,_freeText;
    [SerializeField] GameObject _videoImage, _gemImage;
    static int _levelCount =1;
    static int _count =50;
    static bool enable;
    GameObject _bag;
    Vector3 _scaleChange;

    private void Awake()
    {
        _scaleChange = new Vector3(0.05f, 0.05f, 0.05f);
        _bag = GameObject.FindGameObjectWithTag("Bag");
        _levelCount = PlayerPrefs.GetInt("LevelCount", _levelCount);
        _count = PlayerPrefs.GetInt("SizeupCount", _count);
    }

    private void Update()
    {
        _levelText.text = "LEVEL " + PlayerPrefs.GetInt("LevelCount", _levelCount);
        _countText.text = PlayerPrefs.GetInt("SizeupCount", _count) + "";
        _freeText.text = "FREE ";
        Active();
    }

    public void Buy()
    {
        
        if (enable == true)
        {

            _levelCount++;
            _count += 10;
            _bag.transform.localScale += _scaleChange;
            SaveManager.instance.money -= PlayerPrefs.GetInt("SizeUpCount",_count);
            SaveManager.instance.Save();
            PlayerPrefs.SetInt("SizeupCount", _count);
            PlayerPrefs.SetInt("LevelCount", _levelCount);
        }
        else if (enable==false)
        {
          
            _bag.transform.localScale += _scaleChange;
            _levelCount++;
            PlayerPrefs.SetInt("LevelCount", _levelCount);
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
