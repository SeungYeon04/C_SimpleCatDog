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
        //위로 올라가게 하기 
        transform.position += new Vector3(0, 3.0f, 0);

        if (transform.position.y > 26.0f)
        {
            //일정 y가 지나면 옵젝 삭제 
            Destroy(gameObject);
        }
    }
}
