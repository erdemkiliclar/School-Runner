using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckList : MonoBehaviour
{

    [SerializeField] GameObject _milkComplete, _xComplete, _hmComplete,_nextLevelPanel;


    // Update is called once per frame
    void Update()
    {
        if (MilkComplete._milkComplete == true)
        {
            _milkComplete.SetActive(true);
        }
        if (XComplete._x5Complete == true)
        {
            _xComplete.SetActive(true);
        }
        if (Stopping._homeworkComplete == true)
        {
            _hmComplete.SetActive(true);
        }
    }


    public void OKButton()
    {
        _nextLevelPanel.SetActive(true);
        this.gameObject.SetActive(false);
    }
    
}
