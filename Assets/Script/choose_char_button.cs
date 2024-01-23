using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose_char_button : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
       if(GameManager.Instance.character_type == 0)
        {
            image.sprite = sprites[0];
        }
        else
        {
            image.sprite = sprites[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on_click()
    {
        if (GameManager.Instance.character_type == 0)
        {
            image.sprite = sprites[1];
            GameManager.Instance.character_type = 1;
        }
        else
        {
            image.sprite = sprites[0];
            GameManager.Instance.character_type = 0;
        }
    }
}
