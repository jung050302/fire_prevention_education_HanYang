using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hallway2_Fire : MonoBehaviour
{

    public GameObject Fire1;
    public GameObject Fire2;
    public GameObject Fire3;
    public GameObject Fire4;

    float timer;
    int waitingTime;
    float timer2;


    float timer_2;
    float timer2_2;
    int waitingTime_2;
    void Start()
    {
        timer = 0.0f;
        waitingTime = 2;
        timer_2 = 0.0f;

        timer2_2=0;
        waitingTime_2 = 3;
        timer2 = 0;
    }


    void Update()
    {

        timer += Time.deltaTime;
        //2���Ŀ� ��1,2�� Ȱ��ȭ��
        if (timer > waitingTime)
        {
            Fire1.SetActive(true);
            Fire2.SetActive(true);
             
            timer2 += Time.deltaTime;
            //Ȱ��ȭ�ϰ� 1�ʵڿ� ��Ȱ��ȭ
            if (timer2 > 1)
            {
                Fire1.SetActive(false);
                Fire2.SetActive(false);
                timer = 0;
                timer2 = 0;
            }
             
        }
        //3�ʵڿ� ��3,4�� Ȱ��ȭ
        timer_2 += Time.deltaTime;
         
        if (timer_2 > waitingTime_2)
        {
            Fire3.SetActive(true);
            Fire4.SetActive(true);
             
            timer2_2 += Time.deltaTime;
            
            //1�ʵڿ� ��3,4��Ȱ��ȭ
            if (timer2_2 > 1)
            {
                Fire3.SetActive(false);
                Fire4.SetActive(false);
                timer_2 = 0;
                timer2_2 = 0;
            }

        }

    }
    void Fire()
    {
         
        
    }
    void Fire_2()
    {
        float timer = 0.0f;
        float timer2 = 0.0f;
        int waitingTime = 4;
        timer += Time.deltaTime;//1�� 1�� ���Ѵ�

        if (timer > waitingTime)//����2�ʰ� ������
        {
            Fire1.SetActive(true);
            Fire2.SetActive(true);
            timer2 += Time.deltaTime;
            if (timer2 >= 1)
            {
                Fire3.SetActive(false);
                Fire4.SetActive(false);
            }

        }

    }
}
