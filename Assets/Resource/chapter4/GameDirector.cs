using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro�� ����ϱ� ���� �ʿ�!

public class GameDirector : MonoBehaviour
{
    GameObject car; // "car"��� "Gameobject�� ���� ����
    GameObject flag;
    GameObject distance;

    void Start()
    {
        //GameObject.Find("���̾��Ű�� "���� �ִ�" ������Ʈ�� �� �̸����� ã�� ���

        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        flagPosX = flag.transform.position.x;
    }
    float flagPosX;
    void Update()
    {
        // Start() ���� flag, car�� ã����.
        // transform.position = �� ������Ʈ�� ��ġ ����(��ǥ��)�� �޾ƿ�
        // �� ������Ʈ�� ��ġ ���� (��ǥ��)�� �޾ƿ�
        float length = flagPosX - car.transform.position.x;
        //To.String("F2") �� String���� �Ҽ��� 2��°���� ǥ�� �Ѵ�
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
    }
}
