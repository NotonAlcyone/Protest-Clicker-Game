using UnityEngine;
using System.Collections;
using LitJson;

[System.Serializable]
public class JsonLoad
{
    public static TextAsset feed = Resources.Load<TextAsset>("Language/KR"); // Resources 폴더에서 KR 텍스트 파일로드
    public static string Script = feed.text;
}
[System.Serializable]
public class JSON : MonoBehaviour
{
    public JsonData dict;

    void Awake()
    {
        dict = JsonMapper.ToObject(JsonLoad.Script); //딕셔너리화
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
