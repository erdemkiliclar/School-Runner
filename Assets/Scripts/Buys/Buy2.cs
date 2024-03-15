using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buy2 : MonoBehaviour
{

    [SerializeField] GameObject _building,zemin;
    [SerializeField] float Count;
    [SerializeField] TextMeshProUGUI _gemText;


    private void Start()
    {
        Count = PlayerPrefs.GetFloat("Buy2", Count);
    }

    private void FixedUpdate()
    {
        _gemText.text = Count + "";
        if (Buys._buy2 == true)
        {
            if (Count > 0 && SaveManager.instance.money > 0)
            {
                Count--;
                SaveManager.instance.money--;
                PlayerPrefs.SetFloat("Buy2", Count);
                if (Count == 0)
                {
                    _building.SetActive(true);
                    zemin.SetActive(false);
                    SaveManager.instance.map1Unlocked[1] = true;
                    SaveManager.instance.Save();
                    PlayerPrefs.DeleteKey("Buy2");
                }

            }

        }
        if (Count >= SaveManager.instance.money && Buys._buy2 == true)
        {
            if (SaveManager.instance.money > 0)
            {
                Count--;
                SaveManager.instance.money--;
                PlayerPrefs.SetFloat("Buy2", Count);
                if (Count == 0)
                {
                    _building.SetActive(true);
                    zemin.SetActive(false);
                    SaveManager.instance.map1Unlocked[1] = true;
                    SaveManager.instance.Save();
                    PlayerPrefs.DeleteKey("Buy2");
                }
            }
        }
    }






}
