using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MousePosition : MonoBehaviour
{

    public GameObject lanterna;


        void Update()
    {
        Vector3 temp = Input.mousePosition;
        temp.z = 9.5f;
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}