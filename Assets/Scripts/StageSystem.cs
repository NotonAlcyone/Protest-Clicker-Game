using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSystem : MonoBehaviour
{
    public ChickenSystem Chicken;
    public PopSystem Pop;
    public AchievementSystem Achievement;
    public EncounterSystem Encounter;
    public Main Main;
    // Use this for initialization

    void Start()
    {
        Invoke("Restart", 20.0f); //라운드 시간
    }
    void Restart()
    {
        ChickenSave();
        PopSave();
        AchievementSave();//도전과제는 후에 외부로 저장(세이브 단위 저장이 아니라 전체로 저장되야함)
        EncounterSave();

        PlayerPrefs.SetInt("Day",Main.Day);

        Debug.Log(Chicken.CurrentStat);
      
        SceneManager.LoadScene("GameScene");//게임 씬 재시작
    }
    int Changer(bool Change) //bool 타입을 int로 교체
    {
        if (Change == true)
        {
            return 1;
        }
        else
        { 
            return 0;
        } 
    }

    void ChickenSave()//치킨 저장
    {
        IntSave("ChickenStat",Chicken.CurrentStat);
        IntSave("ChickenStack",Chicken.Stack);
        IntSave("ChickenMin",Chicken.MinStack);
        IntSave("ChickenMax",Chicken.MaxStack);
        IntSave("ChickenIncrease",Chicken.IncreaseStack);

    }
    void PopSave()//인지도 저장
    {
        IntSave("PopStat", Pop.PopStat);
        IntSave("PopIncrease",Pop.PopStatIncrease);
    }
    void AchievementSave()//도전과제 저장
    {
        IntSave("Achievement_ChickenEVERYWHERE", Changer(Achievement.ChickenEVERYWHERE));
    }
    void EncounterSave()//인카운터 저장
    {
        IntSave("Encounter_Stage", Changer(Encounter.Stage));
    }

    void IntSave(string Name,int Number)
    {
        PlayerPrefs.SetInt(Name, Number);
    }
}
