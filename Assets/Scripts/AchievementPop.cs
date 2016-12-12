using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class AchievementPop : MonoBehaviour {

    public AchievementSystem Achievement;
    public ChickenSystem Chicken;
    public Image POP;
    public Text State;
    void Awake()
    {
        POP.enabled = false;
        State.enabled = false;
    }
    // Update is called once per frame
    void Update() {
        
        if (Achievement.ChickenEVERYWHERE == false && Chicken.CurrentStat >= 1)
        {
            Open(JsonLoad.File.Achievement.ChickenEVERYWHERE);
            Achievement.ChickenEVERYWHERE = true; // 외부 파일로 저장하게 할것
        }
    }
    void Open(string Message)
    {
        POP.enabled = true;
        State.enabled = true;
        State.text = Message;
        Invoke("Close", 5.0f);
    }
    void Close()
    {
        POP.enabled = false;
        State.enabled = false;
    }
}
