using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DanceHall : MonoBehaviour
{
    public GameObject loading;
    public void BackToModeSelection()
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
