using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class AchievementPop : MonoBehaviour {

    public AchievementSystem Achievement;
    public ChickenSystem Chicken;
    public Image POP;
    public JSON json;
    public Text State;
    void Awake()
    {
        POP.enabled = false;
        State.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (Achievement.chickenEverywhere == false && Chicken.currentStat >= 1)
        {
            Open("Achievement", "ChickenEVERYWHERE", Achievement.chickenEverywhere);
            Achievement.chickenEverywhere = true; // 외부 파일로 저장하게 할것
        }
    }
    void Open(string Messagekey1, string Messagekey2, bool Stat)
    {
        POP.enabled = true;
        State.enabled = true;
        State.text = (string)json.dict[Messagekey1][Messagekey2];
        PlayerPrefs.SetInt(Messagekey1 + "_" + Messagekey2, Changer(Stat));
        Invoke("Close", 5.0f);
    }
    void Close()
    {
        POP.enabled = false;
        State.enabled = false;
    }


    int Changer(bool Change) //bool 타입을 int로 교체
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
    void IntSave(string Name, int Number)
    {
        PlayerPrefs.SetInt("Achievement_ChickenEVERYWHERE",Changer(Achievement.chickenEverywhere));
    }


}
