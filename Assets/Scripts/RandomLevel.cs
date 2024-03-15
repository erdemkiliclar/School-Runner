using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevel : MonoBehaviour
{
    [SerializeField] GameObject _otherLevel;
    public int levelIndex;
    NextLevel _nextLevel;
    public static int _currentLevel;


    public GameObject[] _levels;


    public void Awake()
    {
        _nextLevel = new NextLevel();
        PlayerPrefs.GetInt("Level", _nextLevel._level);
        PlayerPrefs.GetInt("CurrentLevel", levelIndex);
        
        
    }

    
    public void Start()
    {
        LoadPlane();
    }

    public void LevelInstantiate()
    {

        if (GOPanel._restart == true)
        {
            Instantiate(_levels[PlayerPrefs.GetInt("CurrentLevel", levelIndex)], new Vector3(0, 0, 0), transform.rotation);
        }
        else
        {
            levelIndex = Random.Range(0, 53);
            PlayerPrefs.SetInt("CurrentLevel", levelIndex);
            Instantiate(_levels[levelIndex], new Vector3(0, 0, 0), transform.rotation);
        }

    }

    private void LoadPlane()
    {
        if (GetComponent<NextLevel>()._level >= 53)
        {
            LevelInstantiate();
        }
        else
        {
            Instantiate(_levels[GetComponent<NextLevel>()._level], new Vector3(0, 0, 0), transform.rotation);
        }
    }
}
