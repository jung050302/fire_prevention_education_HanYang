using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MyRoom_Door : MonoBehaviour
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
        //문오브젝트와 Player 오브젝트가 충돌하면 씬을 불러옴
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("living_room");
        }
    }
}
