using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoMain());
    }

    IEnumerator GoMain()
    {
        yield return new WaitForSeconds(7.0f);
        SceneManager.LoadScene("Main");
    }
}
