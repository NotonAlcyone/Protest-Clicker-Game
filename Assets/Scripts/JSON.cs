using UnityEngine;
using System.Collections;
using LitJson;

[System.Serializable]
public class JsonLoad
{
    public static TextAsset Feed = Resources.Load<TextAsset>("KR");
    public static string Script = Feed.text;
}
[System.Serializable]
public class JSON : MonoBehaviour
{
    public JsonData dict;

    void Awake()
    {
        dict = JsonMapper.ToObject(JsonLoad.Script);
    }

    void Start()
    {

        // Debug.Log(JsonMapper.ToObject(ObjectLoad.Pro)["Achievement"]["ChickenEVERYWHERE"]);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
