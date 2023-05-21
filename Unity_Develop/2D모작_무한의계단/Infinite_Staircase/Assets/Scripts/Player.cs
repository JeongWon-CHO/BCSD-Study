using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isMovingRight = true;

    public Rigidbody BusinessMan; // 추가한 부분

    public Animator anim;
    public AudioSource[] sound;
    public GameManager gameManager;
    //public DSLManager dslManager;
    public bool isleft = true, isDie = false;
    public int characterIndex, stairIndex, money;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        //money = dslManager.GetMoney();
    }

   
  
    private void Update()
    {

        // 기본값 : 0.59f 기준으로 짜긴함 0.33f랑

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 오른쪽으로 이동
            if (isMovingRight == true)
                transform.Translate(new Vector2(-0.58f, 0.33f));
            else
                transform.Translate(new Vector2(0.58f, 0.33f));

            
        }

        // 왼쪽 방향키 입력 감지
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 방향 전환
            isMovingRight = !isMovingRight;

            // 방향 전환에 따라 플레이어 스케일 반전
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            //transform.localScale = scale;

            if (isMovingRight == true)
                transform.Translate(new Vector2(-0.49f, 0.34f));
            else
                transform.Translate(new Vector2(0.59f, 0.34f));

        }

    }



    public void Climb(bool isChange)
    {
        if (isChange) 
            isleft = !isleft;
        gameManager.StairMove(stairIndex, isChange, isleft);
        if ((++stairIndex).Equals(20)) 
            stairIndex = 0;
        MoveAnimation();
        gameManager.gaugeStart = true;
    }


    public void MoveAnimation()
    {
        //Change left and right when changing direction
        if (!isleft)
            transform.rotation = Quaternion.Euler(0, -180, 0);
        else
            transform.rotation = Quaternion.Euler(0, 0, 0);

        if (isDie) return;
        anim.SetBool("Move", true);
        //gameManager.PlaySound(1);
        Invoke("IdleAnimation", 0.05f);
    }

    public void IdleAnimation()
    {
        anim.SetBool("Move", false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            //gameManager.PlaySound(0);
            money += 2;
            //dslManager.LoadMoney(money);
        }
    }



}