using UnityEngine;
using System.Collections;
[System.Serializable]
public class Feedable
{
    public string ChickenStat;
    public string ChickenStack;
    public string PopStat;
    public string Upgrade;


}
[System.Serializable]
public class ObjectLoad
{
    public Feedable UI;

    static TextAsset Feed = Resources.Load<TextAsset>("KR");
    static public string Pro = Feed.text;
  

}
[System.Serializable]
public class JsonLoad
{
    public static ObjectLoad File = JsonUtility.FromJson<ObjectLoad>(ObjectLoad.Pro);
}
public class JSON : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
