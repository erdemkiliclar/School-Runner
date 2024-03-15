using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builds : MonoBehaviour
{
    [SerializeField] private GameObject[] buildModels;
    [SerializeField] private GameObject[] buys;
    [SerializeField] GameObject[] zemin;



    private void Start()
    {

        for (int i = 0; i < SaveManager.instance.map1Unlocked.Length; i++)
        {
            if (SaveManager.instance.map1Unlocked[i] == true)
            {
                buildModels[i].SetActive(true);
                buys[i].SetActive(false);
                zemin[i].SetActive(false);
            }
        }

    }

}
