using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputNicknameButton : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }

    private void Update()
    {

    }

    //¸¶¿ì½º
    public void InputName()
    {
        playerName = playerNameInput.text;
        if (playerName.Length > 1)
        {
            GameManager.Instance.playerNickName = playerName;
            SceneManager.LoadScene("MainScene");
        }
    }
}
