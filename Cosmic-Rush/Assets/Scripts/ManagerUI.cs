using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerUI : MonoBehaviour
{
    public Button[] planetButtons;
    public GameObject planetButtonsGroup;

    private void Awake()
    {
        ButtonsToArray();
        int unlockedPlanets = PlayerPrefs.GetInt("UnlockedPlanets", 1);
        for (int i = 0; i < planetButtons.Length; i++)
        {
            planetButtons[i].interactable = false;
        }
        for (int i = 0; i < unlockedPlanets; i++)
        {
            planetButtons[i].interactable = true;
        }
    }

    void ButtonsToArray()
    {
        int childCount = planetButtonsGroup.transform.childCount;
        planetButtons = new Button[childCount];
        for (int i = 0;i < childCount;i++)
        {
            planetButtons[i] = planetButtonsGroup.transform.GetChild(i).gameObject.GetComponent<Button>();
        }
    }

    void UnlockNextPlanet()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedPlanets", PlayerPrefs.GetInt("UnlockedPlanets", 1) + 1);
            PlayerPrefs.Save();
        }
    }
}