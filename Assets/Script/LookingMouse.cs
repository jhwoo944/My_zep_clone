using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LookingMouse : MonoBehaviour
{
    Vector2 target, mouse;
    SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target = transform.position;
        if (target.x < mouse.x)
        {
            rend.flipX = false;
        }
        else
        {
            rend.flipX= true;
        }
    }
}
