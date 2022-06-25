using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hallway_game_Manager : MonoBehaviour
{
    //���� �޴��� ��ũ��Ʈ���� �ڵ�� ��κ� �����!

    public GameObject textBox;//Text����
    public GameObject nametext;//nameText UI
    public GameObject text;//Text UI
    public GameObject player;

    public GameObject background;

    public bool TextOutput = false;//false �� �ؽ�Ʈâ�� Ȱ��ȭ��Ŵ true ��Ȱ��ȭ

    public bool a = false;//update �Լ��ȿ��ִ� else���� �ѹ��� ���� ��Ű������ ����

    public GameObject GameOverFire;
    public GameObject GameOverElevator;
    public GameObject Sound;
    void Start()
    {


        
        textBox.SetActive(true);
        
        

        player.SetActive(false);
        
        Load("TextOutput_2");



    }

    // Update is called once per frame
    void Update()
    {
        if (!TextOutput)//TextOutput�� false���
        {
            textBox.SetActive(true);
            player.SetActive(false);
            nametext.GetComponent<Text>().text = "�����";
            text.GetComponent<Text>().text = "���� ����� ����� ����鿡�� �˷��� ��!";
            if (Input.GetMouseButtonDown(0))
            {
                textBox.SetActive(false);
                player.SetActive(true);
                TextOutput = true;
                Save("TextOutput_2", TextOutput);
                a = true;
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
        if (GameOverElevator.activeSelf == true)
        {
            Sound.SetActive(false);
        }
        if (GameOverFire.activeSelf == true)
        {
            Sound.SetActive(false);
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
    IEnumerator FadeInStart()
    {

        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color c = background.GetComponent<SpriteRenderer>().color;
            c.a = f;
            background.GetComponent<SpriteRenderer>().color = c;
            yield return null;
        }
        
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
        

    }
}
