using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //마약 Player오브젝트가 fire 와 충돌하면 게임오버 창을 활성화함
        if (other.gameObject.name == "Player_1")
        {
            SceneManager.LoadScene("End");
        }

    }
}
