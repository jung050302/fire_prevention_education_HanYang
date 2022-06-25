using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class emergency_stairs : MonoBehaviour
{
    public string sceneName;//씬이름 입력
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Player_1오브젝트와 출구가 충돌했다면 씬을 로드함
        if (other.gameObject.name == "Player_1")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
