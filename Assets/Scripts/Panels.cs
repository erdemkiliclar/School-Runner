using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panels : MonoBehaviour
{
    [SerializeField] GameObject _headPanel, _skinPanel,_bagPanel;



    public void HeadPanel()
    {
        _headPanel.SetActive(true);
        _skinPanel.SetActive(false);
        _bagPanel.SetActive(false);
    }

    public void SkinPanel()
    {
        _headPanel.SetActive(false);
        _skinPanel.SetActive(true);
        _bagPanel.SetActive(false);
    }

    public void BagPanel()
    {
        _headPanel.SetActive(false);
        _skinPanel.SetActive(false);
        _bagPanel.SetActive(true);
    }



}
