using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject HamsterCage;
    public GameObject RandomFoodImage;

    void Update()
    {
        if(!HamsterCage.activeSelf && !RandomFoodImage.activeSelf)
        {
            StartCoroutine(re());
;        }
    }
    IEnumerator re()
    {
        HamsterCage.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        RandomFoodImage.SetActive(true);
    }
}
