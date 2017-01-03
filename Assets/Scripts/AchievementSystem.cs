using UnityEngine;
using System.Collections;

public class AchievementData
{
    public static string achievement;
    public static string imageFileName;
}

public class AchievementSystem : MonoBehaviour {

    public JSON Json;
    public ChickenSystem Chicken;
    public GameObject AchievementPrefab;
    public GameObject canvas;

    public bool chickenEverywhere;
    public bool sausageSpinner;

    void Open(string Name,string FileName,bool Stat)
    {
        AchievementData.achievement = (string)Json.dict["Achievement"][Name];//json achievement이하 목록에서 파싱
        AchievementData.imageFileName = FileName; //이미지 파일 이름
        Instantiate(AchievementPrefab, new Vector2(0,200), Quaternion.identity, canvas.transform);
        PlayerPrefs.SetInt("Achievement_" + Name, Changer(Stat));//도전과제는 클라이언트 단위로 저장
    }
    int Changer(bool Change) //bool 타입을 int로 교체(PlayerPrefs에 bool이 없어서 int로 저장)
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
    void Update()
    {
      
        // 도전과제 달성 여부 검사, 도전과제 조건 검사. if 내부에 달성 true, open(json파일 2번키값,이미지 이름,달성 여부);
        if ((chickenEverywhere == false) && (Chicken.currentStat >= 1))
        {
            chickenEverywhere = true;
            Open("ChickenEverwhere", "TestImage",chickenEverywhere);
        }
        if ((sausageSpinner == false) && (EncounterSystem.buttonPressed >= 30))
        {
            sausageSpinner = true;
            Open("SausageSpinner", "Bonfire", sausageSpinner);
        }

    }

}
