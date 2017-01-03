using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ForText : MonoBehaviour {

    public Text TT;

    // Use this for initialization
    void Start () {

        TT.text = INFO.Name;
        Debug.Log("I Am Alive" + INFO.Name);
        Destroy(this.gameObject,3.0f);
	}
	
}
