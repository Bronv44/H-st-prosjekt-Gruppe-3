using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    public GameObject y;
    public float yLook;

    public GameObject x;
    public float xLook;

    public Animator anim;
    public Vector3 cursorPos;
    public Vector3 animPos;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log("World Point: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
        cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        yLook = cursorPos.y;
        xLook = cursorPos.x;


        transform.position = new Vector3 (xLook, yLook);

        animPos = cursorPos - player.position;

        anim.SetFloat("yLook", animPos.y);
        anim.SetFloat("xLook", animPos.x);

        //Vector2 (anim) = cursorPos - transform.position. (PlayerPos)

        //float = animPos (x, y)

    }

}
