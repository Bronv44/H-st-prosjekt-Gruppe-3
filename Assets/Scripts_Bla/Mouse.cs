using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{

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
    }

}
