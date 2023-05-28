using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public audioManager aud;
    public float speed = 1f;
    Vector2 movement;
    Rigidbody2D rb;
    public Animator anim;
    public coinCounter coins;
    public healthController life;
    public deadController mati;
    public winController winner;
    public float isAttack;


    // Start is called before the first frame update
    void Start()
    {
        aud.Play(0);
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();


    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetFloat("isAttack", 1);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            anim.SetFloat("isAttack", 0);
        }

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {
            Destroy(collision.gameObject);

            coins.earnedCoin += 500;
            coins.collect += 1;
           

            if(coins.collect == 7)
            {
                Time.timeScale = 0;
                winner.showPanel();

                aud.StopSong();
                aud.Play(1);
            }


        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            life.maxLifes -= 1;


            if (life.maxLifes == 0)
            {
                aud.StopSong();
                aud.Play(2);
            }

        }
    }


    public void deadCondition()
    {
        Time.timeScale = 0;
        anim.Play("down");
        mati.showPanel();
    }
    
}
