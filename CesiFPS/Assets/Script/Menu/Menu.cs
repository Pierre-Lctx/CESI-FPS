using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject PlayMenu;
    public GameObject RoomMenu;

    private void Start()
    {
        MainMenu.SetActive(true);
        PlayMenu.SetActive(false);
        RoomMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        MainMenu.SetActive(true);
        PlayMenu.SetActive(false);
        RoomMenu.SetActive(false);
    }

    public void Play()
    {
        MainMenu.SetActive(false);
        PlayMenu.SetActive(true);
        RoomMenu.SetActive(false);
    }

    public void Option()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}
