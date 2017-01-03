using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{

    public JSON json;
    public ChickenSystem Chicken;
    public NewsFeedSystem News;

    public Text levelDisplayOne;
    public Text levelDisplayTwo;
    public Text levelDisplayThree;
    public Text levelDisplayFour;
    public Text levelDisplayFive;
    public Text levelDisplaySix;

    public int levelOne;
    public int priceOne;
    public int levelTwo;
    public int priceTwo;
    public int levelThree;
    public int priceThree;
    public int levelFour;
    public int priceFour;
    public int levelFive;
    public int priceFive;
    public int levelSix;
    public int priceSix;

   
    void Start()
    {
    }
    void Update()
    {
        levelDisplayOne.text = (string)json.dict["UI"]["Upgrade"] + levelOne;
        levelDisplayTwo.text = (string)json.dict["UI"]["Upgrade"] + levelTwo;
        levelDisplayThree.text = (string)json.dict["UI"]["Upgrade"] + levelThree;
        levelDisplayFour.text = (string)json.dict["UI"]["Upgrade"] + levelFour;
        levelDisplayFive.text = (string)json.dict["UI"]["Upgrade"] + levelFive;
        levelDisplaySix.text = (string)json.dict["UI"]["Upgrade"] + levelSix;
    }

    public void UpgradeClickOne()
    {
        if (Chicken.currentStat >= priceOne)
        {
            Chicken.currentStat -= priceOne;
            levelOne++;
            
        }

    }
    public void UpgradeClickTwo()
    {
        if (Chicken.currentStat >= priceTwo)
        {
            Chicken.currentStat -= priceTwo;
            levelTwo++;
            
        }

    }
    public void UpgradeClickThree()
    {
        if (Chicken.currentStat >= priceThree)
        {
            Chicken.currentStat -= priceThree;
            levelThree++;
            
        }

    }
    public void UpgradeClickFour()
    {
        if (Chicken.currentStat >= priceFour)
        {
            Chicken.currentStat -= priceFour;
            levelFour++;
            
        }

    }
    public void UpgradeClickFive()
    {
        if (Chicken.currentStat >= priceFive)
        {
            Chicken.currentStat -= priceFive;
            levelFive++;
            
        }

    }
    public void UpgradeClickSix()
    {
        if (Chicken.currentStat >= priceSix)
        {
            Chicken.currentStat -= priceSix;
            levelSix++;
            
        }

    }

}
