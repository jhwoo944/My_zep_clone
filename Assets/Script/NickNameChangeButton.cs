using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NickNameChangeButton : MonoBehaviour
{
    public InputField NinputField;
    public Button Nbutton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Onclick()
    {
        NinputField.gameObject.SetActive(true);
        Nbutton.gameObject.SetActive(true);
    }
}
