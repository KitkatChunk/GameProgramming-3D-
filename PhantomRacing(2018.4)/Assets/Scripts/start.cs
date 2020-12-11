using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Level_1_Scene");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level_2_Scene");
    }
    public void level3()
    {      
        SceneManager.LoadScene("Level_3_Scene");
    }

}
