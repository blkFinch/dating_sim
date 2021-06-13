using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad
{

    public static void SaveData(PlayerStats stats)
    {
        //serializes HeroData to local hard disk
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/saveData.gd");
        bf.Serialize(file, stats);
        file.Close();
        Debug.Log("stats saved!");
    }

    public static PlayerStats LoadData()
    {
        PlayerStats loadedStats;
        if (File.Exists(Application.persistentDataPath + "/saveData.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/saveData.gd", FileMode.Open);
            loadedStats = (PlayerStats)bf.Deserialize(file);
            file.Close();
        }else{
            loadedStats = new PlayerStats("no save data");
        }
        return loadedStats;
    }
}
