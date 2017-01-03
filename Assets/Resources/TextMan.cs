using UnityEngine;
using System.Collections;
public class INFO
{
    public static string Name ;
   
}
public class TextMan : MonoBehaviour {

    public GameObject Prefab;
    public GameObject canvas;

    
    void Awake()
    {


    }
    // Use this for initialization
    void Start () {
        Debug.Log("StartKMICHI");
        INFO.Name = "KIMCHI";
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Boom()
    {
      
        Instantiate(Prefab,new Vector2(0,0),Quaternion.identity,canvas.transform);
        INFO.Name = "YourMomis 멀1록";
       
    }
}
