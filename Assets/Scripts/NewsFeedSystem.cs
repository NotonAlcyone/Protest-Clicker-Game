using UnityEngine;
using System.Collections;

public class NewsFeedSystem : MonoBehaviour
{
    public NewsFeed News;
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
        InvokeRepeating("FeedMaker", 0.0f, 4.0f);
        
    }
    void FeedMaker()
    {
        Feed = Feed.Insert(Feed.Length, HAKU);
              
        if (Random.Range(1, 100) > 70)//각각 중복피드 방지를 위한 코드 필요
        {
            if (PeaceStat == true)
            {
                int tmpPeace = Random.Range(0, News.PeaceMessage.Length );      
                Feed = Feed.Insert((Feed.Length), Replace(News.PeaceMessage[tmpPeace]));
            }
            else
            {
                int tmpViolent = Random.Range(0, News.ViolentMessage.Length);
                Feed = Feed.Insert((Feed.Length), Replace(News.ViolentMessage[tmpViolent]));
            }
        }
        else
        {
            int tmpNormal = Random.Range(0, News.NormalMessage.Length);
            Feed = Feed.Insert((Feed.Length), Replace(News.NormalMessage[tmpNormal]));
        }
        NewsFeedFirst.text = Feed;
    }
    string Replace(string ReplaceText)
    {
        ReplaceText = ReplaceText.Replace("$Mention", Mention);
        ReplaceText = ReplaceText.Replace("$Party", Party);
        return ReplaceText;
    }


    void FeedBroker()
    {
        float tmp = NewsFeedFirst.rectTransform.sizeDelta.x;
        Feed = Feed.Remove(0, 16);
        tmp -= NewsFeedFirst.rectTransform.sizeDelta.x;
        transform.Translate(tmp, 0, 0);
    }
    void Update()
    {
        tmp = NewsFeedFirst.rectTransform.sizeDelta.x;
        transform.Translate(-speed, 0, 0);
    }
    /*
    public UnityEngine.UI.Text NewsFeedDisplay;
    public string PartyName = "TestParty";
    void NewsFeedControl()
    {
        NewsFeedSystem.NormalNewsFeed[0] = NewsFeedSystem.NormalNewsFeed[0].Replace("$PartyName", PartyName);
        NewsFeedDisplay.text = NewsFeedSystem.NormalNewsFeed[0];
    }
    */

    //TextGenerationSettings settings = NewsFeedFirst.GetGenerationSettings(NewsFeedFirst.rectTransform.rect.size);
    //  float width = NewsFeedFirst.cachedTextGeneratorForLayout.GetPreferredWidth(NewsFeedFirst.text, settings);
    //   
}
