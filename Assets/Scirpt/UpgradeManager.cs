using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager instance;

    public static int MakeTimeInt;
    public int Upgradetime;

    public static int MakeMoneyInt;
    public int Upgrademoney;

    public static int MakeExpInt;
    public int Upgradeexp;

    public Text MakeTimeText;
    public Text MakeMoneyText;
    public Text MakeExpText;

    public float animSpeed = 1f;
    public Animator animator;

    private void Awake()
    {
        UpgradeManager.instance = this;
    }
    void Start()
    {
        //PlayerPrefs.DeleteKey("TimeSet");
        //PlayerPrefs.DeleteKey("MoneySet");
        //PlayerPrefs.DeleteKey("ExpSet");

        MakeTimeText = GameObject.Find("Store Canvas").transform.Find("Time").gameObject.GetComponent<Text>();
        MakeMoneyText = GameObject.Find("Store Canvas").transform.Find("Money").gameObject.GetComponent<Text>();
        MakeExpText = GameObject.Find("Store Canvas").transform.Find("Exp").gameObject.GetComponent<Text>();

        MakeTimeInt = PlayerPrefs.GetInt("TimeSet", 0);
        MakeTimeInt += Upgradetime;
        MoneyData.UpgradeTimeCheck = MakeTimeInt;
        Debug.Log("업그레이드타임 : " + Upgradetime);
        Debug.Log("메이크타임인트 : " + MakeTimeInt);
        if (MakeTimeInt == 0)
        {
            MakeFood.instance.MakeTime = 8f;
            animSpeed = 1f;
        }
        if (MakeTimeInt == 1)
        {
            MakeFood.instance.MakeTime = 7f;
            animSpeed = 1.125f;
        }
        if (MakeTimeInt == 2)
        {
            MakeFood.instance.MakeTime = 6f;
            animSpeed = 1.25f;
        }
        if (MakeTimeInt == 3)
        {
            MakeFood.instance.MakeTime = 5f;
            animSpeed = 1.4f;
        }
        if (MakeTimeInt == 4)
        {
            MakeFood.instance.MakeTime = 4f;
            animSpeed = 1.65f;
        }
        if (MakeTimeInt == 5)
        {
            MakeFood.instance.MakeTime = 3f;
            animSpeed = 2.2f;

            DataManager.UnlockUpgrade("MakeTime locked");
        }

        MakeMoneyInt = PlayerPrefs.GetInt("MoneySet", 0);
        MakeMoneyInt += Upgrademoney;
        MoneyData.UpgradeMoneyCheck = MakeMoneyInt;

        Debug.Log("업그레이드머니 : " + Upgrademoney);
        Debug.Log("메이크머니인트 : " + MakeMoneyInt);

        if(MakeMoneyInt == 1)
        {
            FoodCheck.instance.UpgradeMoney = 20;  
        }
        if (MakeMoneyInt == 2)
        {
            FoodCheck.instance.UpgradeMoney = 40;
        }
        if (MakeMoneyInt == 3)
        {
            FoodCheck.instance.UpgradeMoney = 60;
        }
        if (MakeMoneyInt == 4)
        {
            FoodCheck.instance.UpgradeMoney = 80;
        }
        if (MakeMoneyInt == 5)
        {
            FoodCheck.instance.UpgradeMoney = 100;
            DataManager.UnlockUpgrade("MoneyUp locked");
        }

        MakeExpInt = PlayerPrefs.GetInt("ExpSet", 0);
        MakeExpInt += Upgradeexp;
        MoneyData.UpgradeExpCheck = MakeExpInt;

        Debug.Log("업그레이드이엑스피 : " + Upgradeexp);
        Debug.Log("메이크이엑스피인트 : " + MakeExpInt);

        if (MakeExpInt == 1)
        {
            FoodCheck.instance.UpgradeExp = 50;
        }
        if (MakeExpInt == 2)
        {
            FoodCheck.instance.UpgradeExp = 100;
        }
        if (MakeExpInt == 3)
        {
            FoodCheck.instance.UpgradeExp = 150;
        }
        if (MakeExpInt == 4)
        {
            FoodCheck.instance.UpgradeExp = 200;
        }
        if (MakeExpInt == 5)
        {
            FoodCheck.instance.UpgradeExp = 250;
            DataManager.UnlockUpgrade("ExpUp locked");
        }

        Upgradetime = 0;
        Upgrademoney = 0;
        Upgradeexp = 0;
    }
    private void Update()
    {
        PlayerPrefs.SetInt("TimeSet", MakeTimeInt);
        PlayerPrefs.SetInt("MoneySet", MakeMoneyInt);
        PlayerPrefs.SetInt("ExpSet", MakeExpInt);

        MakeTimeText.text = MakeTimeInt.ToString();
        MakeMoneyText.text = MakeMoneyInt.ToString();
        MakeExpText.text = MakeExpInt.ToString();

        animator.speed = animSpeed;
    }
    public void Restart()
    {
        Start();
        Debug.Log("리스타트업그레이드타임 : " + Upgradetime);
        Debug.Log("리스타트메이크타임인트 : " + MakeTimeInt);
    }
}
