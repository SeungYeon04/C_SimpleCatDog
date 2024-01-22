using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //���콺 �����
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, transform.position.y, 0);
        //x�� ���콺 y�� ���� ������(transform.position.y)

        float x = mousePos.x;
        if (x > 8.5f)
        {
            x = 8.5f;
        }
        if (x < -8.5f)
        {
            x = -8.5f;
        }
        transform.position = new Vector3(x, transform.position.y, 0);
    }
}
