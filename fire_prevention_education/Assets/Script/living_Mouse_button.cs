using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class living_Mouse_button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject springboard;//springboard ������Ʈ�� �ҷ���
    public GameObject Player;
    public GameObject Player2;
    public GameObject door;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
     
    public void ButtonDown()
    {
        //��ư�� ������ door������Ʈ�� ������Ʈ�� �������ִ� Door��ũ��Ʈ �ȿ� �ִ� buttonDown������ true�� �ٲ�
        door.GetComponent<Door>().buttonDown = true;
        Player.SetActive(false);
        Player2.SetActive(true);
        //���� ��ư�� ������ springboard������Ʈ�� ������Ʈ�� �������ִ� Collision_interaction.cs ��ũ��Ʈ �ȿ��ִ� click ������ true�� �ٲ�
        springboard.GetComponent<Collision_interaction>().click = true;
        
    }
}
