using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonAwal : MonoBehaviour
{
    // Start is called before the first frame update
    public void pindah()
    {
        SceneManager.LoadScene("MainScreen");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
