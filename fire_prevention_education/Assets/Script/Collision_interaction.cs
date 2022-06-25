using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_interaction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mouseButton;//마우스 모양 이미지 게임 오브젝트
    public bool click = false;//버튼을 눌렀는지 감지
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (click)
        {
            mouseButton.SetActive(!true);//만약 버튼을 누르면 버튼을 계속 비활성화
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!click&& (other.gameObject.name == "Player" || other.gameObject.name == "Player_1"))
        {
            mouseButton.SetActive(true);//만약 캐릭터가 특정 구역에 서있다면 버튼을 활성화함
            
        }
        


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!click && (other.gameObject.name == "Player"|| other.gameObject.name == "Player_1"))
        {
            mouseButton.SetActive(false); //만약 캐릭터가 특정 구역에 서있지 않다면 버튼을 비활성화함


        }
    }
     
}
