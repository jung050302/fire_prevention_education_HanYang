using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hallway2_GameManager : MonoBehaviour
{
    //���� �޴��� ��ũ��Ʈ���� �ڵ�� ��κ� �����!

    //�ؽ�Ʈ ���� ������Ʈ
    public GameObject TextBox;
    public GameObject TextUI;
    public GameObject NameText;
    public GameObject Player;
    void Start()
    {
        TextBox.SetActive(true);
        Player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        TextUI.GetComponent<Text>().text = "�ƾ�! ���Թ��� �ھ��̾�! ����� ���������� ��! ������ ������ ���� ������ �־� �����ؼ� ����������!\n(���⼭ ���ӿ����� �Ǹ� ó������ �ٽ� ���� �ϴ� �����ϰ� ����!)";
        NameText.GetComponent<Text>().text = "�����";
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Return))
        {
            TextBox.SetActive(false);
            Player.SetActive(true);
        }
    }
}
