using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_script : MonoBehaviour
{
    private Rigidbody2D rb;

    public float RunSpeed = 10;
    public float x;
    public float y;

    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        //rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxis("Horizontal");
       
       y = Input.GetAxis("Vertical");
       rb.velocity = new Vector2(x, y) * RunSpeed;

        anim.SetTrigger("Water");
      
    }

}
