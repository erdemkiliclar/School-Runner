using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _levelCountText;
    public int _level;
    public int _map;
    public static bool _mapComplate;


    private void Awake()
    {
        _level = PlayerPrefs.GetInt("Level", _level);
        _map = PlayerPrefs.GetInt("Map", _map);
    }
    
    private void Start()
    {
        
        int currentLevel = _level + 1;

        _levelCountText.text = "LEVEL: " + currentLevel;
    }

    public void NextLevelButton()
    {
        _level = _level + 1;
        PlayerPrefs.SetInt("Level", _level);

        
            if (SaveManager.instance.map1Unlocked[0]==true && SaveManager.instance.map1Unlocked[1] == true && SaveManager.instance.map1Unlocked[2] == true&& SaveManager.instance.map1Unlocked[3] == true&& SaveManager.instance.map1Unlocked[4] == true)
            {
            _mapComplate = true;
                _map += 1;
                PlayerPrefs.SetInt("Map", _map);
                SaveManager.instance.map1Unlocked = new bool[5] { false, false, false, false, false };
            }
            else
            {
                _mapComplate = false;
            }
        
        
        
        SaveManager.instance.Save();
        SceneManager.LoadScene(0);
    }
}
