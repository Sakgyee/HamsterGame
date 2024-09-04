using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Store : MonoBehaviour
{
    public GameObject Panstore;
    public GameObject Tostore;
    public GameObject Systore;
    public GameObject Itstore;

    public ScrollRect PanTrans;
    public ScrollRect ToTrans;
    public ScrollRect SyTrans;
    public ScrollRect ItTrans;

    public GameObject StoreCanvas;

    public AudioSource POP;
    public void Pancakestore()
    {
        Panstore.SetActive(true);
        Tostore.SetActive(false);
        Systore.SetActive(false);
        Itstore.SetActive(false);

        PanTrans.content.localPosition = new Vector3(0, 0, 0);
        ToTrans.content.localPosition = new Vector3(0, 0, 0);
        SyTrans.content.localPosition = new Vector3(0, 0, 0);
        ItTrans.content.localPosition = new Vector3(0, 0, 0);
    }
    public void Toppingstore()
    {
        Panstore.SetActive(false);
        Tostore.SetActive(true);
        Systore.SetActive(false);
        Itstore.SetActive(false);

        PanTrans.content.localPosition = new Vector3(0, 0, 0);
        ToTrans.content.localPosition = new Vector3(0, 0, 0);
        SyTrans.content.localPosition = new Vector3(0, 0, 0);
        ItTrans.content.localPosition = new Vector3(0, 0, 0);
    }
    public void Syrupstore()
    {
        Panstore.SetActive(false);
        Tostore.SetActive(false);
        Systore.SetActive(true);
        Itstore.SetActive(false);

        PanTrans.content.localPosition = new Vector3(0, 0, 0);
        ToTrans.content.localPosition = new Vector3(0, 0, 0);
        SyTrans.content.localPosition = new Vector3(0, 0, 0);
        ItTrans.content.localPosition = new Vector3(0, 0, 0);
    }
    public void Itemstore()
    {
        Panstore.SetActive(false);
        Tostore.SetActive(false);
        Systore.SetActive(false);
        Itstore.SetActive(true);

        PanTrans.content.localPosition = new Vector3(0, 0, 0);
        ToTrans.content.localPosition = new Vector3(0, 0, 0);
        SyTrans.content.localPosition = new Vector3(0, 0, 0);
        ItTrans.content.localPosition = new Vector3(0, 0, 0);
    }
   public void IntoStore()
    {
        DataManager.InitializeUnlockedObjects();
        POP.Play();
        StoreCanvas.transform.localPosition = new Vector3(0, 0, 0);

        Tostore.SetActive(false);
        Systore.SetActive(false);
        Itstore.SetActive(false);

        PanTrans.content.localPosition = new Vector3(0, 0, 0);
        ToTrans.content.localPosition = new Vector3(0, 0, 0);
        SyTrans.content.localPosition = new Vector3(0, 0, 0);
        ItTrans.content.localPosition = new Vector3(0, 0, 0);

    }
   public void Backtomain()
    {
        StoreCanvas.transform.localPosition = new Vector3(-8, 0, 0);

        Panstore.SetActive(true);
        Tostore.SetActive(true);
        Systore.SetActive(true);
        Itstore.SetActive(true);

        PanTrans.content.localPosition = new Vector3(0, 0, 0);
        ToTrans.content.localPosition = new Vector3(0, 0, 0);
        SyTrans.content.localPosition = new Vector3(0, 0, 0);
        ItTrans.content.localPosition = new Vector3(0, 0, 0);

        DataManager.InitializeUnlockedObjects();
        UpgradeManager.instance.Restart();
    }
}
