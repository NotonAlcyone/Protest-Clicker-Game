using UnityEngine;
using System.Collections;

public class PopSystem : MonoBehaviour
{
    public JSON json;
    public UnityEngine.UI.Text PopStatDisplay;
    public int PopStat;
    public int PopStatIncrease;

    void Start()
    {

        InvokeRepeating("PopStatUP", 1.0f, 1.0f); // 실행 1초후 1초마다 함수 호출
    }

    void PopStatUP()
    {
        PopStat += PopStatIncrease;
    }


    void Update()
    {

        PopStatDisplay.text = (string) json.dict["UI"]["PopStat"] + PopStat;
    }
}
