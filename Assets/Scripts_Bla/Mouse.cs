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
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
        transform.position = new Vector2(xLook, yLook);

        yLook = cursorPos.y;
        xLook = cursorPos.x;
    }

}
