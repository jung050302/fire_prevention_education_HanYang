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
        //��������Ʈ�� Player ������Ʈ�� �浹�ϸ� ���� �ҷ���
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("living_room");
        }
    }
}
