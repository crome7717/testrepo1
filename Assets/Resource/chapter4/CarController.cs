using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // �������� ���̸� ���Ѵ�
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ǥ
            startPos = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺�� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            Debug.Log(Input.mousePosition);
            float swipeLength = endPos.x - startPos.x;

            // �������� ���̸� ó�� �ӵ��� ��ȯ�Ѵ�
            speed = swipeLength / 500.0f;
            // input.mousePOsition���� ������� ���Ͱ��� �ػ��� ������ ����

            //ȿ������ ���
            gameObject.GetComponent<AudioSource>().Play(); 


        }


        transform.Translate(speed, 0, 0);  // �̵�
        speed *= 0.98f;                    // ����
    }
}