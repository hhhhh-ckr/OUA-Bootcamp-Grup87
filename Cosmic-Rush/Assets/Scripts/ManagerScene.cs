using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    //Sahne y�kleme
    public void StartButton()
    {
        SceneManager.LoadSceneAsync(1);
    }

    //Oyundan ��kma
    public void ExitGame()
    {
        Application.Quit();
    }
}
