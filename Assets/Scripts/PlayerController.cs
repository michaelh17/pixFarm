using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    Vector2 movement;
    Rigidbody2D rb;
    public Animator anim;
    public coinCounter coins;
    public healthController life;
    public float isAttack;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
        //anim.SetFloat("isAttack",0);
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
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            life.maxLifes -= 1;
        }

    }

    
}
