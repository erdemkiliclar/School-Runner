using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSelect : MonoBehaviour
{
    
    [Header("Car Attributes")]
    [SerializeField] private int[] carPrices;
    [SerializeField] Button[] _buttons;
    private int currentSkin;
    [SerializeField] GameObject[] gemImage;

    private void Start()
    {
        currentSkin = SaveManager.instance.currentSkin;
        SelectCar(currentSkin);
    }

    
    private void SelectCar(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.SetActive(i == _index);

        UpdateUI();
    }

    private void UpdateUI()
    {
        //If current car unlocked show the play button
        for (int i = 0; i < SaveManager.instance.skinsUnlocked.Length; i++)
        {
            if (SaveManager.instance.skinsUnlocked[i] == true)
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
        currentSkin = keyIndex;
        if (SaveManager.instance.money >= carPrices[keyIndex] && SaveManager.instance.skinsUnlocked[keyIndex] == false)
        {
            if (SaveManager.instance.skinsUnlocked[8] == false && keyIndex == 8 || SaveManager.instance.skinsUnlocked[9] == false && keyIndex == 9 || SaveManager.instance.skinsUnlocked[10] == false && keyIndex == 10 || SaveManager.instance.skinsUnlocked[11] == false && keyIndex == 11)
            {
                
            }
            SaveManager.instance.money -= carPrices[keyIndex];
            SaveManager.instance.skinsUnlocked[keyIndex] = true;
            SaveManager.instance.currentSkin = currentSkin;
            SelectCar(currentSkin);
            SaveManager.instance.Save();
            UpdateUI();
            
        }
        if (SaveManager.instance.skinsUnlocked[keyIndex] == true)
        {
            SaveManager.instance.currentSkin = currentSkin;
            SelectCar(currentSkin);
            SaveManager.instance.Save();
            UpdateUI();
        }
        
        
    }


}
