using UnityEngine;
using System.Collections;

public class NewsFeedSystem : MonoBehaviour
{
    public NewsFeed News;
    public bool PeaceStat = true;
    public string Mention = "";

    public UnityEngine.UI.Text NewsFeedFirst;

    public string Feed = "";
    public string HAKU = "        ";
    void Start()
    {
        NewsFeedFirst.fontSize = 30;
        InvokeRepeating("FeedMaker", 0.0f, 1.5f);
    }
    void FeedMaker()
    {
        Feed = Feed.Insert(Feed.Length, HAKU);
              
        if (Random.Range(1, 100) > 70)
        {
            if (PeaceStat == true)
            {
                int tmpPeace = Random.Range(0, News.PeaceMessage.Length );
                string Replace = News.PeaceMessage[tmpPeace].Replace("$Mention", Mention);
                Feed = Feed.Insert((Feed.Length), Replace);
            }
            else
            {
                int tmpViolent = Random.Range(0, News.ViolentMessage.Length);
                Feed = Feed.Insert((Feed.Length), News.ViolentMessage[tmpViolent]);
            }
        }
        else
        {
            int tmpNormal = Random.Range(0, News.NormalMessage.Length);
            Feed = Feed.Insert((Feed.Length), News.NormalMessage[tmpNormal]);
        }
        NewsFeedFirst.text = Feed;

    }

    void Update()
    {
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
}
