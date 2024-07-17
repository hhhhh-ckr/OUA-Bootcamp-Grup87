using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    //Sahne y�kleme
    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadSceneAsync(sceneNumber);
    }

    //Oyundan ��kma
    public void ExitGame()
    {
        Application.Quit();
    }
}
