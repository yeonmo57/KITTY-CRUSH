using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 650.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();   
    }



    // Update is called once per frame
    void Update()
    {
        animator.SetBool("walk", true);
        //점프한다.

        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y==0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);            
        }

        //좌우 이동
        float key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 0.75f;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -0.75f;

        //플레이어의 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //스피드 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 0.75f, 1);
        }

        //플레이어 속도에 맞춰 애니메이션 속도를 바꾼다.
        this.animator.speed = speedx / 2.0f;

        if(transform.position.y<-10)
        {
            SceneManager.LoadScene("OopsScene");
        }
    }

  
    void OnTriggerEnter2D(Collider2D other)
    {
        //딸기에 닿았을 때
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log("적");
            SceneManager.LoadScene("OopsScene");
        }

        //집에 도착했을 때
        if (other.gameObject.tag.Equals("Finish"))
        {
            Debug.Log("골");
            SceneManager.LoadScene("GoodScene");
        }

        //2라운드의 집에 도착했을 때
        if (other.gameObject.tag.Equals("SecondRound"))
        {
            Debug.Log("골");
            SceneManager.LoadScene("GreatScene");
        }
    }
}



