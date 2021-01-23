using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool playGame = false;
    public bool isFast = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) {

            SceneManager.LoadScene("SampleScene");
            playGame = false;
            Time.timeScale = 1f;

        }

        if (Input.GetKeyDown("space")) {

            playGame = true;

        }

        if (Input.GetKeyDown("escape")) {

            Application.Quit();

        }


    }
}
