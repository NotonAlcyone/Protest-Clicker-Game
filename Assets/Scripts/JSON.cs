using UnityEngine;
using System.Collections;

[System.Serializable]
public class UI
{
    public string ChickenStat;
    public string ChickenStack;
    public string PopStat;
    public string Upgrade;
}
[System.Serializable]
public class NewsFeedScript
{
    public string MainFeed;
    public string Feed1;
}
[System.Serializable]
public class Achievement
{
    public string ChickenEVERYWHERE;
}
[System.Serializable]
public class Encounter
{
    public string Stage;
}
[System.Serializable]
public class EncounterDescription
{
    public string StageDescription;
}


[System.Serializable]
public class ObjectLoad
{
    public UI UI;
    public NewsFeedScript NewsFeed;
    public Achievement Achievement;
    public Encounter Encounter;
    public EncounterDescription EncounterDescription;

    static TextAsset Feed = Resources.Load<TextAsset>("KR");
    static public string Pro = Feed.text;
}
[System.Serializable]
public class JsonLoad
{
    public static ObjectLoad File = JsonUtility.FromJson<ObjectLoad>(ObjectLoad.Pro);
}
public class JSON : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
