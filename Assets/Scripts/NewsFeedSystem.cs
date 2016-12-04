using UnityEngine;
using System.Collections;
using System;

public class NewsFeedSystem : MonoBehaviour
{

    public UnityEngine.UI.Text NewsFeedFirst;

    public string Noton;


    public string Feed = "";
    public string HAKU = "        ";
    void Start()
    {

        NewsFeedFirst.fontSize = 30;

        InvokeRepeating("FeedMaker", 0.0f, 1.0f);

    }
    void FeedMaker()
    {
        Feed = Feed.Insert(Feed.Length, HAKU);
        Feed = Feed.Insert((Feed.Length), JsonLoad.File.NewsFeed.Feed1);
        NewsFeedFirst.text = Feed;
        Debug.Log(Feed);

    }
    void FeedDestroyer()
    {

        Feed = Feed.Remove(0, 16);
        Debug.Log(Feed);
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
