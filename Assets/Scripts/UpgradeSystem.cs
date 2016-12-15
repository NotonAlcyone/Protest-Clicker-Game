using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{

    public JSON json;
    public ChickenSystem Chicken;
    public NewsFeedSystem News;

    public Text LevelDisplayOne;
    public Text LevelDisplayTwo;
    public Text LevelDisplayThree;
    public Text LevelDisplayFour;
    public Text LevelDisplayFive;
    public Text LevelDisplaySix;

    public int LevelOne;
    public int PriceOne;
    public int LevelTwo;
    public int PriceTwo;
    public int LevelThree;
    public int PriceThree;
    public int LevelFour;
    public int PriceFour;
    public int LevelFive;
    public int PriceFive;
    public int LevelSix;
    public int PriceSix;

   
    void Start()
    {
    }
    void Update()
    {
        LevelDisplayOne.text = (string)json.dict["UI"]["Upgrade"] + LevelOne;
        LevelDisplayTwo.text = (string)json.dict["UI"]["Upgrade"] + LevelTwo;
        LevelDisplayThree.text = (string)json.dict["UI"]["Upgrade"] + LevelThree;
        LevelDisplayFour.text = (string)json.dict["UI"]["Upgrade"] + LevelFour;
        LevelDisplayFive.text = (string)json.dict["UI"]["Upgrade"] + LevelFive;
        LevelDisplaySix.text = (string)json.dict["UI"]["Upgrade"] + LevelSix;
    }

    public void UpgradeClickOne()
    {
        if (Chicken.CurrentStat >= PriceOne)
        {
            Chicken.CurrentStat -= PriceOne;
            LevelOne++;
            
        }

    }
    public void UpgradeClickTwo()
    {
        if (Chicken.CurrentStat >= PriceTwo)
        {
            Chicken.CurrentStat -= PriceTwo;
            LevelTwo++;
            
        }

    }
    public void UpgradeClickThree()
    {
        if (Chicken.CurrentStat >= PriceThree)
        {
            Chicken.CurrentStat -= PriceThree;
            LevelThree++;
            
        }

    }
    public void UpgradeClickFour()
    {
        if (Chicken.CurrentStat >= PriceFour)
        {
            Chicken.CurrentStat -= PriceFour;
            LevelFour++;
            
        }

    }
    public void UpgradeClickFive()
    {
        if (Chicken.CurrentStat >= PriceFive)
        {
            Chicken.CurrentStat -= PriceFive;
            LevelFive++;
            
        }

    }
    public void UpgradeClickSix()
    {
        if (Chicken.CurrentStat >= PriceSix)
        {
            Chicken.CurrentStat -= PriceSix;
            LevelSix++;
            
        }

    }

}
