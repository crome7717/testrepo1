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
        // ���� ���콺�� ������ ��
        /* if (Input.GetMouseButton(0))
         {

         }*/


    }

    public void OnMouseDown()
    {
        Debug.Log("������");
    }
    public void OnMouseDrag()
    {
        Debug.Log("������");
        
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
                "���Ķ�"
            }*/
           //collisionEnter �ϰ� �ż� ���� �� �� �Ѵ� ���� �ؼ�
           //2���� ���� �Ǵ� ���� ���� �ؾ� �Ѵ�
        }
    }


}
