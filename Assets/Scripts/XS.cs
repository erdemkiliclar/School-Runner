using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XS : MonoBehaviour
{

    Color _imageColor;

    private void Awake()
    {
        _imageColor = this.gameObject.GetComponent<Image>().color;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.GetComponent<Image>().color = Color.Lerp(Color.white, _imageColor, 0.5f);
            
        }
    }

    

}
