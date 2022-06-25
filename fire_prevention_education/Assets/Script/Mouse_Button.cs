using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mouse_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject springboard;
    public GameObject Sound;
    public GameObject GameManager;
    public GameObject exit;

    public GameObject TextBox;
    public GameObject TextUI;
    public GameObject NameUi;
    public GameObject Player;

    
    void Start()
    {
        gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void ClickButton()
    {
        //버튼을 누르면 GameManager오브젝트가 컴포넌트로 가지고있는 hallway_game_Manager 스크립트 안에 있는 TextOutput변수를 false로 바꾸고textprint를true로 바꾸고 textcount를 1증가시킴
        //GameManager.GetComponent<hallway_game_Manager>().TextOutput = false;
        //GameManager.GetComponent<hallway_game_Manager>().textprint = true;
        //GameManager.GetComponent<hallway_game_Manager>().textcount++;
        
        TextBox.SetActive(true);
        Player.SetActive(false);
        NameUi.GetComponent<Text>().text = "김안전";
        TextUI.GetComponent<Text>().text = "됐어! 이제 이 건물을 탈출해야 해!";
         

        //버튼을 누르면 exit오브젝트가 컴포넌트로 가지고 있는 Exit 스크립트 안에 있는 buttonDown 변수를 true로 바꿈
        exit.GetComponent<Exit>().buttonDown = true;
        springboard.GetComponent<Collision_interaction>().click = true;
        //sound 오브젝트를 활성화시키면서 화제 비상벨 사운드를 출력함
        Sound.SetActive(true);
         
        
    }
}
