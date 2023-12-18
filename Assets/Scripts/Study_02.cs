using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_02 : MonoBehaviour
{

    // List 선언
    // List <데이터 타입> 리스트 이름 = new List <데이터 타입>();
    // 크기를 지정하고 만들고 싶을 때는
    // List<DataType> name = new List <DataType>(new DataType[size])
    // ㄴ 빈거 size 짜리 리스트를 만듬.

    // List도 생성과 동시에 초기화 해서 대입 가능
    // List<string> ssh = new List<string>(){"신성호,"바보"};
    // ㄴ 이러면 ssh 리스트 안에 0번째는 "신성호", 1번째는 "바보"
    // ssh[0] = "신성호", ssh[1] = "바보"
    // 리스트는 다른 리스트를 받아서 대입 할 수 있음
    // List<string> yyw = new List<string>(ssh);
    // ㄴ yyw = ssh
    // 리스트에 데이터 추가 하는 방법
    // Add 함수를 이용
    // 얘는 리스트의 맨 뒤에 추가 하는 방법임

    [SerializeField]
    List<string> ssh = new List<string>() { "God성호", "Good" };
    //List<string> ssh = List<string>();
    private void Awake()
    {

        Debug.Log(ssh[0]);
    }

    private void Start()
    {
        ssh.Add(" 신 성 호 우 ");
        Debug.Log(ssh[1]);
        // 여기서는 ssh 초기화 후 별도로 값을 안넣어놨어서
        // size 가 0임 (아무 것도 없음)
        // 그래서 "신 성 호 우" 가 ssh[0]에 들어감
        ssh.Add(" 신 성 호 이 ");
        Debug.Log(ssh[2]);
        // 추가한 " 신 성 호 이 " 는 ssh[1]에 위치

        // insert 함수 이용 방법
        // 말 그대로 끼워 넣는 방식임
        // 끼워 넣으니까 기존에 있던 애들은 뒤로 밀림

        ssh.Insert(1, " 유 용 워 이 ");
        Debug.Log(ssh[1]);
        // 이러면 ssh 는 ?
        // [God성호, 유 용 워 이 , Good, 신 성 호 이 , 신 성 호 이]

        // 배열, 리스트의 크기를 구하는 방법
        // 배열 일 경우
        // 배열 이름.Length;
        // 리스트일 경우
        // 리스트이름.Count;
        // 배열과 리스트의 크기를 구하는 방법이 다름
        // 방법이 다른데 리스트와 배열의 이름을 비슷하게 지으면 ?
        // 배열이름.Count; 이렇게 하려고 해서 에러가 나올 것임

        // 리스트에서 데이터를 삭제 하는 방법
        // - Remove 함수
        // 원하는 "값"을 찾아서 지움
        // 같은 값이 여러개면 맨 처음 값을 지우는데...
        // 같은 ID를 가지는 3마리 중 2번째를 지워야 하는 상황에서는 ?


        // -RemoveAt 함수 사용
        // 얘는 인덱스 정보로 지움.
        // 배열과 동일하게 0부터 시작

        // 이거 말고도 RemoveAll, Clear 함수가 있음.
        // 근데 안 쓸듯
        // 리스트이름.RemoveAll(x => x == "yyw");
        // x => x == "yyw" 이 부분은 람다식이라 하는 데....
        // 몰라도 됨.
        // 내용은 x 가 yyw 인 애를 모두 지운다는 내용

        //
        ssh.Remove(" 유 용 워 이 ");
        Debug.Log(ssh[1]);
        // Lua 구구단 만들기
        // for i = 1, i <= 9 do
        //      for s = 1, s<=9 do
        //           print i * s
        //      end
        // end

        // C#은 중괄호{}로 묶어줌
        // for 문은
        for (int i = 0; i < 9; i++)
        {
            // i가 0부터 시작.
            // i < 9 : 9보다 작을 때까지
            // i++ :i를 1씩 증가 
        }

        // int test = 4/8;
        // test
        int sum = 0;// 합계를 담을 정수형 변수
        int odd = 0; // 홀 수 수량을 담을 정수형 변수

        for (int i =2; i < 10 ; i++)
        {
            for (int j = 1; j < 10 ; j++)
            {

                int result = i * j;
                Debug.Log( i + " X " + j + " = " + result);
                sum += result;
                if (result % 2 == 1)
                {
                    odd++;
                    Debug.Log(odd);
                }
            }
        }
    int randValue;
    randValue = Random.Range(0,3);
    //int 일 때 끝 값 포함 안함

    }
}

// 스위치 
// 얘도 조건에 따른 제어문임 (if랑 비슷)
// 근데 얘는 하나의 값을 참조해서 일치 하는 경우에만
// 해당 명령어를 실행하는 방식
// 비교, 논리 연산 불가
// 정확히 일치하는 값이 있어야 쓸 수 있음


/*switch (비교값)
{
    case 일치값1:
          실행할 명령어
        break;
    case 일치값2:
          실행할 명령어
        break;
    case 일치값3:
          실행할 명령어
        break;
    default;
        일치 값이 없을 때 실행할 내용
        if로 치면 else에 해당
        break;

}*/

// 우편함 
// Item ID 101,102,103
// 