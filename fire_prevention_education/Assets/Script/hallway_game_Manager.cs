using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hallway_game_Manager : MonoBehaviour
{
    //���� �޴��� ��ũ��Ʈ���� �ڵ�� ��κ� �����!

    public GameObject textBox;//Text����
    public GameObject nametext;//nameText UI
    string CharacterName;//ĳ������ �̸�
     
    string[] textarr = { "���� ����� ����� ����鿡�� �˷��� ��!", "�ƾ�! ���� �� �ǹ��� Ż���ؾ� ��!" };//�ؽ�Ʈ ����Ʈ
    public int textcount;//�ؽ�Ʈ ī��Ʈ�� �����Ҷ����� �ٸ� �ؽ�Ʈ�� �����
    public bool textprint = true;//true ��� Ŭ�������� �ؽ�Ʈ ��� false�� ������� ����

    public GameObject text;//Text UI
    public GameObject player;

    public GameObject background;

    public bool TextOutput = false;//false �� �ؽ�Ʈâ�� Ȱ��ȭ��Ŵ true ��Ȱ��ȭ

    public bool a = false;//update �Լ��ȿ��ִ� else���� �ѹ��� ���� ��Ű������ ����
    void Start()
    {
        
        
         
        textBox.SetActive(true);
        textcount = 0;//textarr�� �ؽ�Ʈ���� ������� �����
        text.GetComponent<Text>().text = textarr[textcount];//�ؽ�Ʈ ������Ʈ�� ������Ʈ�� �������ִ� Text�� �����ͼ� Text���� ������

        player.SetActive(false);
        CharacterName = "�����";
        

         
    }

    // Update is called once per frame
    void Update()
    {
        if (!TextOutput)//TextOutput�� false���
        {
            //�ؽ�Ʈ â�� Ȱ��ȭ ��Ŵ
            nametext.GetComponent<Text>().text = CharacterName;
            textBox.SetActive(true);
            player.SetActive(false);
            
            if (textcount == textarr.Length )
            {
                //���� ����� �ؽ�Ʈ�� ���ٸ� �ؽ�Ʈâ�� ��Ȱ��ȭ ��Ŵ
                if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)
                {

                    TextOutput = true;
                    
                    textBox.SetActive(false);
                    player.SetActive(true);
                    a = false;
                }

            }
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)//Ŭ���Ҷ����� ��ȭ�� �����
            {
                textcount++;
                text.GetComponent<Text>().text = textarr[textcount];

            }
            if (textcount == 1)
            {
                
                 
                textprint = false;
                TextOutput = true;
                a = false;
            }
            
             
        }
        else
        {
            //�ݺ� ���� 
            if (!a)
            {
                 
                textBox.SetActive(false);
                player.SetActive(true);
                 
            }
            a = true;
             
        }





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
