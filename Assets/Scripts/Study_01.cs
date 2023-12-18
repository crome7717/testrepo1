using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* using UnityEditor 라는 코딩을 볼 수 있는 데
이는 조금 위험 할 수 있다. 실 게임을 돌리는 매개체는 핸드폰이기 때문에
유니티 에디터가 작동 하지 않는다. 따라서 해당 코드를 발견 했을 경우 조심 해야 한다ㅏㅏㅏㅏ
*/


public class Study_01 : MonoBehaviour

{
    // Start is called before the first frame update
    void Awake()//얘가 스타트보다 빨리 1회 실행
    {
        Debug.LogError("Awake");

    }
    /*void Update()
        {
            Debug.Log("Update");
        }
    }*/
    /*void FixedUpdate()
    {
        Debug.LogWarning("FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.LogError("LateUpdate");

    }*/



    void Start()
    {
        Debug.Log("Start");
        /*
        Debug.Log("안녕? 펑크랜드가 그립지?");
        // 주석 기호
        
        *
        *주석 
        *여러 줄 
        *사용 할 때
        
        
        int level = 5;
        float strength = 1.0f;
        string playerName = "하하하하";
        bool isFullLevel = false;

        Debug.Log(level);
        
       
        Debug.Log("경고");
        Debug.LogWarning("경고");
        Debug.LogError("경고");
        */
       
        //별도로 선언 하지 않을 경우 기본 값은 0

        // lua = nil
        // C# = null
        /*
        Debug.Log(test);
        test ++;
        Debug.Log(test);
        test = test += 1;
        Debug.Log(test);
        test = test + 1;
        Debug.Log(test);
        */
    }

    void OnDestroy()//씬에서 존재가 사라질 때 실행
    {
        Debug.Log("으악! 범인은 박민수...");
    }
    /*
    void OnApplicationPause(bool pause)
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }

    private void OnApplicationFocus(bool focus)
    {
        
    }
    */
    void OnEnable()//활성화 될 때 한번 실행 되는 함수
                   //오브젝트가 활성화 될 때
    {
        Debug.Log("켜졌다.");
    }

    private void OnDisable()//비활성화 될 때 한번 실행 되는 함수

    {
        Debug.Log("꺼졌다.");
    }
}
// Update is called once per frame

//int[] ssh = new int[3];
//추가 수정은 어렵지만 검색은 용이하다

//List<int> yyw = new List<int>(3);
//추가 수정은 용이 하지만 검색은 다소 어렵다

//배열은 remove를 통해 3번째 칸의 데이터를 삭제 할 수 있다
//List는 아예 세번째 요소를 삭제 한다

