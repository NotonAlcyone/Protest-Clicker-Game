using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{

    public ChickenSystem Chicken;
    public PopSystem Pop;
    public UpgradeSystem Up;
    public NewsFeedMovement FeedMov;
    void Start()
    {

        Pop.PopStat = 0;
        Pop.PopStatIncrease = 1;
        Chicken.CurrentStat = 0;
        Chicken.Stack = 0;
        Chicken.MinChickenStack = 0;
      
        //이 아래는 임시
        Chicken.MaxChickenStack = 100; //치킨 최대 스택량
        Chicken.IncreaseStack = 10; //치킨 증가량
        FeedMov.speed = 4;



    }


    void Update()
    {

    }
}
