using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class living_room_Game_Manager : MonoBehaviour
{
    //게임 메니저 스크립트들의 코드는 대부분 비슷함!

    public GameObject textBox;//Text옵젝
    public GameObject nametext;//nameText UI
    string CharacterName;//캐릭터의 이름
    public GameObject smoke; 
    string[] textarr = { "뭐...뭐야!!!..부..불이다!!!! 불이다!!!!!!!!", "어쩌지..... 그래! 오늘 학교에서 화재 안전교육을 배웠지!! 우선 119에 전화를 해야 해", ".....","....", "네 119입니다 무엇을 도와드릴까요", "네! 저는 김안전이구요 여기는 안전시 안전동 안전아파트 102동인데요 여기 화재가 발생했습니다!", "그렇군요 지금 당장 그쪽으로 소방관분들을 보내겠습니다 우선 안전한 곳으로 대피해 주세요", "네 알겠습니다.", "신고는 했고 그다음은 학교에서 배운 것처럼 수건을 물에 적셔서 코와 입을 막고 낮은 자세로 밖으로 나가야 해!" };//텍스트 리스트
    int textcount;//텍스트 카운트가 증가할때마다 다른 텍스트를 출력함
    bool textprint = true;//true 라면 클릭했을때 텍스트 출력 false면 출력하지 않음

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
        CharacterName = "김안전";
        
         
        
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
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)//클릭할때마다 대화를 출력함
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
                CharacterName = "김안전";
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
