using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
public class ChickenSystem : MonoBehaviour
{

    public PopSystem Pop;
    public JSON Json;

    public Text stackDisplay;
    public Text statDisplay;

    public int stack;   // 치킨 예비 수치
    public int increaseStack;   // 치킨 증가율
    public int maxStack;    // 치킨 예비 수치 최대치
    public int minStack;    // 치킨 예비 수치 최소치 == 0

    public int currentStat; // 치킨 수치


    // 시작시 호출
    void Start()
    {
        InvokeRepeating("ChickenIncrease", 1.0f, 1.0f); // 시작후 1초후부터 매 1 초마다 ChickenIncrease 호출       
    }

    void ChickenIncrease()
    {
        if (stack < maxStack)
        {
           stack += (Pop.Stat) / 10;
        }
    }

    // 프레임마다 호출
    void Update()
    {
        stackDisplay.text = (string)Json.dict["UI"]["ChickenStack"] + stack;
        statDisplay.text = (string)Json.dict["UI"]["ChickenStat"] + currentStat;
        stack = Mathf.Clamp(stack, minStack, maxStack); //치킨"스택"의 최소와 최대치를 정의
    }
}

