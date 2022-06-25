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
        //����Ű�� ĳ���͸� ������
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
        //���� Player������Ʈ�� fire �� �浹�ϸ� ���ӿ��� â�� Ȱ��ȭ��
        if (other.gameObject.name == "Fire"|| other.gameObject.name == "Fire1")
        {
            GameOver.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}
