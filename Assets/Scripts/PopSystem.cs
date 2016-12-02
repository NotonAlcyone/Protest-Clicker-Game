using UnityEngine;
using System.Collections;

public class PopSystem : MonoBehaviour {

    public UnityEngine.UI.Text PopStatDisplay;
    public int PopStat;
    public int PopStatIncrease;

    void Start () {

        InvokeRepeating("PopStatIncrase", 1, 1); // 실행 1초후 1초마다 함수 호출
	}

    void PopStatIncrase()
    {
        PopStat += PopStatIncrease;
    }


	void Update () {

        PopStatDisplay.text = "인기도: " + PopStat;
	}
}
