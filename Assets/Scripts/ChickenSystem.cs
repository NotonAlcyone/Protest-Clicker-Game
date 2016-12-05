using UnityEngine;
using System.Collections;
using System.IO;

[System.Serializable]


public class ChickenSystem : MonoBehaviour
{

    public PopSystem Pop;

    public UnityEngine.UI.Text StackDisplay;
    public UnityEngine.UI.Text StatDisplay;

    public int Stack;
    public int IncreaseStack;
    public int MaxChickenStack;
    public int MinChickenStack;

    public int CurrentStat;


    // 시작시 호출
    void Start()
    {
        InvokeRepeating("ChickenIncrease", 1.0f, 1.0f); //시작후 1초후부터 매 1 초마다 ChickenIncrease 호출       
    }

    void ChickenIncrease()
    {
        if (Stack < MaxChickenStack)
        {
           Stack += (Pop.PopStat) / 10;
        }
    }

    // 프레임마다 호출
    void Update()
    {
        StackDisplay.text = JsonLoad.File.UI.ChickenStack + Stack;
        StatDisplay.text = JsonLoad.File.UI.ChickenStat + CurrentStat;
        Stack = Mathf.Clamp(Stack, MinChickenStack, MaxChickenStack); //치킨"스택"의 최소와 최대치를 정의
    }
}
