using UnityEngine;
using System.Collections;

public class ChickenSystem : MonoBehaviour {

    public UnityEngine.UI.Text ChickenStackDisplay;
    public UnityEngine.UI.Text ChickenStatDisplay;
    public int ChickenStack;
    public int IncreaseChickenStack;
    public int MaxChickenStack;
    public int MinChickenStack;
    public int CurrentChickenStat;
    public int CurrentChickenIncrease;

    // 시작시 호출
    void Start () {
        CurrentChickenStat = 0;
        ChickenStack = 0;
        MinChickenStack = 0;
        //이 아래는 임시
        MaxChickenStack = 100;
        IncreaseChickenStack = 10;
        CurrentChickenIncrease = 5;

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
        ChickenStackDisplay.text = "나뒹구는치킨: " + ChickenStack;
        ChickenStatDisplay.text = "주운 치킨: " + CurrentChickenStat;
        ChickenStack = Mathf.Clamp(ChickenStack, MinChickenStack, MaxChickenStack);
    }
    public void ChickenMineClicked()
    {
        if (ChickenStack > MinChickenStack)
        {
            CurrentChickenStat += CurrentChickenIncrease;
            ChickenStack -= CurrentChickenIncrease;
        }
    }
}
