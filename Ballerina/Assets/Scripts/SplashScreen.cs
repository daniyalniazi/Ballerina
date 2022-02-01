using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashScreen : MonoBehaviour
{
    public GameObject loading;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextScene());
    }

    private IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2);
        loading.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
