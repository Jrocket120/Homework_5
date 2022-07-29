using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string GameScene;

    public void NextLevel()
    {
        SceneManager.LoadScene(GameScene);

        //Use SceneManager to move to next Level
        //Make sure you connect it to Button
    }

}
