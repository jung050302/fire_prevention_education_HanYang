using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStart_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneName;//�������� �Է�
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
        
        //���� ����â���ִ� �ٽ� ���� ��ư�� ������ �Է��� ������ �̵���
        SceneManager.LoadScene(SceneName);
    }
}
