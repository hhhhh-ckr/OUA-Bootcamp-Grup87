using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    //Sahne yükleme
    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadSceneAsync(sceneNumber);
    }

    //Oyundan çýkma
    public void ExitGame()
    {
        Application.Quit();
    }
}
