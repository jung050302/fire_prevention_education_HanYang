using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    //텍스트 관련 오브젝트
    public GameObject text;
    public GameObject TextUi;
    public GameObject nameText;
    public GameObject Player;
    //씬이름 입력
    public string SceneName;
    
    public bool buttonDown;//비상벨 버튼 감지
    bool a = true;//반복을 막기위한 제어 변수
    void Start()
    {
        buttonDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!a&&(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return)))
        {
            Player.SetActive(true);
            text.SetActive(false);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (a)
        {
            //만약 비상벨 버튼을 눌렀다면씬을 로드함
            if (other.gameObject.name == "Player_1" && buttonDown)
            {
                SceneManager.LoadScene(SceneName);

            }
            //비상벨 버튼을 누르지 않았다면 비상벨을 눌러야한다고 텍스트를 출력함
            else if (other.gameObject.name == "Player_1" && !buttonDown)
            {

                
                Player.SetActive(false);
                
                
                text.SetActive(true);

                nameText.GetComponent<Text>().text = "김안전";
                TextUi.GetComponent<Text>().text = "비상벨을 눌러야해!";



            }
            a = false;
        }
         
         
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player_1")
        {
            a = true;


        }
    }
}
