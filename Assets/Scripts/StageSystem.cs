using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
using System.IO;
using UnityEngine.SceneManagement;

public class StageSystem : MonoBehaviour
{
    public ChickenSystem Chicken;
    public PopSystem Pop;
    public AchievementSystem Achievement;
    public EncounterSystem Encounter;
    public Main Main;
    public UpgradeSystem Upgrade;
        
    // Use this for initialization
    void Start()
    {
        Invoke("Restart", 140.0f); //라운드 시간  
    }
    void Restart()
    {

        SaveTitle();
    
        
    }
    public void SaveTitle()
    {
        Stat SaveFile = new Stat();

        SaveFile.chickenStat = Chicken.currentStat;
        SaveFile.chickenMax = Chicken.maxStack;
        SaveFile.chickenIncrease = Chicken.increaseStack;

        SaveFile.popIncrease = Pop.StatIncrease;
        SaveFile.popStat = Pop.Stat;

        SaveFile.upgradeOne = Upgrade.levelOne;
        SaveFile.upgradeTwo = Upgrade.levelTwo;
        SaveFile.upgradeThree = Upgrade.levelThree;
        SaveFile.upgradeFour = Upgrade.levelFour;
        SaveFile.upgradeFive = Upgrade.levelFive;
        SaveFile.upgradeSix = Upgrade.levelSix;

        SaveFile.day = Main.day;

        SaveFile.encounterStage = Encounter.stage;
        SaveFile.encounterAnswerStage = EncounterAnswer.answerDict["Stage"];
        SaveFile.encounterReki = Encounter.reki;
        SaveFile.encounterAnswerReki = EncounterAnswer.answerDict["Reki"];
        

        SaveFile.achievementChickenEveryWhere = Achievement.chickenEverywhere;
        SaveFile.achievementSausageSpinner = Achievement.sausageSpinner;



        string TextSave = JsonMapper.ToJson(SaveFile);
        File.WriteAllText(Application.dataPath + "/Save.json", TextSave);
        SceneManager.LoadScene("GameScene");//게임 씬 재시작

    }
    
}
public class Stat //저-장
{
    public int chickenStat;
    public int chickenMax;
    public int chickenIncrease;

    public int popStat;
    public int popIncrease;

    public int upgradeOne;
    public int upgradeTwo;
    public int upgradeThree;
    public int upgradeFour;
    public int upgradeFive;
    public int upgradeSix;

    public int day;

    public bool encounterStage;
    public bool encounterAnswerStage;
    public bool encounterReki;
    public bool encounterAnswerReki;

    


    public bool achievementChickenEveryWhere;
    public bool achievementSausageSpinner;






}