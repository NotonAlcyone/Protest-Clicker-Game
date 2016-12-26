using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewsFeedSystem : MonoBehaviour
{
    public JSON json; //import json
    public float speed = 2; //뉴스피드의 이동속도
    public int Trends; //언론 관심도 min 1 max 100 높을수록 시위보도 확률 상승

    public bool PeaceStat = true; //시위의 상태가 평화인지 폭력인지 검사(후에 수치로 바뀔수 있음)

    public string Mention = ""; //주장 replace를 위한 string
    public string Party = ""; //단체명 replace를 위한 string
    public Text NewsFeedFirst; //뉴스피드 텍스트 선언
    

    public string Feed = "";//뉴스피드 기본 string
    public string HAKU = "        ";//피드와 피드사이의 공백 
    void Start()
    {
        NewsFeedFirst.fontSize = 30; 
        InvokeRepeating("FeedCondition", 0.0f, 4.0f); //피드제작을 4초마다 호출
        
    }
    void FeedCondition()
    {
        Feed = Feed.Insert(Feed.Length, HAKU); //피드 앞쪽에 공백 삽입
              
        if (Random.Range(1, 100) > Trends)//각각 중복피드 방지를 위한 코드 필요
        {
            if (PeaceStat == true)
            {
                Maker("NewsFeed", "PeaceMessage");
            }
            else
            {
                Maker("NewsFeed", "ViolentMessage");
            }
        }
        else
        {
            Maker("NewsFeed", "NormalMessage");
        }
        NewsFeedFirst.text = Feed;
    }
    void Maker(string FirstKey,string SecondKey)
    {
        int tmp = Random.Range(0, json.dict[FirstKey][SecondKey].Count); //0에서 피드배열 수만큼 랜덤
        Feed = Feed.Insert((Feed.Length), Replace((string)json.dict[FirstKey][SecondKey][tmp]));//랜덤 숫자의 위치에 있는 문자열 출력
    }
    string Replace(string ReplaceText) //받은 문자열에서 교체가 필요한 문자열 교체
    {
        ReplaceText = ReplaceText.Replace("$Mention", Mention);
        ReplaceText = ReplaceText.Replace("$Party", Party);
        return ReplaceText;
    }
    void Update()
    {
        //tmp = NewsFeedFirst.rectTransform.sizeDelta.x;
        transform.Translate(-speed, 0, 0); // <- 방향으로 speed 만큼의 속도로 매 프레임마다 이동
    }
}
