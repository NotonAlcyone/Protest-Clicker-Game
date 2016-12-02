using UnityEngine;
using System.Collections;
using System.IO;

[System.Serializable]


public class ChickenSystem : MonoBehaviour {

    public JSON json;

    public UnityEngine.UI.Text ChickenStackDisplay;
    public UnityEngine.UI.Text ChickenStatDisplay;

    public int ChickenStack;
    public int IncreaseChickenStack;
    public int MaxChickenStack;
    public int MinChickenStack;

    public int CurrentChickenStat;

   
    // 시작시 호출
    void Start ()
    {
        Debug.Log(JsonLoad.File.UI.ChickenStat);
        InvokeRepeating("ChickenIncrease",1.0f,1.0f); //시작후 1초후부터 매 1 초마다 ChickenIncrease 호출       
    }	

    void ChickenIncrease ()
    {
      if (ChickenStack < MaxChickenStack)
        {
            ChickenStack += IncreaseChickenStack; //스택된 치킨이 최대치보다 적을경우 스택에 증가량을 더함 
        }     
    }
    
    // 프레임마다 호출
    void Update ()
    {        
        ChickenStackDisplay.text = JsonLoad.File.UI.ChickenStack + ChickenStack;
        ChickenStatDisplay.text ="치킨 내놔" + CurrentChickenStat;
        ChickenStack = Mathf.Clamp(ChickenStack, MinChickenStack, MaxChickenStack); //치킨"스택"의 최소와 최대치를 정의
    }   
}
