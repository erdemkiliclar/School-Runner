using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCount : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _gemText;
    public static float currentCount;
    GameObject GemText;
    GameObject _gemPart;
    private void Awake()
    {
        _gemPart = GameObject.FindGameObjectWithTag("GemPart");
        GemText = GameObject.FindGameObjectWithTag("GemText");
        currentCount = 0;
    }

    private void Update()
    {
        GemText.GetComponent<TextMeshProUGUI>().text = SaveManager.instance.money + "";
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _gemPart.GetComponent<ParticleSystem>().Play();
            SaveManager.instance.money++;
            currentCount++;
            Destroy(this.gameObject);

        }
    }

    

}
