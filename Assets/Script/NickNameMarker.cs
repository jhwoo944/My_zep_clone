using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NickNameMarker : MonoBehaviour
{
    public Text nickName_text = null;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        nickName_text.text = GameManager.Instance.playerNickName;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
