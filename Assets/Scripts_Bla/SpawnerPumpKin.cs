using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPumpkin : MonoBehaviour
{
    public GameObject Pumpkin;

    public bool playerInTrigger;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInTrigger == true)
        {
            Instantiate(Pumpkin, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
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