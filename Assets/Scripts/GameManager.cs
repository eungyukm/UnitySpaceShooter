using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text text;

    private void Start() {
        text.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        text.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Main");
        }
    }
}
