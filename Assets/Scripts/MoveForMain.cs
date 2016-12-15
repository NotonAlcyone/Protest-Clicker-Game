using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;

public class MoveForMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Started");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Campaign()
    {
        Debug.Log("Pressed");
        SceneManager.LoadScene("GameScene");
    }
    public void Achievement()
    {
        Debug.Log("Achievement");
        
    }
    public void Credit()
    {

    }
    public void Click()
    {
        File.Delete(Application.dataPath + "/Save.json");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
