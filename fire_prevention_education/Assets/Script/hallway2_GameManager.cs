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

    bool TextOutput;
    void Start()
    {
        
        Load("TextOutput_3");
        TextBox.SetActive(true);
        Player.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!TextOutput)
        {
            TextUI.GetComponent<Text>().text = "�ƾ�! ���Թ��� �ھ��̾�! ����� ���������� ��! ������ ������ ���� ������ �־� �����ؼ� ����������!\n(���⼭ ���ӿ����� �Ǹ� ó������ �ٽ� ���� �ϴ� �����ϰ� ����!)";
            NameText.GetComponent<Text>().text = "�����";
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return))
            {
                TextBox.SetActive(false);
                Player.SetActive(true);
                TextOutput = true;
                Save("TextOutput_3", TextOutput);
            }
        }
        else
        {
            Player.SetActive(true);
            TextBox.SetActive(false);
        }
    }
    void Save(string a, bool b)//�ؽ�Ʈ�� �� �ѹ��� ����ϱ����� �����Լ�
    {
        PlayerPrefs.SetInt(a, System.Convert.ToInt16(b));
    }
    void Load(string a)//���尪�� �ҷ����� �Լ�
    {
        TextOutput = System.Convert.ToBoolean(PlayerPrefs.GetInt(a));
    }
    void ClearAllSaveData()//������ ���� �Լ�
    {
        PlayerPrefs.DeleteAll();
    }
}
