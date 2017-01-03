using UnityEngine;
using System.Collections;

public class Crowd : MonoBehaviour {

    void OnTriggerStay2D(Collider2D collision)
    {
        Noton = true;
        Debug.Log("I'M IN!");
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("I'M GO OUT");
        Destroy(People);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I'M GO IN!");
        
    }

    public bool Noton = true;
    public float speed = 0.2f;
    public float CallTime = 1f;
    public float Test = 1;
    public bool On = false;
    public GameObject People;
	// Use this for initialization
	void Start () {

        Invoke("Movement",0.0f);

	}

    // Update is called once per frame
    void Update()
    {

        

        if (Noton == false)
        {
          
        }
        transform.Translate(Test, 0, 0);
       
        // 랜덤시간마다 랜덤지점으로 이동
        // 스테이지가 일정시간만큼 남았을때 랜덤지점으로 가서 파괴


    }
    void Movement()
    {
        On = true;
        float Call = Random.Range(2, 10); //다음 동작까지 시간
        int MoveRand = Random.Range(1,20); //동작 거리 랜덤
        //Debug.Log("MoveTime" + Call + "RestTime" + Call/3);
        //Debug.Log(MoveRand);

        Invoke("Movement", Call);
        Invoke("MovementCancel", Call / 3); //휴식 시간
    }
    void MovementCancel()
    {
        On = false;
       // Debug.Log("MoveStop");
    }
   


}
