using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneName;
    
    void Start()
    {
        ClearAllSaveData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void button()
    {
        //���� ��ư�� ������ ���� �ε���
        SceneManager.LoadScene(SceneName);
    }
    void ClearAllSaveData()
    {
        PlayerPrefs.DeleteAll();
    }
}
