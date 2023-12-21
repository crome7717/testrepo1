using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {
        // �����Ӹ��� ������� ���Ͻ�Ų��.
        
        transform.Translate(0, -0.1f, 0);
        if (transform.position.y < -05f)
        {
            Destroy(gameObject);
        }
        // ȭ�� ������ ������ ������Ʈ�� �Ҹ� ��Ų��.
        //�浹����
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
       float d = dir.magnitude ;
        float r1 = 0.5f;
        float r2 = 1.0f;
        
        if(d < r1 + r2)
        {
            // ���� ��ũ��Ʈ�� �÷��̾�� ȭ���� �浹 �ߴٰ� �����Ѵ�.
            GameObject director = GameObject.Find("GameD");
            director.GetComponent<GameD>().DecreaseHp();
            
            // ��Ʈ���̴� ��ü�� �ı� ��Ű�� ������, ���� �ش� ������Ʈ�� ȿ���� �ְ� �ʹٸ�
            // ��Ʈ���̰� ���� ���߿� �۵� �ϰ� �ؾ� �Ѵ�
            Destroy(gameObject);
        }
        
    }
}
