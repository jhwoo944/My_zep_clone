using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterImageChanger : MonoBehaviour
{
    public SpriteRenderer Image1;
    public SpriteRenderer Image2;


    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.character_type == 0)
        {
            Image1.enabled = true;
            Image2.enabled = false;
        }
        else
        {
            Image2.enabled = true;
            Image1.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
