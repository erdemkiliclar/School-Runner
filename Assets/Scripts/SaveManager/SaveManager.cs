using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance { get; private set; }

    //What we want to save
    public int currentSkin;
    public int currentHead;
    public int currentBag;
    public float money ;
    public bool[] skinsUnlocked = new bool[12] { true, false, false, false, false, false,false,false,false,false,false,false };
    public bool[] headsUnlocked = new bool[12] { true, false, false, false, false, false, false, false, false, false, false, false };
    public bool[] map1Unlocked = new bool[5] { false, false, false, false, false};
    public bool[] bagsUnlocked = new bool[12] { true, false, false, false, false, false, false, false, false, false, false, false };

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(gameObject);
        Load();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            money = data.money;
            currentSkin = data.currentSkin;
            currentBag = data.currentBag;
            skinsUnlocked = data.skinsUnlocked;
            currentHead = data.currentHead;
            headsUnlocked = data.headsUnlocked;
            map1Unlocked = data.map1Unlocked;
            bagsUnlocked = data.bagsUnlocked;

            if (data.skinsUnlocked == null)
            {
                skinsUnlocked = new bool[12] { true, false, false, false, false, false, false, false, false, false, false, false };
            }
            if (data.headsUnlocked == null)
            {
                headsUnlocked = new bool[12] { true, false, false, false, false, false, false, false, false, false, false, false };
            }   
            if (data.map1Unlocked == null)
            {
                
                map1Unlocked = new bool[5] { false, false, false, false, false };
            }
            
            if (data.bagsUnlocked==null)
            {
                bagsUnlocked = new bool[12] { true, false, false, false, false, false, false, false, false, false, false, false };

            }

            file.Close();

        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data = new PlayerData_Storage();

        data.money = money;
        data.currentSkin = currentSkin;
        data.skinsUnlocked = skinsUnlocked;
        data.currentHead = currentHead;
        data.currentBag = currentBag;
        data.headsUnlocked = headsUnlocked;
        data.map1Unlocked = map1Unlocked;
        data.bagsUnlocked = bagsUnlocked;

        bf.Serialize(file, data);
        file.Close();
    }
}

[Serializable]
class PlayerData_Storage
{
    public int currentSkin;
    public int currentHead;
    public int currentBag;
    public float money;
    public bool[] skinsUnlocked;
    public bool[] headsUnlocked;
    public bool[] bagsUnlocked;
    public bool[] map1Unlocked;

}