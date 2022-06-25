using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hallway2_GameManager : MonoBehaviour
{
    //게임 메니저 스크립트들의 코드는 대부분 비슷함!

    //텍스트 관련 오브젝트
    public GameObject TextBox;
    public GameObject TextUI;
    public GameObject NameText;
    public GameObject Player;
    void Start()
    {
        TextBox.SetActive(true);
        Player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        TextUI.GetComponent<Text>().text = "됐어! 출입문이 코앞이야! 저기로 빠져나가야 해! 하지만 문에서 불이 나오고 있어 조심해서 빠져나가자!\n(여기서 게임오버가 되면 처음부터 다시 깨야 하니 신중하게 하자!)";
        NameText.GetComponent<Text>().text = "김안전";
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Return))
        {
            TextBox.SetActive(false);
            Player.SetActive(true);
        }
    }
}
