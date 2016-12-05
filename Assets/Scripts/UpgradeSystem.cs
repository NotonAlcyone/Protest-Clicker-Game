using UnityEngine;
using System.Collections;

public class UpgradeSystem : MonoBehaviour
{


    public ChickenSystem Chicken;
    public NewsFeedSystem News;
    public UnityEngine.UI.Text LevelDisplay;
    public int UpgradeLevel;
    public int UpgradePrice;


    void Start()
    {
        UpgradeLevel = 1; // default upgarde level is 1
        UpgradePrice = 1;
    }
    void Update()
    {
        LevelDisplay.text = JsonLoad.File.UI.Upgrade + UpgradeLevel;
    }

    public void UpgradeClick()
    {
        if (Chicken.CurrentStat >= UpgradePrice)
        {
            Chicken.CurrentStat -= UpgradePrice;
            UpgradeLevel++;
            News.PeaceStat = false;
        }

    }

}
