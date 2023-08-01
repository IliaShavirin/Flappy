using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlsManager : MonoBehaviour
{
    public void PlayLvl1()
    {
        Application.LoadLevel("Game");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("Menu");
    }
}
