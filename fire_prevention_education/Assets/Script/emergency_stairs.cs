using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class emergency_stairs : MonoBehaviour
{
    public string sceneName;//���̸� �Է�
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Player_1������Ʈ�� �ⱸ�� �浹�ߴٸ� ���� �ε���
        if (other.gameObject.name == "Player_1")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
