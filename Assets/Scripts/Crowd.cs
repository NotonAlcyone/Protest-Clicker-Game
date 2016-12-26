using UnityEngine;
using System.Collections;

public class Crowd : MonoBehaviour {

    public float speed = 0.2f;
    public float CallTime = 1f;
    public bool On = false;
	// Use this for initialization
	void Start () {

        Invoke("Movement",0.0f);

	}
	
	// Update is called once per frame
	void Update () {
	// 랜덤시간마다 랜덤지점으로 이동
    // 스테이지가 일정시간만큼 남았을때 랜덤지점으로 가서 파괴
    

	}
    void Movement()
    {
        On = true;
        float Call = Random.Range(5, 20);

        //Invoke();
        Invoke("MoveMent", Call);
    }
    void FalseMaker()
    {
        On = false;
    }


}
