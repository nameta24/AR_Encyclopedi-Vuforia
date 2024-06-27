using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ARscene()
    {
        SceneManager.LoadScene("ARscene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
