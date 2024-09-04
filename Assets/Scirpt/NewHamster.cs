using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHamster : MonoBehaviour
{
    public static NewHamster instance;

    public GameObject NewHam;

    public GameObject Ham4;
    public GameObject Ham5;
    public GameObject Ham6;
    public GameObject Ham7;
    public GameObject Ham8;
    public GameObject Ham9;
    public GameObject Ham10;
    public GameObject Ham11;
    public GameObject Ham12;
    public GameObject Ham13;
    private void Awake()
    {
        NewHamster.instance = this;
    }

    public void H4()
    {
        Ham4.SetActive(true);
    }
    public void H5()
    {
        Ham5.SetActive(true);
    }
    public void H6()
    {
        Ham6.SetActive(true);
    }
    public void H7()
    {
        Ham7.SetActive(true);
    }
    public void H8()
    {
        Ham8.SetActive(true);
    }
    public void H9()
    {
        Ham9.SetActive(true);
    }
    public void H10()
    {
        Ham10.SetActive(true);
    }
    public void H11()
    {
        Ham11.SetActive(true);
    }
    public void H12()
    {
        Ham12.SetActive(true);
    }
    public void H13()
    {
        Ham13.SetActive(true);
    }
    public void BackToMain()
    {       
        Ham4.SetActive(false);
        Ham5.SetActive(false);
        Ham6.SetActive(false);
        Ham7.SetActive(false);
        Ham8.SetActive(false);
        Ham9.SetActive(false);
        Ham10.SetActive(false);
        Ham11.SetActive(false);
        Ham12.SetActive(false);
        Ham13.SetActive(false);

        NewHam.SetActive(false);
    }
}
