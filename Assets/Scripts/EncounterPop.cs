﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using LitJson;

[System.Serializable]
public class EncounterPop : MonoBehaviour
{
    public NewsFeedSystem News;
    public ChickenSystem Chicken;
    public Main main;
    public EncounterSystem Encounter;
    public JSON json;
    public Image EncounterImage;
    public Image YES;
    public Image NO;
    public Text YEStext;
    public Text NOtext;
    public Text EncounterText;
    public Text Description;
    public string Checker;
    void popup()
    {
        EncounterText.enabled = true;
        EncounterImage.enabled = true;
        YES.enabled = true;
        YEStext.enabled = true;
        NO.enabled = true;
        NOtext.enabled = true;
        Description.enabled = true;
    } //이하 오브젝트 표시
    void close()
    {
        EncounterText.enabled = false;
        EncounterImage.enabled = false;
        YES.enabled = false;
        YEStext.enabled = false;
        NO.enabled = false;
        NOtext.enabled = false;
        Description.enabled = false;
    } //이하 오브젝트 비표시

    void Awake()
    {
        close();
        /*
        Debug.Log(json.dict.Keys);      
        foreach (JsonData elem in json.dict)
        {
            Debug.Log(elem.Keys);
        }
        */
    }
    void Start()
    {
        /*
        Debug.Log(json.dict["UI"].Keys);
        Debug.Log(json.dict.Keys.GetType());
        Debug.Log(json.dict.Keys);
        foreach (string dict in json.dict["UI"].Keys)   
        {
            Debug.Log(dict);
        }
        foreach(string doct in json.dict.Keys)
        {
            Debug.Log(doct);
        }
        Debug.Log(json.dict["NewsFeed"]["NormalMessage"].Count);
        */
    }
    void Update()
    {
        if (Encounter.stage == false && Chicken.currentStat > 1) 
        {
            open("Encounter","Stage","Description", "Stage"); 

            Encounter.stage = true;
        }
    }
    void open(string Messagekey, string Messagekey2,string ssulkey,string ssulkey2)
    {
        EncounterText.text = (string) json.dict[Messagekey][Messagekey2];
        Description.text = (string)json.dict[ssulkey][ssulkey2];
        Checker = "Encounter_" + Messagekey2;
        popup();

    }
    public void Yes()
    {  
        close();
        main.SaveData[Checker] = true;

    }
    public void No()
    {
        close();
        main.SaveData[Checker] = false;
    }
}
