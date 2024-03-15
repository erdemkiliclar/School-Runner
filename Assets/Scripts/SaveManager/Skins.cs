using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour
{
    [SerializeField] private GameObject[] carModels;
    [SerializeField] private GameObject[] headModels;

    private void Awake()
    {

        //ChooseCarModel(SaveManager.instance.currentSkin);
        //ChooseCarModel(SaveManager.instance.currentHead);

    }
    private void ChooseCarModel(int _index)
    {
        Instantiate(carModels[_index], transform.position, Quaternion.identity, transform);
        Instantiate(headModels[_index], transform.position, Quaternion.identity, transform);
    }
}
