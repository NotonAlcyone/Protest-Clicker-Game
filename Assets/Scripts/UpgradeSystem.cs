using UnityEngine;
using System.Collections;

public class UpgradeSystem : MonoBehaviour {


    public ChickenSystem Chicken;
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
        LevelDisplay.text = "Current_level: " + UpgradeLevel;
    }
    public void UpgradeClick()
    {
        if (Chicken.CurrentChickenStat >= UpgradePrice)
        {
            Chicken.CurrentChickenStat -= UpgradePrice;
            UpgradeLevel++;
        }

    }

}
