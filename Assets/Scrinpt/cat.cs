using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cat : MonoBehaviour
{
    float full = 5.0f;
    float energy = 0.0f;
    bool isFull = false;
    public int type; 

    void Start()
    {
        float x = Random.Range(-8.5f, 8.5f);
        float y = 30.0f;
        transform.position = new Vector3(x, y, 0);

        if (type == 1)
        {
            full = 10.0f;
        }
    }

    void Update()
    {
        if (energy < full)
        {
            if (energy < full)
            {
                if (type == 0)
                {
                    transform.position += new Vector3(0.0f, -0.005f, 0.0f);
                }
                else if (type == 1)
                {
                    transform.position += new Vector3(0.0f, -0.003f, 0.0f);
                }
                else if (type == 2)
                {
                    transform.position += new Vector3(0.0f, -0.001f, 0.0f);
                }


                if (transform.position.y < -16.0f)
                {
                    gameManager.I.gameOver();
                }
            }

            if (transform.position.y < -16.0f)
            {
                gameManager.I.gameOver(); //게임오버 
            }
        }
        else
        {
            if (transform.position.x > 0)
            {
                transform.position += new Vector3(0.005f, 0.0f, 0.0f);
            }
            else
            {
                transform.position += new Vector3(-0.005f, 0.0f, 0.0f);
            }
            Destroy(gameObject, 3.0f);
        }


    }

    void OnTriggerEnter2D(Collider2D coll) //두 콜라이더가 만났을 때 
    {
        if (coll.gameObject.tag == "food") //푸드 태그 사용 
        {
            
                if (energy < full)
                {
                    energy += 1.0f;
                    Destroy(coll.gameObject);
                //해당게임옵젝으로가서 파인드하고 그 밑에 파일 찾아라 프론트 가져오고 energy를풀 비율로 바꿔줌
                gameObject.transform.Find("hungry/Canvas/front").transform.localScale = new Vector3(energy / full, 1.0f, 1.0f);
                }
                else
                {
                    if (isFull ==  false)
                    {
                      gameManager.I.addCat();
                      gameObject.transform.Find("hungry").gameObject.SetActive(false);
                      gameObject.transform.Find("full").gameObject.SetActive(true);
                    isFull = true; 
                    }
                    
                }
            
        }
    }
}
