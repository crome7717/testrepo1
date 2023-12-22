using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class collisionTest : MonoBehaviour
{

    public void Start()
    {
        
    }
    public void Update()
    {
        // 왼쪽 마우스가 눌렸을 때
        /* if (Input.GetMouseButton(0))
         {

         }*/


    }

    public void OnMouseDown()
    {
        Debug.Log("이현승");
    }
    public void OnMouseDrag()
    {
        Debug.Log("이현승");
        
        Transform Position = GetComponent<Transform>();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Debug.Log(mousePos);
        Position.position = mousePos;


     
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Apple")
        {

        }
        else
        {

        }
        if (other.gameObject.CompareTag("Apple"))
        {

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag ("Apple"))
        {
            //int id = collision.gameObject.GetComponent<Apple>().id;
           /* if(id == myID)
            {
                "합쳐라"
            }*/
           //collisionEnter 하게 돼서 실행 할 때 둘다 실행 해서
           //2개가 생성 되는 것을 조심 해야 한다
        }
    }


}
