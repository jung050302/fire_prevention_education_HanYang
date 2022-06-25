using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    //�ؽ�Ʈ ���� ������Ʈ
    public GameObject text;
    public GameObject TextUi;
    public GameObject nameText;
    public GameObject Player;
    //���̸� �Է�
    public string SceneName;
    
    public bool buttonDown;//��� ��ư ����
    bool a = true;//�ݺ��� �������� ���� ����
    void Start()
    {
        buttonDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!a&&(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return)))
        {
            Player.SetActive(true);
            text.SetActive(false);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (a)
        {
            //���� ��� ��ư�� �����ٸ���� �ε���
            if (other.gameObject.name == "Player_1" && buttonDown)
            {
                SceneManager.LoadScene(SceneName);

            }
            //��� ��ư�� ������ �ʾҴٸ� ����� �������Ѵٰ� �ؽ�Ʈ�� �����
            else if (other.gameObject.name == "Player_1" && !buttonDown)
            {

                
                Player.SetActive(false);
                
                
                text.SetActive(true);

                nameText.GetComponent<Text>().text = "�����";
                TextUi.GetComponent<Text>().text = "����� ��������!";



            }
            a = false;
        }
         
         
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player_1")
        {
            a = true;


        }
    }
}
