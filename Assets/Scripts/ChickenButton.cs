using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChickenButton : MonoBehaviour
{

    public ChickenSystem Chicken;



    public void ChickenMineClicked()
    {
        if (Chicken.Stack > Chicken.MinStack)
        {
            Chicken.CurrentStat += Chicken.Stack;
            Chicken.Stack = Chicken.MinStack;
        }
    }
    public void Test()
    {
        SceneManager.LoadScene("Main");

    }
}
