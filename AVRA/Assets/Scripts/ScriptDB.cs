using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class ScriptDB : MonoBehaviour
{
    string file = "tasks.json";
    string path;
    List<addData> ListeTache = new List<addData>();

    public static void Save(addData t)
    {
        if(!File.Exists("tasks.json"))
        {
            File.Create("tasks.json");
        }
        string JsonFile = File.ReadAllText("tasks.json"); 
        var JsonDataList = JsonConvert.DeserializeObject<addData[]>(JsonFile);
        List<addData> ltp = new List<addData>(JsonDataList); //
        bool exist = false;
        foreach(addData tache in ltp)
        {
            if (t.description == tache.description)
            {
                exist = true;
                break;
            }
        }
        if (!exist) ltp.Add(t);
        JsonDataList = ltp.ToArray();
        var TmpJson = JsonConvert.SerializeObject(JsonDataList, Formatting.Indented);
        File.WriteAllText("tasks.json", TmpJson);
    }

    public static List<addData> Read()
    {
        if (File.Exists("tasks.json"))
        {
            string JsonFile = File.ReadAllText("tasks.json");
            var JsonDataList = JsonConvert.DeserializeObject<addData[]>(JsonFile);
            List<addData> ltp = new List<addData>(JsonDataList);
            ltp.Sort((a, b) => a.day.CompareTo(b.day));
            Debug.Log(ltp);
            return ltp;
        }
        return null;
    }
}
