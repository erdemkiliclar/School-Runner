using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoButton : MonoBehaviour
{


    public void Get()
    {
        SaveManager.instance.money += 400;
        SaveManager.instance.Save();
    }


}
