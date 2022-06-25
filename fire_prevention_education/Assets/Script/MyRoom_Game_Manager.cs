using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class MyRoom_Game_Manager : MonoBehaviour
{
    //���� �޴��� ��ũ��Ʈ���� �ڵ�� ��κ� �����!


    public GameObject textBox;
    public GameObject nametext;
    string Name;//ĳ������ �̸�
    public GameObject smoke;
    string[] textarr = { "��... ���� �б��� ������ 7�ð� ���� ��� ���Ҵ� �� �ڽ�", "���� �Ѽ� �� ����?", "....", "...........", "��.... �̰� ���� ������?", "..��...�ݷ��ݷ�", "?!?", "��...����!!?!" ,"����������? W,A,S,D Ű�� �������� ��������!"};//�ؽ�Ʈ ����Ʈ
    int textcount;//�ؽ�Ʈ ī��Ʈ�� �����Ҷ����� �ٸ� �ؽ�Ʈ�� �����
    
    bool textprint = true;//true ��� Ŭ�������� �ؽ�Ʈ ��� false�� ������� ����

    public GameObject text;
    public GameObject player;

    public GameObject background;
    bool textOutput;
     
    void Start()
    {
        Load("textOutput");
        textOutput = false;
        Load("textOutput");
        textBox.SetActive(true);
        textcount = 0;
        text.GetComponent<Text>().text = textarr[textcount];

        player.SetActive(false);
        Name = "�����";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textOutput==false)
        {
            nametext.GetComponent<Text>().text = Name;


            if (textcount == textarr.Length - 1)
            {
                if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)
                {
                    textBox.SetActive(false);
                    player.SetActive(true);
                    textOutput = true;
                    Save("textOutput", textOutput);
                }

            }
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)//Ŭ���Ҷ����� ��ȭ�� �����
            {
                textcount++;
                text.GetComponent<Text>().text = textarr[textcount];

            }
            if (textcount == 2)
            {
                StartCoroutine(FadeOutStart());
                textprint = false;
            }
            if (textcount == 5)
            {
                StartCoroutine(FadeInStart());
                textprint = false;

                smoke.SetActive(true);
            }
             
        }
        else
        {
            textBox.SetActive(false);
            player.SetActive(true);
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
    void Save(string a,bool b)//�ؽ�Ʈ�� �� �ѹ��� ����ϱ����� �Լ�
    {
        PlayerPrefs.SetInt(a, System.Convert.ToInt16(b));
    }
    void Load(string a)//���尪�� �ҷ����� �Լ�
    {
        textOutput = System.Convert.ToBoolean(PlayerPrefs.GetInt(a));
    }
    void ClearAllSaveData()//������ ���� �Լ�
    {
        PlayerPrefs.DeleteAll();
    }
}
