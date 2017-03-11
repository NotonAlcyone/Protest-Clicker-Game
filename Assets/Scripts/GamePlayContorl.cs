using UnityEngine;
using System.Collections;
public class CrowdData
{
    public static int currentCrowd = 0;
}
public class GamePlayContorl : MonoBehaviour
{
    public GameObject crowdPrefab;
    public GameObject canvas;
    public int maxCrowd;
    public int spawnZoneRand;

    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        maxCrowd = 4;
        CrowdContorl();
    }

    void CrowdContorl()
    {
        if (CrowdData.currentCrowd < maxCrowd)
        {
            Instantiate(crowdPrefab, new Vector2(0, 0), Quaternion.identity, canvas.transform);
            CrowdData.currentCrowd++;
        }
    }
}
