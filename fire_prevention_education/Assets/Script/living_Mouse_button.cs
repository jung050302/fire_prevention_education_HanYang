using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class living_Mouse_button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject springboard;//springboard 오브젝트를 불러옴
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
        //버튼을 누르면 door오브젝트가 컴포넌트로 가지고있는 Door스크립트 안에 있는 buttonDown변수를 true로 바꿈
        door.GetComponent<Door>().buttonDown = true;
        Player.SetActive(false);
        Player2.SetActive(true);
        //만약 버튼을 누르면 springboard오브젝트가 컴포넌트로 가지고있는 Collision_interaction.cs 스크립트 안에있는 click 변수를 true로 바꿈
        springboard.GetComponent<Collision_interaction>().click = true;
        
    }
}
