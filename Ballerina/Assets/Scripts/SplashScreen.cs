using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLO");
        StartCoroutine(NextScene());
        
    }

    private IEnumerator NextScene()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(1);
    }
}
