using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    [SerializeField] GameObject _otherMap;
    public int mapIndex;
    NextLevel _nextLevel;
    public static int _currentMap;
    GameObject _main;

    public GameObject[] _maps;


    public void Awake()
    {
        _main = GameObject.FindGameObjectWithTag("Main");
        _nextLevel = new NextLevel();
        PlayerPrefs.GetInt("Map", _nextLevel._map);
        PlayerPrefs.GetInt("CurrentMap", mapIndex);


    }
    

    public void Start()
    {
        LoadPlane();
    }

    public void LevelInstantiate()
    {
        
            if (NextLevel._mapComplate==false)
            {
                
                Instantiate(_maps[PlayerPrefs.GetInt("CurrentMap", mapIndex)], new Vector3(0, 0, transform.position.z), transform.rotation);
            }
            else
            {
                mapIndex = Random.Range(0, 4);
                if (mapIndex == PlayerPrefs.GetInt("CurrentMap", mapIndex))
                {
                    mapIndex = Random.Range(0, 4);
                }
                PlayerPrefs.SetInt("CurrentMap", mapIndex);
                Instantiate(_maps[mapIndex], new Vector3(0, 0, transform.position.z), transform.rotation);
            }
        
        

    }

    private void LoadPlane()
    {
        if (_main.GetComponent<NextLevel>()._map >= 4)
        {
            LevelInstantiate();
        }
        else
        {
            Instantiate(_maps[_main.GetComponent<NextLevel>()._map], new Vector3(0, 0, transform.position.z), transform.rotation);
        }
    }
}
