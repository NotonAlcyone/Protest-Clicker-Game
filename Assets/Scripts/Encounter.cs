using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Encounter : MonoBehaviour {

    public string tmpName;
    public string tmpDescription;
    public string tmpChecker;

    public Text description;
    public Text nameText;
    public Text yesText;
    public Text noText;
	// Use this for initialization
	void Start () {

        tmpDescription = EncounterData.description;
        tmpName = EncounterData.name;
        tmpChecker = EncounterData.checker;

        nameText.text = tmpName;
        description.text = tmpDescription;

        Invoke("Destroy",5.0f);
	}
    void Destroy()
    {
        EncounterAnswer.answerDict[tmpChecker] = false;
        Destroy(this.gameObject);
    }
    public void YesClicked()
    {
        EncounterAnswer.answerDict[tmpChecker] = true;
        Destroy(this.gameObject);
    }
    public void NoClicked()
    {
        EncounterAnswer.answerDict[tmpChecker] = false;
        Destroy(this.gameObject);
    }

}
