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

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log("World Point: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        yLook = cursorPos.y;
        xLook = cursorPos.x;

        anim.SetFloat("yLook", cursorPos.y);
        anim.SetFloat("xLook", cursorPos.x);

        transform.position = new Vector3 (xLook, yLook);

    }

}
