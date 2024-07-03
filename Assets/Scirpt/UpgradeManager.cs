using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager instance;

    public static int MakeTimeInt;
    public int Upgradetime;

    public static int MakeMoneyInt;
    public int Upgrademoney;

    public static int MakeExpInt;
    public int Upgradeexp;
    private void Awake()
    {
        UpgradeManager.instance = this;
    }
    void Start()
    {
        //PlayerPrefs.DeleteKey("TimeSet");

        MakeTimeInt = PlayerPrefs.GetInt("TimeSet", 0);
        MakeTimeInt += Upgradetime;
        MoneyData.instance.UpgradeTimeCheck = MakeTimeInt;
        Debug.Log("���׷��̵�Ÿ�� : " + Upgradetime);
        Debug.Log("����ũŸ����Ʈ : " + MakeTimeInt);
        if (MakeTimeInt == 0)
        {
            MakeFood.instance.MakeTime = 10f;
        }
        if (MakeTimeInt == 1)
        {
            MakeFood.instance.MakeTime = 9f;
        }
        if (MakeTimeInt == 2)
        {
            MakeFood.instance.MakeTime = 8f;
        }
        if (MakeTimeInt == 3)
        {
            MakeFood.instance.MakeTime = 7f;
        }
        if (MakeTimeInt == 4)
        {
            MakeFood.instance.MakeTime = 6f;
        }
        if (MakeTimeInt == 5)
        {
            MakeFood.instance.MakeTime = 5f;
            DataManager.UnlockUpgrade("MakeTime locked");
        }

        MakeMoneyInt = PlayerPrefs.GetInt("MoneySet", 0);
        MakeMoneyInt += Upgrademoney;
        MoneyData.instance.UpgradeMoneyCheck = MakeMoneyInt;

        Debug.Log("���׷��̵�Ӵ� : " + Upgrademoney);
        Debug.Log("����ũ�Ӵ���Ʈ : " + MakeMoneyInt);

        if(MakeMoneyInt == 1)
        {
            ImageDrag.instance.UpgradeMoney += 50;  
        }
        if (MakeMoneyInt == 2)
        {
            ImageDrag.instance.UpgradeMoney += 100;
        }
        if (MakeMoneyInt == 3)
        {
            ImageDrag.instance.UpgradeMoney += 150;
        }
        if (MakeMoneyInt == 4)
        {
            ImageDrag.instance.UpgradeMoney += 200;
        }
        if (MakeMoneyInt == 5)
        {
            ImageDrag.instance.UpgradeMoney += 250;
            DataManager.UnlockUpgrade("MoneyUp locked");
        }

        MakeExpInt = PlayerPrefs.GetInt("ExpSet", 0);
        MakeExpInt += Upgradeexp;
        MoneyData.instance.UpgradeExpCheck = MakeExpInt;

        Debug.Log("���׷��̵��̿����� : " + Upgradeexp);
        Debug.Log("����ũ�̿�������Ʈ : " + MakeExpInt);

        if (MakeExpInt == 1)
        {
            ImageDrag.instance.UpgradeExp += 50;
        }
        if (MakeExpInt == 2)
        {
            ImageDrag.instance.UpgradeExp += 200;
        }
        if (MakeExpInt == 3)
        {
            ImageDrag.instance.UpgradeExp += 600;
        }
        if (MakeExpInt == 4)
        {
            ImageDrag.instance.UpgradeExp += 1500;
        }
        if (MakeExpInt == 5)
        {
            ImageDrag.instance.UpgradeExp += 3000;
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
    }
    public void Restart()
    {
        Start();
        Debug.Log("����ŸƮ���׷��̵�Ÿ�� : " + Upgradetime);
        Debug.Log("����ŸƮ����ũŸ����Ʈ : " + MakeTimeInt);
    }
}
