using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject loading;
    public void Play()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.5f);
        loading.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("ModeSelection");
    }

}
