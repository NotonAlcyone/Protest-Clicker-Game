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
    public int day;
    private string jsonFile;
    public JsonData SaveData;
    void Start()
    {
        //세이브파일 유무 검사
        if (File.Exists((Application.dataPath) + "/Save.json"))
        {
            jsonFile = File.ReadAllText(Application.dataPath + "/Save.json");
            SaveData = JsonMapper.ToObject(jsonFile);

            Chicken.currentStat = GetSave("chickenStat");
            Chicken.maxStack = GetSave("chickenMax");
            Chicken.increaseStack = GetSave("chickenIncrease");

            Pop.Stat = GetSave("popStat");
            Pop.StatIncrease = GetSave("popIncrease");

            Upgrade.levelOne = GetSave("upgradeOne");
            Upgrade.levelTwo = GetSave("upgradeTwo");
            Upgrade.levelThree = GetSave("upgradeThree");
            Upgrade.levelFour = GetSave("upgradeFour");
            Upgrade.levelFive = GetSave("upgradeFive");
            Upgrade.levelSix = GetSave("upgradeSix");

            day = GetSave("day");

            Encounter.stage = (bool)SaveData["encounterStage"]; //Stage만 넣으면 가능하게 함수화
            EncounterAnswer.answerDict["Stage"] = (bool)SaveData["encounterAnswerStage"];
            Encounter.reki = (bool)SaveData["encounterReki"];
            EncounterAnswer.answerDict["Stage"] = (bool)SaveData["encounterAnswerReki"];

            Achievement.chickenEverywhere = (bool)SaveData["achievementChickenEveryWhere"];
            Achievement.sausageSpinner = (bool)SaveData["achievementSausageSpinner"];
        }//세이브파일이 없으면 아래의 초기값 입력
        else
        {
            Chicken.currentStat = 0;
            Chicken.maxStack = 100;
            Chicken.increaseStack = 1;

            Pop.Stat = 0;
            Pop.StatIncrease = 1;

            Upgrade.levelOne = 1;
            Upgrade.levelTwo = 1;
            Upgrade.levelThree = 1;
            Upgrade.levelFour = 1;
            Upgrade.levelFive = 1;
            Upgrade.levelSix = 1;

            Debug.Log("NoData!");
        }
        AchievementLoad(); //도전과제는 PlayerPrefs 로 로컬 저장

        day++; // 스테이지 로드후 스테이지에 +1 추가
    }
    int GetSave(string Key)
    {
        return (int)SaveData[Key];
    }
    void AchievementLoad()
    {
       // Achievement.ChickenEVERYWHERE = Changer(PlayerPrefs.GetInt("Achievement_ChickenEVERYWHERE",0));
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



