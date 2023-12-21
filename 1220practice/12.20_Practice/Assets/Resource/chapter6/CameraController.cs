using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    CatController catController;
    // Start is called before the first frame update
    void Start()
    {
        catController = GameObject.FindObjectOfType<CatController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 catPos = catController.gameObject.transform.position;
        //transform.position = new Vector3(catPos.x,catPos.y,transform.position.z);
        if(catController == null)
        {
            transform.position = new Vector3 (0,0,-10);
        }
        else
        {
            Vector3 catPos = catController.gameObject.transform.position;
            transform.position = new Vector3(catPos.x, catPos.y, transform.position.z);
        }
    }
}
