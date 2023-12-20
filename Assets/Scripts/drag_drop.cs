using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




 

public class drag_drop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDropHandler, IDragHandler

    
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        
        Debug.Log("�巡�� ����");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log("�巡�� �ϴ� ��");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
    }
}
