using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hallway_game_Manager : MonoBehaviour
{
    //게임 메니저 스크립트들의 코드는 대부분 비슷함!

    public GameObject textBox;//Text옵젝
    public GameObject nametext;//nameText UI
    public GameObject text;//Text UI
    public GameObject player;

    public GameObject background;

    public bool TextOutput = false;//false 면 텍스트창을 활성화시킴 true 비활성화

    public bool a = false;//update 함수안에있는 else문을 한번만 실행 시키기위한 변수

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
        if (!TextOutput)//TextOutput이 false라면
        {
            textBox.SetActive(true);
            player.SetActive(false);
            nametext.GetComponent<Text>().text = "김안전";
            text.GetComponent<Text>().text = "이제 비상벨을 울려서 사람들에게 알려야 해!";
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
            //반복 제어 
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
    void Save(string a, bool b)//텍스트를 딱 한번만 출력하기위한 저장함수
    {
        PlayerPrefs.SetInt(a, System.Convert.ToInt16(b));
    }
    void Load(string a)//저장값을 불러오는 함수
    {
        TextOutput = System.Convert.ToBoolean(PlayerPrefs.GetInt(a));
    }
    void ClearAllSaveData()//데이터 삭제 함수
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
