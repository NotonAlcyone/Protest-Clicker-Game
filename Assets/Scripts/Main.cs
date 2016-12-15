using UnityEngine;
using System.Collections;
using LitJson;
using System.IO;
public class Main : MonoBehaviour
{

    public ChickenSystem Chicken;
    public PopSystem Pop;
    public AchievementSystem Achievement;
    public EncounterSystem Encounter;
    public UpgradeSystem Upgrade;
    public string Noton = "loli";
    public int Day;
    private string jsonfile;
    public JsonData SaveData;
    void Awake()
    {
        //세이브파일 유무 검사
        if (File.Exists((Application.dataPath) + "/Save.json"))
        {
            jsonfile = File.ReadAllText(Application.dataPath + "/Save.json");
            SaveData = JsonMapper.ToObject(jsonfile);
            Debug.Log(SaveData["Encounter_Stage"]);

            Chicken.CurrentStat = GetSave("ChickenStat");
            Chicken.MaxStack = GetSave("ChickenMax");
            Chicken.IncreaseStack = GetSave("ChickenIncrease");

            Pop.PopStat = GetSave("PopStat");
            Pop.PopStatIncrease = GetSave("PopIncrease");

            Upgrade.LevelOne = GetSave("Upgrade_One");
            Upgrade.LevelTwo = GetSave("Upgrade_Two");
            Upgrade.LevelThree = GetSave("Upgrade_Three");
            Upgrade.LevelFour = GetSave("Upgrade_Four");
            Upgrade.LevelFive = GetSave("Upgrade_Five");
            Upgrade.LevelSix = GetSave("Upgrade_Six");
            SaveData["Encounter_Stage"] = true;
            Day = GetSave("Day");
            Debug.Log(SaveData["Encounter_Stage"]);

        }//세이브파일이 없으면 아래와 같이
        else
        {
            Chicken.CurrentStat = 0;
            Chicken.MaxStack = 100;
            Chicken.IncreaseStack = 1;

            Pop.PopStat = 0;
            Pop.PopStatIncrease = 1;

            Upgrade.LevelOne = 1;
            Upgrade.LevelTwo = 1;
            Upgrade.LevelThree = 1;
            Upgrade.LevelFour = 1;
            Upgrade.LevelFive = 1;
            Upgrade.LevelSix = 1;

            Debug.Log("NoData!");
        }
        AchievementLoad();

        Day++; // 스테이지 로드후 스테이지에 +1 추가
    }
    int GetSave(string Key)
    {
        return (int)SaveData[Key];
    }
    
    void AchievementLoad()
    {

        Achievement.ChickenEVERYWHERE = Changer(PlayerPrefs.GetInt("Achievement_ChickenEVERYWHERE",0));
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



