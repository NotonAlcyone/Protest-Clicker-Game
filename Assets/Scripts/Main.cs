using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{

    public ChickenSystem Chicken;
    public PopSystem Pop;
    public UpgradeSystem Up;
    public AchievementSystem Achievement;
    public EncounterSystem Encounter;
    public int Day;

    void Awake()
    {
        //PlayerPrefs.DeleteAll(); //테스트용 데이터 완전삭제

        ChickenLoad();
        PopLoad();
        AchievementLoad();
        EncounterLoad();
        Debug.Log(Chicken.CurrentStat);

     

        Day = PlayerPrefs.GetInt("Day", 0);
   

        Day++; // 스테이지 로드후 스테이지에 +1 추가
    }
    void ChickenLoad()
    {
        Chicken.CurrentStat = PlayerPrefs.GetInt("ChickenStat", 0);
        Chicken.Stack = PlayerPrefs.GetInt("ChickenStack", 0);
        Chicken.MinStack = PlayerPrefs.GetInt("ChickenMin", 0);
        Chicken.MaxStack = PlayerPrefs.GetInt("ChickenMaX", 100);
        Chicken.IncreaseStack = PlayerPrefs.GetInt("ChickenIncrase", 10);
    }
    void PopLoad()
    {
        Pop.PopStat = PlayerPrefs.GetInt("PopStat", 0);
        Pop.PopStatIncrease = PlayerPrefs.GetInt("PopIncrease", 1);
    }
    void AchievementLoad()
    {

        Achievement.ChickenEVERYWHERE = Changer(PlayerPrefs.GetInt("Achievement_ChickenEVERYWHERE",0));
    }
    void EncounterLoad()
    {
        Encounter.Stage = Changer(PlayerPrefs.GetInt("Encounter_Stage", 0));
    }
    bool Changer(int Change) //bool 타입을 int로 교체
    {
        if (Change == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

