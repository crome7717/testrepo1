using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 화살표가 눌렸을 때
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(transform.position.x > -9)
            {

            transform.Translate(-3, 0, 0); // 왼쪽으로 '3' 움직인다
            }
        }

        // 오른쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            if(transform.position.x < 9)
            {
            transform.Translate(3, 0, 0);
            }
        }
        
    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

}
