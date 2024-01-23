using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputNicknameButton : MonoBehaviour
{
    public InputField playerNameInput;
    public Button button;
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
        string currentSceneName = SceneManager.GetActiveScene().name;
        playerName = playerNameInput.text;
        if (playerName.Length > 1)
        {
            GameManager.Instance.playerNickName = playerName;
            if (currentSceneName != "MainScene")
            {
                SceneManager.LoadScene("MainScene");
            }
            else
            {
                playerNameInput.gameObject.SetActive(false);
                button.gameObject.SetActive(false);
            }
        }
    }
}
