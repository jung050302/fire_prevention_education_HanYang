using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_interaction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mouseButton;//���콺 ��� �̹��� ���� ������Ʈ
    public bool click = false;//��ư�� �������� ����

    public GameObject Player;
    public GameObject TextBox;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (click)
        {
            mouseButton.SetActive(false);//���� ��ư�� ������ ��ư�� ��� ��Ȱ��ȭ
            if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return)))
            {
                Player.SetActive(true);
                TextBox.SetActive(false);

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!click&& (other.gameObject.name == "Player" || other.gameObject.name == "Player_1"))
        {
            mouseButton.SetActive(true);//���� ĳ���Ͱ� Ư�� ������ ���ִٸ� ��ư�� Ȱ��ȭ��
            
        }
        


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!click && (other.gameObject.name == "Player"|| other.gameObject.name == "Player_1"))
        {
            mouseButton.SetActive(false); //���� ĳ���Ͱ� Ư�� ������ ������ �ʴٸ� ��ư�� ��Ȱ��ȭ��


        }
    }
     
}
