using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;

public class EncounterData
{
    public static string name;
    public static string description;
    public static string yesText;
    public static string noText;
    public static string checker;
}
public class EncounterAnswer
{
    public static Dictionary<string, bool> answerDict = new Dictionary<string, bool>();
}
public class EncounterSystem : MonoBehaviour {

    void Awake()
    {
        EncounterAnswer.answerDict.Clear();
        foreach (string doct in Json.dict["Encounter"].Keys)
        {
            EncounterAnswer.answerDict.Add(doct, false);
        }

    }

    public ChickenSystem Chicken;
    public JSON Json;
    public GameObject encounterPrefab;
    public GameObject canvas;

    public bool stage;
    public bool reki;

    public static int buttonPressed = 0;
    void open(string NameKey)
    {
        EncounterData.name = (string)Json.dict["Encounter"][NameKey];
        EncounterData.description = (string)Json.dict["Description"][NameKey];
        EncounterData.checker = NameKey;
        Instantiate(encounterPrefab, new Vector2(0, -250), Quaternion.identity, canvas.transform);

    }
    public void TestButton()
    {
        buttonPressed++;
    }
    void Update()
    {//if에 조건식
        if((stage != true) && (Chicken.currentStat > 1))
        {
            stage = true;
            open("Stage");

        }
        if((reki !=  true) && (buttonPressed > 10))
        {
            reki = true;
            open("Reki");
        }
    }
}
