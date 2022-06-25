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
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void button()
    {
        //시작 버튼을 누르면 씬을 로드함
        SceneManager.LoadScene(SceneName);
    }
}
