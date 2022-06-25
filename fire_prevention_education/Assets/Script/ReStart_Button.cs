using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStart_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneName;//씬네임을 입력
    public GameObject Fire;
    void Start()
    {
        Fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void button()
    {
        
        //게임 오버창에있는 다시 시작 버튼을 누르면 입력한 씬으로 이동함
        SceneManager.LoadScene(SceneName);
    }
}
