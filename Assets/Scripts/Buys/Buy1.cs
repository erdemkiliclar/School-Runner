using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buy1 : MonoBehaviour
{
    [SerializeField] GameObject _building,zemin;
    [SerializeField] float Count;
    [SerializeField] TextMeshProUGUI _gemText;

    private void Start()
    {
        Count = PlayerPrefs.GetFloat("Buy1", Count);
    }
    private void FixedUpdate()
    {
        _gemText.text = Count + "";
        if (Count <= SaveManager.instance.money && Buys._buy1 == true)
        {
            if (Count > 0)
            {
                Count--;
                SaveManager.instance.money--;
                PlayerPrefs.SetFloat("Buy1", Count);
                if (Count == 0)
                {
                    zemin.SetActive(false);
                    _building.SetActive(true);
                    SaveManager.instance.map1Unlocked[0] = true;
                    SaveManager.instance.Save();
                    PlayerPrefs.DeleteKey("Buy1");
                }
            }

        }
        if (Count >= SaveManager.instance.money && Buys._buy1 == true)
        {
            if (SaveManager.instance.money > 0)
            {
                Count--;
                SaveManager.instance.money--;
                PlayerPrefs.SetFloat("Buy1", Count);
                if (Count == 0)
                {
                    zemin.SetActive(false);
                    _building.SetActive(true);
                    SaveManager.instance.map1Unlocked[0] = true;
                    SaveManager.instance.Save();
                    PlayerPrefs.DeleteKey("Buy1");
                }
            }
        }
    }



}
