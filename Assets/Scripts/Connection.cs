using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{

     [SerializeField] GameObject _connectPanel;


   

    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            _connectPanel.SetActive(true);
        }
        else
        {
            _connectPanel.SetActive(false);
        }
    }
}
