using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selected : MonoBehaviour
{


    public void PlayGame()
    {
        SceneManager.LoadScene("terrian");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
