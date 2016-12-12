using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class EncounterPop : MonoBehaviour
{
    public NewsFeedSystem News;
    public ChickenSystem Chicken;
    public EncounterSystem Encounter;
    public Image EncounterImage;
    public Image YES;
    public Image NO;
    public Text YEStext;
    public Text NOtext;
    public Text EncounterText;
    public Text Description;

    void popup()
    {
        EncounterText.enabled = true;
        EncounterImage.enabled = true;
        YES.enabled = true;
        YEStext.enabled = true;
        NO.enabled = true;
        NOtext.enabled = true;
        Description.enabled = true;
    }
    void close()
    {
        EncounterText.enabled = false;
        EncounterImage.enabled = false;
        YES.enabled = false;
        YEStext.enabled = false;
        NO.enabled = false;
        NOtext.enabled = false;
        Description.enabled = false;
    }

    void Awake()
    {
        close();
    }
    void Update()
    {
        if (Encounter.Stage == false && Chicken.CurrentStat > 1)
        {
            open(JsonLoad.File.Encounter.Stage,JsonLoad.File.EncounterDescription.StageDescription);
            Encounter.Stage = true;
        }
    }

    void open(string Message,string ssul)
    {
        EncounterText.text = Message;
        Description.text = ssul;
        popup();

    }
    public void Yes()
    {
        close();
    }
    public void No()
    {
        close();
    }

}
