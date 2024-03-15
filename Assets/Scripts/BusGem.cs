using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusGem : MonoBehaviour
{
    
    [SerializeField] GameObject _bonusPanel;
    [SerializeField] float _count;


    public void Claim()
    {

       
        SaveManager.instance.money += _count;
        SaveManager.instance.Save();
        Destroy(this.gameObject);
    }

    
}
