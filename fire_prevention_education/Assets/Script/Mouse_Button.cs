using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject springboard;
    public GameObject Sound;
    public GameObject GameManager;
    public GameObject exit;
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
        //��ư�� ������ GameManager������Ʈ�� ������Ʈ�� �������ִ� hallway_game_Manager ��ũ��Ʈ �ȿ� �ִ� TextOutput������ false�� �ٲٰ�textprint��true�� �ٲٰ� textcount�� 1������Ŵ
        GameManager.GetComponent<hallway_game_Manager>().TextOutput = false;
        GameManager.GetComponent<hallway_game_Manager>().textprint = true;
        GameManager.GetComponent<hallway_game_Manager>().textcount++;
        //��ư�� ������ exit������Ʈ�� ������Ʈ�� ������ �ִ� Exit ��ũ��Ʈ �ȿ� �ִ� buttonDown ������ true�� �ٲ�
        exit.GetComponent<Exit>().buttonDown = true;
        springboard.GetComponent<Collision_interaction>().click = true;
        //sound ������Ʈ�� Ȱ��ȭ��Ű�鼭 ȭ�� ��� ���带 �����
        Sound.SetActive(true);
    }
}
