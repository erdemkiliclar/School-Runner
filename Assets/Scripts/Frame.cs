using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Frame : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _frametxt;
    public int targetFrame = 60;

    public float deltaTime;

    private void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
    }
    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrame;
    }
}

