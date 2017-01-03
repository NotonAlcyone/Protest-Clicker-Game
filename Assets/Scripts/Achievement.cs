using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{


    public Text achievementText;
    public Image achievementImage;
    public string tmpText;

    void Awake()
    {
        tmpText = AchievementData.achievement;
        achievementImage.sprite = Resources.Load<Sprite>("Image/Achievement/"+AchievementData.imageFileName);
    }
    void Start()
    {
        achievementText.text = tmpText;
        Destroy(this.gameObject, 5.0f);//생성후 5초후 삭제
    }
    
}
