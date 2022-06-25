using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject elevator;
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //만약 엘레베이터 오브젝트와 Player_1오브젝트가 충돌 한다면
        if (other.gameObject.name == "Player_1")
        {
            //게임 오버 창을 활성화 하고 Player오브젝트를 비활성호 시킨다
            elevator.SetActive(true);
            Player.SetActive(false);
        }

    }
}
