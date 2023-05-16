using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {
        titleScreen.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow)))
        {
            titleScreen.gameObject.SetActive(false);
        }
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
}