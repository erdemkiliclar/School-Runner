using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagSelect : MonoBehaviour
{
    [Header("Car Attributes")]
    [SerializeField] private int[] bagPrices;
    [SerializeField] Button[] _buttons;
    private int currentBag;
    [SerializeField] GameObject[] gemImage;
    

   

    private void Start()
    {
        currentBag = SaveManager.instance.currentBag;
        SelectBag(currentBag);
    }

    
    private void SelectBag(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.SetActive(i == _index);

        UpdateUI();
    }

    private void UpdateUI()
    {
        //If current car unlocked show the play button
        for (int i = 0; i < SaveManager.instance.bagsUnlocked.Length; i++)
        {
            if (SaveManager.instance.bagsUnlocked[i] == true)
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
        currentBag = keyIndex;
        if (SaveManager.instance.money >= bagPrices[keyIndex] && SaveManager.instance.bagsUnlocked[keyIndex] == false)
        {
            if (SaveManager.instance.bagsUnlocked[8] == false && keyIndex == 8 || SaveManager.instance.bagsUnlocked[9] == false && keyIndex == 9 || SaveManager.instance.bagsUnlocked[10] == false && keyIndex == 10 || SaveManager.instance.bagsUnlocked[11] == false && keyIndex == 11)
            {
               
            }
            SaveManager.instance.money -= bagPrices[keyIndex];
            SaveManager.instance.bagsUnlocked[keyIndex] = true;
            SaveManager.instance.currentBag = currentBag;
            SelectBag(currentBag);
            SaveManager.instance.Save();
            UpdateUI();

        }
        if (SaveManager.instance.bagsUnlocked[keyIndex] == true)
        {
            SaveManager.instance.currentBag = currentBag;
            SelectBag(currentBag);
            SaveManager.instance.Save();
            UpdateUI();

        }


    }
}
