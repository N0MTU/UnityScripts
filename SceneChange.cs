using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string scenename;
    public void sceneChange()
    {
        //load inputted scene
        SceneManager.LoadScene(scenename);
    }
}
