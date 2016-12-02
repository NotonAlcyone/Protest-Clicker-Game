using UnityEngine;
using System.Collections;

public class ChickenButton : MonoBehaviour {

    public ChickenSystem Chicken;



    public void ChickenMineClicked()
    {
        if (Chicken.ChickenStack > Chicken.MinChickenStack)
        {
            Chicken.CurrentChickenStat += Chicken.ChickenStack;
            Chicken.ChickenStack = Chicken.MinChickenStack;
        }
    }
}
