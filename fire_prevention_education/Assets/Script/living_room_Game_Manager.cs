using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class living_room_Game_Manager : MonoBehaviour
{
    //���� �޴��� ��ũ��Ʈ���� �ڵ�� ��κ� �����!

    public GameObject textBox;//Text����
    public GameObject nametext;//nameText UI
    string CharacterName;//ĳ������ �̸�
    public GameObject smoke; 
    string[] textarr = { "��...����!!!..��..���̴�!!!! ���̴�!!!!!!!!", "��¼��..... �׷�! ���� �б����� ȭ�� ���������� �����!! �켱 119�� ��ȭ�� �ؾ� ��", ".....","....", "�� 119�Դϴ� ������ ���͵帱���", "��! ���� ������̱��� ����� ������ ������ ��������Ʈ 102���ε��� ���� ȭ�簡 �߻��߽��ϴ�!", "�׷����� ���� ���� �������� �ҹ���е��� �����ڽ��ϴ� �켱 ������ ������ ������ �ּ���", "�� �˰ڽ��ϴ�.", "�Ű�� �߰� �״����� �б����� ��� ��ó�� ������ ���� ���ż� �ڿ� ���� ���� ���� �ڼ��� ������ ������ ��!" };//�ؽ�Ʈ ����Ʈ
    int textcount;//�ؽ�Ʈ ī��Ʈ�� �����Ҷ����� �ٸ� �ؽ�Ʈ�� �����
    bool textprint = true;//true ��� Ŭ�������� �ؽ�Ʈ ��� false�� ������� ����

    public GameObject text;//Text UI
    public GameObject player;

    public GameObject background;

    bool TextOutput = false;
    bool a = false;
    void Start()
    {
        Load("TextOutput");
        textBox.SetActive(true);
        textcount = 0;
        text.GetComponent<Text>().text = textarr[textcount];

        player.SetActive(false);
        CharacterName = "�����";
        
         
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!TextOutput)
        {
            nametext.GetComponent<Text>().text = CharacterName;


            if (textcount == textarr.Length - 1)
            {
                if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)
                {
                    TextOutput = true;
                    Save("TextOutput", TextOutput);
                    textBox.SetActive(false);
                    player.SetActive(true);
                }

            }
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)//Ŭ���Ҷ����� ��ȭ�� �����
            {
                textcount++;
                text.GetComponent<Text>().text = textarr[textcount];

            }
            
            if(textcount == 4||textcount == 6)
            {
                CharacterName = "119";
            }
            else
            {
                CharacterName = "�����";
            }
        }
        else
        {
            if (!a)
            {

                textBox.SetActive(false);
                player.SetActive(true);

            }
            a = true;
        }
             


         

    }
    void Save(string a, bool b)
    {
        PlayerPrefs.SetInt(a, System.Convert.ToInt16(b));
    }
    void Load(string a)
    {
        TextOutput = System.Convert.ToBoolean(PlayerPrefs.GetInt(a));
    }
    void ClearAllSaveData()
    {
        PlayerPrefs.DeleteAll();
    }
    IEnumerator FadeInStart()
    {

        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color c = background.GetComponent<SpriteRenderer>().color;
            c.a = f;
            background.GetComponent<SpriteRenderer>().color = c;
            yield return null;
        }
        textprint = true;
    }
    IEnumerator FadeOutStart()
    {

        for (float f = 1f; f > 0; f -= 0.01f)
        {
            Color c = background.GetComponent<SpriteRenderer>().color;
            c.a = f;
            background.GetComponent<SpriteRenderer>().color = c;
            yield return null;
        }
        yield return new WaitForSeconds(1);
        textprint = true;

    }
}
