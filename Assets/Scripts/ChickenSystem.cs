using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
public class ChickenSystem : MonoBehaviour
{

    public PopSystem Pop;
    public JSON json;

    public Text StackDisplay;
    public Text StatDisplay;

    public int Stack;   //치킨 예비 수치
    public int IncreaseStack;   // 치킨 증가율
    public int MaxStack;    //치킨 예비 수치 최대치
    public int MinStack;    //치킨 예비 수치 최소치 == 0

    public int CurrentStat; //치킨 수치


    // 시작시 호출
    void Start()
    {
        InvokeRepeating("ChickenIncrease", 1.0f, 1.0f); //시작후 1초후부터 매 1 초마다 ChickenIncrease 호출       
    }

    void ChickenIncrease()
    {
        if (Stack < MaxStack)
        {
           Stack += (Pop.PopStat) / 10;
        }
    }

    // 프레임마다 호출
    void Update()
    {
        StackDisplay.text = (string)json.dict["UI"]["ChickenStack"] + Stack;
        StatDisplay.text = (string)json.dict["UI"]["ChickenStat"] + CurrentStat;
        Stack = Mathf.Clamp(Stack, MinStack, MaxStack); //치킨"스택"의 최소와 최대치를 정의
    }
}

