using UnityEngine;
using System.Collections;

public class Crowd : MonoBehaviour {

    void OnTriggerStay2D(Collider2D collison)
    {
        Noton = false;
        //Debug.Log("I'M IN!");
    }
    void OnTriggerExit2D(Collider2D collison)
    {
        Noton = true;
       // Debug.Log("I'm out here!");
    }
    void OnTriggerEnter2D(Collider2D collison)
    {
        Noton = false;
        //Debug.Log("I'M GO IN!");     
    }

    public bool Noton;
    public bool On;
    public float Call;
    public float xMoveRand;
    public float yMoveRand;
	// Use this for initialization
	void Start () {

        Invoke("Movement",0.0f);

	}


    // Update is called once per frame
    void Update()
    {

        if (On == true)
        {
            if (Noton == true)
            {
                xMoveRand *= -1;
                yMoveRand *= -1;
            }
            transform.Translate(xMoveRand, yMoveRand, 0);
           
        }
        Debug.Log(On);
       
        // 랜덤시간마다 랜덤지점으로 이동
        // 스테이지가 일정시간만큼 남았을때 랜덤지점으로 가서 파괴
    }
    void Movement()
    {
        Debug.Log("Moving");
        xMoveRand = Random.Range(-3, 3); //동작 거리 랜덤
        yMoveRand = Random.Range(-3, 3);
        On = true;
        Call = Random.Range(1, 3);
        Invoke("MovementCancel", Call);
        Debug.Log("move will stop" + Call);
        //다음 동작까지 시간


        //Debug.Log("MoveTime" + Call + "RestTime" + Call/3);
        //Debug.Log(MoveRand);

        //휴식 시간
    }
    void MovementCancel()
    {
        On = false;
        Debug.Log("MoveStop");
        Invoke("Movement", Call*2);
    }
}
