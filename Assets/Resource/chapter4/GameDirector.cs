using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshPro를 사용하기 위해 필요!

public class GameDirector : MonoBehaviour
{
    GameObject car; // "car"라는 "Gameobject를 담을 변수
    GameObject flag;
    GameObject distance;

    void Start()
    {
        //GameObject.Find("하이어라키에 "켜져 있는" 오브젝트들 중 이름으로 찾는 방법

        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        flagPosX = flag.transform.position.x;
    }
    float flagPosX;
    void Update()
    {
        // Start() 에서 flag, car를 찾았음.
        // transform.position = 그 오브젝트의 위치 정보(좌표값)을 받아옴
        // 그 오브젝트의 위치 정보 (좌표값)을 받아옴
        float length = flagPosX - car.transform.position.x;
        //To.String("F2") 는 String으로 소수점 2번째까지 표기 한다
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
    }
}
