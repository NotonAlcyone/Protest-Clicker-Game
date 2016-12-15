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
    JsonData Save;

    // Use this for initialization
    void Start()
    {
        Invoke("Restart", 20.0f); //라운드 시간        
    }
    void Restart()
    {
        stat SaveFile = new stat(Chicken.CurrentStat, Chicken.MaxStack, Chicken.IncreaseStack, Pop.PopStat, Pop.PopStatIncrease, Upgrade.LevelOne, Upgrade.LevelTwo, Upgrade.LevelThree, Upgrade.LevelFour, Upgrade.LevelFive, Upgrade.LevelSix, Main.Day);
        Save = JsonMapper.ToJson(SaveFile);
        Debug.Log(Save);
        File.WriteAllText(Application.dataPath + "/Save.json", (string)Save);
        SceneManager.LoadScene("GameScene");//게임 씬 재시작
    }



    

}
public class stat
{
    public int ChickenStat;
    public int ChickenMax;
    public int ChickenIncrease;

    public int PopStat;
    public int PopIncrease;

    public int Upgrade_One;
    public int Upgrade_Two;
    public int Upgrade_Three;
    public int Upgrade_Four;
    public int Upgrade_Five;
    public int Upgrade_Six;

    public int Day;

    public bool? Encounter_Stage;




    public stat(int ChickenStat, int ChickenMax, int ChickenIncrease,int PopStat,int PopIncrease, int Upgrade1,int upgrade2,int upgrade3,int upgrade4,int upgrade5,int upgrade6,int day)
    {
        this.ChickenStat = ChickenStat;
        this.ChickenMax = ChickenMax;
        this.ChickenIncrease = ChickenIncrease;
        this.PopStat = PopStat;
        this.PopIncrease = PopIncrease;
        this.Upgrade_One = Upgrade1;
        this.Upgrade_Two = upgrade2;
        this.Upgrade_Three = upgrade3;
        this.Upgrade_Four = upgrade4;
        this.Upgrade_Five = upgrade5;
        this.Upgrade_Six = upgrade6;
        this.Day = day;

    }
}