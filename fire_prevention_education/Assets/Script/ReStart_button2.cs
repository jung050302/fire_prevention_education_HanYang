using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReStart_button2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Fire;
    void Start()
    {
        Fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtondDown()
    {
         
        
        SceneManager.LoadScene("MyRoom");
    }
}
