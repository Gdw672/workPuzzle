using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class saves : MonoBehaviour
{

    private void Awake()
    {

    }
    private void Start()
    {
        saveLvl();

    }

    public  void saveLvl()
    {

        files files = new files();
        files.lvl = classLvlAndScore.lvl;
        files.score = classLvlAndScore.score;

        string json = JsonUtility.ToJson(files);
        File.WriteAllText(Application.persistentDataPath + "/LvlSave.json", json);
        Debug.Log(json);
    }

   public int loadLvl()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/LvlSave.json");
        files file = JsonUtility.FromJson<files>(json);

        return file.lvl;

    }
    public int loadScore()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/LvlSave.json");
        files file = JsonUtility.FromJson<files>(json);

        return file.score;

    }


    class files 
    {
        
        public int lvl;
        public int score;

    }

}
