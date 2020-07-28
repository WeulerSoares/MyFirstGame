using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void New_Game(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
        GameController.totalScore = 0;
        GameController.deaths = 0;
    }

    public void Quit()
    {
            Application.Quit();
    }
}
