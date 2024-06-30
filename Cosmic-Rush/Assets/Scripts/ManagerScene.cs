using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    //Sahne yükleme
    public void StartButton()
    {
        SceneManager.LoadSceneAsync(1);
    }

    //Oyundan çýkma
    public void ExitGame()
    {
        Application.Quit();
    }
}
