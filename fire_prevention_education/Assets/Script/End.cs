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
        //���� Player������Ʈ�� fire �� �浹�ϸ� ���ӿ��� â�� Ȱ��ȭ��
        if (other.gameObject.name == "Player_1")
        {
            SceneManager.LoadScene("End");
        }

    }
}
