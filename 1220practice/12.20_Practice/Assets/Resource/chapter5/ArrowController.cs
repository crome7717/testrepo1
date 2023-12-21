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
        // 프레임마다 등속으로 낙하시킨다.
        
        transform.Translate(0, -0.1f, 0);
        if (transform.position.y < -05f)
        {
            Destroy(gameObject);
        }
        // 화면 밖으로 나오면 오브젝트를 소멸 시킨다.
        //충돌판정
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
       float d = dir.magnitude ;
        float r1 = 0.5f;
        float r2 = 1.0f;
        
        if(d < r1 + r2)
        {
            // 감독 스크립트에 플레이어와 화살이 충돌 했다고 전달한다.
            GameObject director = GameObject.Find("GameD");
            director.GetComponent<GameD>().DecreaseHp();
            
            // 디스트로이는 객체를 파괴 시키기 때문에, 만약 해당 오브젝트에 효과를 넣고 싶다면
            // 디스트로이가 제일 나중에 작동 하게 해야 한다
            Destroy(gameObject);
        }
        
    }
}
