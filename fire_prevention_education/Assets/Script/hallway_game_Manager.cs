using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hallway_game_Manager : MonoBehaviour
{
    //게임 메니저 스크립트들의 코드는 대부분 비슷함!

    public GameObject textBox;//Text옵젝
    public GameObject nametext;//nameText UI
    string CharacterName;//캐릭터의 이름
     
    string[] textarr = { "이제 비상벨을 울려서 사람들에게 알려야 해!", "됐어! 이제 이 건물을 탈출해야 해!" };//텍스트 리스트
    public int textcount;//텍스트 카운트가 증가할때마다 다른 텍스트를 출력함
    public bool textprint = true;//true 라면 클릭했을때 텍스트 출력 false면 출력하지 않음

    public GameObject text;//Text UI
    public GameObject player;

    public GameObject background;

    public bool TextOutput = false;//false 면 텍스트창을 활성화시킴 true 비활성화

    public bool a = false;//update 함수안에있는 else문을 한번만 실행 시키기위한 변수
    void Start()
    {
        
        
         
        textBox.SetActive(true);
        textcount = 0;//textarr의 텍스트들을 순서대로 출력함
        text.GetComponent<Text>().text = textarr[textcount];//텍스트 오브젝트가 컴포턴트로 가지고있는 Text를 가져와서 Text값을 변경함

        player.SetActive(false);
        CharacterName = "김안전";
        

         
    }

    // Update is called once per frame
    void Update()
    {
        if (!TextOutput)//TextOutput이 false라면
        {
            //텍스트 창을 활성화 시킴
            nametext.GetComponent<Text>().text = CharacterName;
            textBox.SetActive(true);
            player.SetActive(false);
            
            if (textcount == textarr.Length )
            {
                //만약 출력할 텍스트가 없다면 텍스트창을 비활성화 시킴
                if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)
                {

                    TextOutput = true;
                    
                    textBox.SetActive(false);
                    player.SetActive(true);
                    a = false;
                }

            }
            else if ((Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && textprint)//클릭할때마다 대화를 출력함
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
            //반복 제어 
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
