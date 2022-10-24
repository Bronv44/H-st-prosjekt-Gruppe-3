using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_script : MonoBehaviour
{

    private Rigidbody2D rb;

    public float RunSpeed = 2;
    public float x;
    public float y;

    public Vector3 cursorPos;

    public Animator anim;

    public bool PumpkinInTrigger;
    public GameObject Pumpkin;

    public int Water;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        x = Input.GetAxis("Horizontal");

        y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(x, y) * RunSpeed;


        if (Input.GetKeyDown(KeyCode.E) && PumpkinInTrigger == true) 
        {
            anim.SetTrigger("Water");
            Debug.Log("Water");
            
        }



        anim.SetFloat("x", x);
        anim.SetFloat("y", y);
        anim.SetInteger("Water", Water);


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pumpkin")
        {
            Pumpkin = collision.gameObject;
            PumpkinInTrigger = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pumpkin")
        {
            PumpkinInTrigger = false;

        }
    }
}

    