using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public string scenename;//씬 이름을 입력한다
    public bool buttonDown;//버튼 눌름 감지
    bool a = true;//반복 제어 변수

    public GameObject text;
    public GameObject textBox;
    public GameObject nameText;
    public GameObject Player;
    
    void Start()
    {
        buttonDown = false;//만약 버튼을 눌러 손수건을 챙겼다면 true로 바뀜
    }

    // Update is called once per frame
    void Update()
    {
        //a가 false이고 마우스 왼쪽 버튼을 눌렀다면 Player 옵젝을 활성화시키고 TextBox 오브젝트를 비활성화
        if (!a&&(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return)))
        {
            Player.SetActive(true);
            textBox.SetActive(false);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (a)
        {

            //만약 물수건을 챙겼고 출입문과 충돌한 오브젝트가 Player또는Player_1 오브젝트라면
            if ((other.gameObject.name == "Player_1") && buttonDown)
            {
                SceneManager.LoadScene(scenename);//입력한 씬을 불러온다

            }
            //만약 물수건을 챙기지않고 출입문과 충돌한 오브젝트가 Player 오브젝트라면
            else if (other.gameObject.name == "Player" && !buttonDown)
            {

                //Player 오브젝트 비활성화
                Player.SetActive(false);

                //텍스트창을 활성화
                textBox.SetActive(true);

                //텍스트창을 활성화 시키고 텍스를 출력한다
                nameText.GetComponent<Text>().text = "김안전";
                text.GetComponent<Text>().text = "손수건을 가지고 와야해!";



            }
            a = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            a = true;


        }
    }
}
