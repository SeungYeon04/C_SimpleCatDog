using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //���� �ö󰡰� �ϱ� 
        transform.position += new Vector3(0, 3.0f, 0);

        if (transform.position.y > 26.0f)
        {
            //���� y�� ������ ���� ���� 
            Destroy(gameObject);
        }
    }
}
