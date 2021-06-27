using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void Save()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.storage";

        FileStream stream = new FileStream(path, FileMode.Create);

        ScoreData data = new ScoreData();

        formatter.Serialize(stream, data);

        stream.Close(); 
    }

    public static ScoreData Load()
    {
        
        string path = Application.persistentDataPath + "/player.storage";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            
            FileStream stream = new FileStream(path, FileMode.Open);

            ScoreData data = formatter.Deserialize(stream) as ScoreData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("NAO TEM NENHUM DADO SALVO");
            return null;
        }

    }
}
