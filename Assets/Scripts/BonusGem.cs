using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BonusGem : MonoBehaviour
{
   
    [SerializeField] GameObject _bonusPanel;
    [SerializeField] float _count;

    


    private void FixedUpdate()
    {
        
        if (Buys._bonus == true)
        {
            _bonusPanel.SetActive(true);
        }
        else
        {
            _bonusPanel.SetActive(false);
        }
    }
    
        
    


    public void Claim()
    {
        
        
        SaveManager.instance.money += _count;
        SaveManager.instance.Save();
        Destroy(this.gameObject);
    }

    


}
