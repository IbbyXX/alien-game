using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public void ChangeToScene(string targetSceneName)
    {
        Debug.Log("changing ot scene: " + targetSceneName);
        SceneManager.LoadScene(targetSceneName);
    }


}
