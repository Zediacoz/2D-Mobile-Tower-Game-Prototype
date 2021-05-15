using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }


    public void BackMenu()
    {
        SceneManager.LoadScene(1);
    }


    public void Ads()
    {
        SceneManager.LoadScene(2);
    }


    public void Settingz()
    {
        SceneManager.LoadScene(3);
    }


    public void Coins()
    {
        SceneManager.LoadScene(4);
    }


    public void Shopp()
    {
        SceneManager.LoadScene(5);
    }


    public void Restart()
    {
        SceneManager.LoadScene(0);
    }


}
