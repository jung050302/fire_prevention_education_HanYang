using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class MyRoom_Game_Manager : MonoBehaviour
{
    //게임 메니저 스크립트들의 코드는 대부분 비슷함!


    public GameObject textBox;
    public GameObject nametext;
    string Name;//캐릭터의 이름
    public GameObject smoke;
    string[] textarr = { "휴... 드디어 학교가 끝났다 7시간 동안 고생 많았다 나 자신", "이제 한숨 자 볼까?", "....", "...........", "음.... 이게 무슨 냄새지?", "..음...콜록콜록", "?!?", "뭐...뭐야!!?!" ,"무슨일이지? W,A,S,D 키로 움직여서 나가보자!"};//텍스트 리스트
    int textcount;//텍스트 카운트가 증가할때마다 다른 텍스트를 출력함
    
    bool textprint = true;//true 라면 클릭했을때 텍스트 출력 false면 출력하지 않음

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
        Name = "김안전";
        
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
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)//클릭할때마다 대화를 출력함
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
    void Save(string a,bool b)//텍스트를 딱 한번만 출력하기위한 함수
    {
        PlayerPrefs.SetInt(a, System.Convert.ToInt16(b));
    }
    void Load(string a)//저장값을 불러오는 함수
    {
        textOutput = System.Convert.ToBoolean(PlayerPrefs.GetInt(a));
    }
    void ClearAllSaveData()//데이터 삭제 함수
    {
        PlayerPrefs.DeleteAll();
    }
}
