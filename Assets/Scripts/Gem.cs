using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gem : MonoBehaviour
{
    GameObject _gemText;
    public static float gemCount;
    GameObject _gemPart;
    private void Awake()
    {
        _gemPart = GameObject.FindGameObjectWithTag("GemPart");
        _gemText = GameObject.FindGameObjectWithTag("GemText");
    }


    private void FixedUpdate()
    {
        _gemText.GetComponent<TextMeshProUGUI>().text = SaveManager.instance.money + "";

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SaveManager.instance.money++;
            gemCount++;
            _gemText.GetComponent<TextMeshProUGUI>().text = gemCount + "";
            Destroy(this.gameObject);
        }
    }
}
