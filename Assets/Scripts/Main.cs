using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    public ChickenSystem Chicken;
    public PopSystem Pop;
	void Start () {
        Pop.PopStat = 0;
        Pop.PopStatIncrease = 10;

        Chicken.CurrentChickenStat = 0;
        Chicken.ChickenStack = 0;
        Chicken.MinChickenStack = 0;
        //이 아래는 임시
        Chicken.MaxChickenStack = 100; //치킨 최대 스택량
        Chicken.IncreaseChickenStack = 10; //치킨 증가량


    }
	
	
	void Update () {
	
	}
}
