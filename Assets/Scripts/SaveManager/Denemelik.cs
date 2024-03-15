using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Denemelik : MonoBehaviour
{

    int count = 500;

    public void Bas()
    {
        if (SaveManager.instance.money<=count)
        {
            SaveManager.instance.money -= count;
            Destroy(this.gameObject);
        }
    }


}
