using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pumpkin : MonoBehaviour
{
    public int stage;
    public bool canLoseStage;

    public bool isGrown;

    //
    
    public int MaxHealth = 10;
    public int CurrentHealth;

    public HealthBar healthBar;

    //

    public float time = 6f;
    public float timeToGrow = 50f;

    public Animator anim;

    private GameObject player;
    private bool playerInTrigger;

    public AnimationClip Anim_Stage5Harvest_Pumpkin;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        canLoseStage = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInTrigger == true)
        {
            TakeDamage(-10);
            canLoseStage = true;
            anim.SetTrigger("Water");
            Debug.Log("Water");
        }

        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
        else if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }

        if (CurrentHealth == 0)
        {
            Destroy(gameObject);
        }

        if (CurrentHealth == 3 && canLoseStage == true)
        {
            canLoseStage = false;
            stage -= 1;
        }

        if (time > 0)
        {
            time -= 1 * Time.deltaTime;
        }
        else
        {
            TakeDamage(1);
            time = 6f;
        }

        if (timeToGrow > 0)
        {
            timeToGrow -= 1 * Time.deltaTime;
        }

        if (timeToGrow < 1)
        {
            timeToGrow = 50f;
            stage += 1;
        }

        if (stage == 5)
        {
            isGrown = true;
            Destroy(gameObject, Anim_Stage5Harvest_Pumpkin.length);
        }


        anim.SetFloat("timeToGrow", timeToGrow);
        anim.SetInteger("CurrentHealth", CurrentHealth);
        anim.SetFloat("time", time);
        anim.SetInteger("stage", stage);
        anim.SetBool("canLoseStage", canLoseStage);

        //if (CurrentHealth == 3 && stage = 3)
        //{
        //    timeToGrow = 50;
        //}

    }


    void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        healthBar.SetHealth(CurrentHealth);
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;
            playerInTrigger = true;
    //        TriggerFeedback.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInTrigger = false;
    //        TriggerFeedback.SetActive(false);
        }
    }

}
