using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_script : MonoBehaviour
{
    public enum MagicState { water, fix, shoot };
    public MagicState magicState = MagicState.water;
    private int magicState2;


    private Rigidbody2D rb;

    public GameObject WaterSpell;
    public Transform WaterSpellSpawn;

    public float RunSpeed = 10;
    public float x;
    public float y;

    public Vector3 cursorPos;

    //public Animator anim;


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
        cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        x = Input.GetAxis("Horizontal");

        y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(x, y) * RunSpeed;


        //Debug.Log(anim.SetTrigger("Water"));

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //set spell 1 active
            magicState = MagicState.water;
            Debug.Log("spell");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //set spell 2 active
            magicState = MagicState.fix;
            Debug.Log("Spell");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //set spell 3 active
            magicState = MagicState.shoot;
            Debug.Log("Spell");
        }


        switch (magicState)
        {
            case MagicState.water:
                //activate water code
                Water();
                break;
            case MagicState.fix:
                //activate fix code
                break;
            case MagicState.shoot:
                //activate shoot code
                break;
        }

    }


    public void Water()
    {
        if (Input.GetMouseButtonDown(1))
       
        {
            //Instantiate (WaterSpellPrefab, WaterSpawn.position, Quaternion.identity);
        }

    }

}

