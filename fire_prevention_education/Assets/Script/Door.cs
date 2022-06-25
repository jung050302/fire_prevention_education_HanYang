using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public string scenename;//�� �̸��� �Է��Ѵ�
    public bool buttonDown;//��ư ���� ����
    bool a = true;//�ݺ� ���� ����

    public GameObject text;
    public GameObject textBox;
    public GameObject nameText;
    public GameObject Player;
    
    void Start()
    {
        buttonDown = false;//���� ��ư�� ���� �ռ����� ì��ٸ� true�� �ٲ�
    }

    // Update is called once per frame
    void Update()
    {
        //a�� false�̰� ���콺 ���� ��ư�� �����ٸ� Player ������ Ȱ��ȭ��Ű�� TextBox ������Ʈ�� ��Ȱ��ȭ
        if (!a&&(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return)))
        {
            Player.SetActive(true);
            textBox.SetActive(false);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (a)
        {

            //���� �������� ì��� ���Թ��� �浹�� ������Ʈ�� Player�Ǵ�Player_1 ������Ʈ���
            if ((other.gameObject.name == "Player_1") && buttonDown)
            {
                SceneManager.LoadScene(scenename);//�Է��� ���� �ҷ��´�

            }
            //���� �������� ì�����ʰ� ���Թ��� �浹�� ������Ʈ�� Player ������Ʈ���
            else if (other.gameObject.name == "Player" && !buttonDown)
            {

                //Player ������Ʈ ��Ȱ��ȭ
                Player.SetActive(false);

                //�ؽ�Ʈâ�� Ȱ��ȭ
                textBox.SetActive(true);

                //�ؽ�Ʈâ�� Ȱ��ȭ ��Ű�� �ؽ��� ����Ѵ�
                nameText.GetComponent<Text>().text = "�����";
                text.GetComponent<Text>().text = "�ռ����� ������ �;���!";



            }
            a = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            a = true;


        }
    }
}
