using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Writton by sofa king : sofa king#9936

//version 1.0

//will add more things
public static class BinaryPlayerPrefs
{
    
    
    //ints
    public static void SetInt(string name, int value)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + name + ".bpf";

        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, value);
        stream.Close();
    }
    public static int GetInt(string name)
    {
        if (File.Exists(Application.persistentDataPath + "/" + name + ".bpf"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/" + name + ".bpf";

            FileStream stream = new FileStream(path, FileMode.Open);

            int data = (int)formatter.Deserialize(stream);

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("The key " + name + " dose not exist!");

            int? n = null;
            return (int)n;
        }
    }

    //floats
    public static void SetFloat(string name, float value)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + name + ".bpf";

        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, value);
        stream.Close();
    }
    public static float GetFLoat(string name)
    {
        if (File.Exists(Application.persistentDataPath + "/" + name + ".bpf"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/" + name + ".bpf";

            FileStream stream = new FileStream(path, FileMode.Open);

            float data = (float)formatter.Deserialize(stream);

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("The key " + name + " dose not exist!");

            float? n = null;
            return (float)n;
        }
    }

    //string
    public static void SetString(string name, string value)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + name + ".bpf";

        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, value);
        stream.Close();
    }
    public static string GetString(string name)
    {
        if (File.Exists(Application.persistentDataPath + "/" + name + ".bpf"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/" + name + ".bpf";

            FileStream stream = new FileStream(path, FileMode.Open);

            string data = (string)formatter.Deserialize(stream);

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("The key " + name + " dose not exist!");
            return null;
        }
    }

    //bool
    public static void SetBool(string name, bool value)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + name + ".bpf";

        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, value);
        stream.Close();
    }
    public static bool GetBool(string name)
    {
        if (File.Exists(Application.persistentDataPath + "/" + name + ".bpf"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/" + name + ".bpf";

            FileStream stream = new FileStream(path, FileMode.Open);

            bool data = (bool)formatter.Deserialize(stream);

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("The key " + name + " dose not exist!");
            return false;
        }
    }

    // other funcs
    public static void DeleteKey(string name)
    {
        string path = Application.persistentDataPath + "/" + name + ".bpf";

        File.Delete(path);
    }

    public static bool HasKey(string name)
    {
        string path = Application.persistentDataPath + "/" + name + ".bpf";

        if (File.Exists(path))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
    


