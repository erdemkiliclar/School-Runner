using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buy5 : MonoBehaviour
{
    [SerializeField] GameObject _building,zemin;
    [SerializeField] float Count;
    [SerializeField] TextMeshProUGUI _gemText;


    private void Start()
    {
        Count = PlayerPrefs.GetFloat("Buy5", Count);
    }
    private void FixedUpdate()
    {
        _gemText.text = Count + "";
        if (Count <= SaveManager.instance.money && Buys._buy5 == true)
        {
            if (Count > 0)
            {
                Count--;
                SaveManager.instance.money--;
                PlayerPrefs.SetFloat("Buy5", Count);
                if (Count == 0)
                {
                    zemin.SetActive(false);
                    _building.SetActive(true);
                    SaveManager.instance.map1Unlocked[4] = true;
                    SaveManager.instance.Save();
                    PlayerPrefs.DeleteKey("Buy5");
                }
            }

        }
        if (Count >= SaveManager.instance.money && Buys._buy5 == true)
        {
            if (SaveManager.instance.money > 0)
            {
                Count--;
                SaveManager.instance.money--;
                PlayerPrefs.SetFloat("Buy5", Count);
                if (Count == 0)
                {
                    zemin.SetActive(false);
                    _building.SetActive(true);
                    SaveManager.instance.map1Unlocked[4] = true;
                    SaveManager.instance.Save();
                    PlayerPrefs.DeleteKey("Buy5");
                }
            }
        }
    }
}
