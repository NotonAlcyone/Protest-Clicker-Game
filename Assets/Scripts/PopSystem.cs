using UnityEngine;
using System.Collections;

public class PopSystem : MonoBehaviour
{
    public JSON Json;
    public UnityEngine.UI.Text popStatDisplay;
    public int Stat;
    public int StatIncrease;

    void Start()
    {
        InvokeRepeating("PopStatUP", 1.0f, 1.0f); // 실행 1초후 1초마다 함수 호출
    }
    void PopStatUP()
    {
        Stat += StatIncrease; // 증1가
    }
    void Update()
    {
        popStatDisplay.text = (string) Json.dict["UI"]["PopStat"] + Stat;
    }
}
