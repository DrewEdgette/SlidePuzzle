using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public int LevelToLoad = 0;
    public void loadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
