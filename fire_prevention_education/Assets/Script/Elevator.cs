using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject elevator;
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //���� ���������� ������Ʈ�� Player_1������Ʈ�� �浹 �Ѵٸ�
        if (other.gameObject.name == "Player_1")
        {
            //���� ���� â�� Ȱ��ȭ �ϰ� Player������Ʈ�� ��Ȱ��ȣ ��Ų��
            elevator.SetActive(true);
            Player.SetActive(false);
        }

    }
}
