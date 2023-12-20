using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  // 회전 속도   

    void Start()
    {
        // 프레임레이트를 60으로 고정한다
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 클릭하면 회전 속도를 설정한다
        if (Input.GetMouseButtonDown(0))// 마우스를 "눌렀을 때"실행
        {
            rotSpeed = 30;
        }

        // 회전 속도만큼 룰렛을 회전시킨다
        transform.Rotate(0, 0, rotSpeed);

        if (rotSpeed < 0.1f)
        {
            // 도는 속도가 0.1f 보다 작아지면 강제적으로 속도를 0으로 맞춤
            rotSpeed = 0;
        }
        else
        {
            
            // 룰렛을 감속시킨다
            rotSpeed *= 0.96f;

        }
    }
}
