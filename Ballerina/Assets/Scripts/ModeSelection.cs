using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{
    private string sceneName;
    public GameObject loading;
    public void NextScene(string SceneName)
    {
        sceneName = SceneName;
        StartCoroutine(LoadScene());
    }
    
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.5f);
        loading.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneName);
    }
}
