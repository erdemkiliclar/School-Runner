using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadSelect : MonoBehaviour
{
    [Header("Car Attributes")]
    [SerializeField] private int[] headPrices;
    [SerializeField] Button[] _buttons;
    private int currentHead;
    [SerializeField] GameObject[] gemImage;
    

    

    private void Start()
    {
        currentHead = SaveManager.instance.currentHead;
        SelectHead(currentHead);
    }

    
    private void SelectHead(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.SetActive(i == _index);

        UpdateUI();
    }

    private void UpdateUI()
    {
        //If current car unlocked show the play button
        for (int i = 0; i < SaveManager.instance.headsUnlocked.Length; i++)
        {
            if (SaveManager.instance.headsUnlocked[i] == true)
            {
                gemImage[i].SetActive(false);
            }
            else
            {
                gemImage[i].SetActive(true);
            }
        }
        SaveManager.instance.Save();
    }




    public void BuyCar()
    {
        for (int i = 0; i < 12; i++)
        {
            int keyIndex = i;

            if (_buttons[i] != null)
            {
                _buttons[i].onClick.AddListener(() => KeyPress(keyIndex));


            }

        }

    }

    public void KeyPress(int keyIndex)
    {
        currentHead = keyIndex;
        Debug.Log(currentHead);
        if (SaveManager.instance.money >= headPrices[keyIndex] && SaveManager.instance.headsUnlocked[keyIndex] == false)
        {
            if (SaveManager.instance.headsUnlocked[8] == false && keyIndex == 8 || SaveManager.instance.headsUnlocked[9] == false && keyIndex == 9 || SaveManager.instance.headsUnlocked[10] == false && keyIndex == 10 || SaveManager.instance.headsUnlocked[11] == false && keyIndex == 11)
            {
              
            }
            SaveManager.instance.money -= headPrices[keyIndex];
            SaveManager.instance.headsUnlocked[keyIndex] = true;
            SaveManager.instance.currentHead = currentHead;
            SelectHead(currentHead);
            SaveManager.instance.Save();
            UpdateUI();

        }
        if (SaveManager.instance.headsUnlocked[keyIndex] == true)
        {
            SaveManager.instance.currentHead = currentHead;
            SelectHead(currentHead);
            SaveManager.instance.Save();
            UpdateUI();

        }


    }
    

}
