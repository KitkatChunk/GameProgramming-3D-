using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartRacing : MonoBehaviour
{
    public void Startmenu() 
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Lvl1()
    {
        SceneManager.LoadScene("Level_1_Scene");
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("Level_2_Scene");
    }
    public void Lvl3()
    {
        SceneManager.LoadScene("Level_3_Scene");
    }


}
