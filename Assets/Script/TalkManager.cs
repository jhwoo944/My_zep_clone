using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TalkManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject Tutor;
    public GameObject Panel;
    public Button Yes;
    public Button No;
    public Button Confirm;
    public Text TalkText;
    public Image TutorSprite_Talk;
    public Sprite[] TutorSprites;


    bool exit = false;


    // Start is called before the first frame update
    void Start()
    {
        TalkText.text = "문영오 매니저 : TIL 작성했나요?";
    }

    // Update is called once per frame
    void Update()
    {
        float distance = UnityEngine.Vector3.Distance(Player.transform.position, Tutor.transform.position);
        if (distance < 6)
        {
            if (exit == false)
            {
                Panel.SetActive(true);
            }
        }
        else
        {
            exit = false;
            No.gameObject.SetActive(true);
            Yes.gameObject.SetActive(true);
            Confirm.gameObject.SetActive(false);
            Panel.SetActive(false);
            TalkText.text = "문영오 매니저 : TIL 작성했나요?";
            TutorSprite_Talk.sprite = TutorSprites[0];

        }
    }

    public void YesButton()
    {
        No.gameObject.SetActive(false);
        Yes.gameObject.SetActive(false);
        Confirm.gameObject.SetActive(true);
        TutorSprite_Talk.sprite = TutorSprites[2];
        TalkText.text = "문영오 매니저 : 참 잘하셨어요! >_0";
    }
    public void NoButton()
    {
        TalkText.text = "문영오 매니저 : YOU DIED";
        No.gameObject.SetActive(false);
        Yes.gameObject.SetActive(false);
        Confirm.gameObject.SetActive(true);
        TutorSprite_Talk.sprite = TutorSprites[1];
        Invoke("RestartScene", 1.5f);
    }
    public void ConfirmButton()
    {
        No.gameObject.SetActive(true);
        Yes.gameObject.SetActive(true);
        Confirm.gameObject.SetActive(false);
        Panel.SetActive(false);
        exit = true;
        TalkText.text = "문영오 매니저 : TIL 작성했나요?";
        TutorSprite_Talk.sprite = TutorSprites[0];
    }
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
