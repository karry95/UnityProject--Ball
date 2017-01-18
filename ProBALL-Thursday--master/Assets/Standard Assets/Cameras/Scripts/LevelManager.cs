using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Canvas howToPlay;
    private bool canvas = false;
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }

    /*public void QuitGame()
    {
    
        Application.Quit();
    }*/

    public void Quit()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        canvas = !canvas;
        howToPlay.gameObject.SetActive(canvas);   
    }
    public void Back()
    {
        canvas = !canvas;
        howToPlay.gameObject.SetActive(canvas);
    }

}
