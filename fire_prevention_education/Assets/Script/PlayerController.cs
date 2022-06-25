using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    
    public float speed = 2.5f;
    
    public GameObject GameOver;
    public GameObject Player;
    public GameObject Player2;
    void Start()
    {
        Player2.transform.position = Player.transform.position;


    }


    void Update()
    {

        
        float moveY = 0f;
        float moveX = 0f;
        //방향키로 캐릭터를 조종함
        if (Input.GetKey(KeyCode.W))
        {
            moveY += 7f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveY -= 7f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX -= 7f * Time.deltaTime;
            
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX += 7f * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
        }
     
        transform.Translate(new Vector3(moveX, moveY, 0f) );
     


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //마약 Player오브젝트가 fire 와 충돌하면 게임오버 창을 활성화함
        if (other.gameObject.name == "Fire"|| other.gameObject.name == "Fire1")
        {
            GameOver.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}
