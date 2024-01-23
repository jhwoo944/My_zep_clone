using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose_char_button : MonoBehaviour
{
    int type = 0;
    public Image image;
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on_click()
    {
        if (type == 0)
        {
            type = 1;
            image.sprite = sprites[1];
            GameManager.Instance.character_type = 1;
        }
        else
        {
            type = 0;
            image.sprite = sprites[0];
            GameManager.Instance.character_type = 0;
        }
    }
}
