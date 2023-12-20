using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  // ȸ�� �ӵ�   

    void Start()
    {
        // �����ӷ���Ʈ�� 60���� �����Ѵ�
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ�
        if (Input.GetMouseButtonDown(0))// ���콺�� "������ ��"����
        {
            rotSpeed = 30;
        }

        // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��
        transform.Rotate(0, 0, rotSpeed);

        if (rotSpeed < 0.1f)
        {
            // ���� �ӵ��� 0.1f ���� �۾����� ���������� �ӵ��� 0���� ����
            rotSpeed = 0;
        }
        else
        {
            
            // �귿�� ���ӽ�Ų��
            rotSpeed *= 0.96f;

        }
    }
}
