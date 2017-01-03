using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChickenButton : MonoBehaviour
{

    public ChickenSystem Chicken;



    public void ChickenMineClicked()
    {
        if (Chicken.stack > Chicken.minStack)
        {
            Chicken.currentStat += Chicken.stack;
            Chicken.stack = Chicken.minStack;
        }
    }
    public void Test()
    {
        SceneManager.LoadScene("Main");

    }
}
