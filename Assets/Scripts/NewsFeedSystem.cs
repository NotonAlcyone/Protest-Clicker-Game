using UnityEngine;
using System.Collections;

public class NewsFeedSystem : MonoBehaviour
{
    public JSON json;
    public float speed ;
    
    public bool PeaceStat = true;
    public string Mention = "";
    public string Party = "";
    public float tmp;
    public UnityEngine.UI.Text NewsFeedFirst;
    

    public string Feed = "";
    public string HAKU = "        ";
    void Start()
    {
        speed = 2;
        NewsFeedFirst.fontSize = 30;
        InvokeRepeating("FeedCondition", 0.0f, 4.0f);
        
    }
    void FeedCondition()
    {
        Feed = Feed.Insert(Feed.Length, HAKU);
              
        if (Random.Range(1, 100) > 70)//각각 중복피드 방지를 위한 코드 필요
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
        int tmp = Random.Range(0, json.dict[FirstKey][SecondKey].Count);
        Feed = Feed.Insert((Feed.Length), Replace((string)json.dict[FirstKey][SecondKey][tmp]));

 
    }
    string Replace(string ReplaceText) //받은 문자열에서 교체가 필요한 문자열 교체
    {
        ReplaceText = ReplaceText.Replace("$Mention", Mention);
        ReplaceText = ReplaceText.Replace("$Party", Party);
        return ReplaceText;
    }
    void Update()
    {
        tmp = NewsFeedFirst.rectTransform.sizeDelta.x;
        transform.Translate(-speed, 0, 0);
    }
}
