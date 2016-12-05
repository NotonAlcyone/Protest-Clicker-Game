using UnityEngine;
using System.Collections;

public class ChickenButton : MonoBehaviour
{

    public ChickenSystem Chicken;



    public void ChickenMineClicked()
    {
        if (Chicken.Stack > Chicken.MinChickenStack)
        {
            Chicken.CurrentStat += Chicken.Stack;
            Chicken.Stack = Chicken.MinChickenStack;
        }
    }
}
