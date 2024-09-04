using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyData : MonoBehaviour
{
    public static MoneyData instance;

    public static int LevelInt;
    public static int LevelExpInt;
    public static int CoinInt;

    public static Text LevelText;
    public static Text LevelExpText;
    public static Text CoinText;

    public GameObject Levelup;
    public Text LevelUpText;
    public Text LevelUpMoneyText;
    public Text LevelUpExpText;
    int MaxLevelExpInt;

    public GameObject YesMoney;
    public GameObject NoMoney;

    int Coinprice;
    int PanCount;
    int ToCount;
    int SyCount;
    int FuCount;

    int UpgradeBuyCheck;
    public static int UpgradeTimeCheck;
    public static int UpgradeMoneyCheck;
    public static int UpgradeExpCheck;

    public Text TiMoneyText;
    public Text MoMoneyText;
    public Text ExMoneyText;

    public GameObject Flowerpot;
    public GameObject Curtain;
    public GameObject Shelf;
    public GameObject Carpet;
    public GameObject Sofa;
    public GameObject Treadmill;

    public AudioSource POP;
    private void Awake()
    {
        MoneyData.instance = this;
    }
    void Start()
    {
        LevelText = GameObject.Find("Money Canvas").transform.Find("Level").gameObject.GetComponent<Text>();
        LevelExpText = GameObject.Find("Money Canvas").transform.Find("LevelExp").gameObject.GetComponent<Text>();
        CoinText = GameObject.Find("Money Canvas").transform.Find("Coin").gameObject.GetComponent<Text>();

        LevelInt = PlayerPrefs.GetInt("Level", 0);
        LevelExpInt = PlayerPrefs.GetInt("LevelExp", 0);
        CoinInt = PlayerPrefs.GetInt("Coin", 0); // PlayerPrefs 내에 저장되어있는 'Coin'을 불러와 CoinInt에 저장합니다. 만약에 저장된 정보가 없다면 0을 저장합니다.

        UpgradeTimeCheck = PlayerPrefs.GetInt("TimeCheck", 0);
        UpgradeMoneyCheck = PlayerPrefs.GetInt("MoneyCheck", 0);
        UpgradeExpCheck = PlayerPrefs.GetInt("ExpCheck", 0);

        Coinprice = 0;
        PanCount = 0;
        ToCount = 0;
        SyCount = 0;
        FuCount = 0;

        //LevelInt -= 1;
        //LevelExpInt += 240;
        //Coinprice += 10000;
        //CoinInt += Coinprice;
        //Coinprice = 0;
        LevelUp();

        if(LevelExpInt == 0)
        {
            FoodRandomPick.instance.ResetData();
            FoodCheck.instance.StackReset();
            HamsterManual.instance.ResetHeart();
        }
    }
    public void GiveMoney()
    {
        CoinInt += 1000;
    }

    public void LevelUp() {

        int Level = 50 * (LevelInt * LevelInt) + 50 * LevelInt;

                
        if (Level < LevelExpInt)               
        {                   
            LevelInt += 1;                  
            Levelup.SetActive(true);                 
            LevelUpText.text = LevelInt.ToString();  
                
            if(LevelInt > 0)
            {
                LevelUpExpText.text = "5";
                LevelUpMoneyText.text = "20";
                LevelExpInt += 5;
                CoinInt += 20;
            }
            if (LevelInt > 9)
            {
                LevelUpExpText.text = "10";
                LevelUpMoneyText.text = "40";
                LevelExpInt += 10;
                CoinInt += 40;
            }
            if (LevelInt > 19)
            {
                LevelUpExpText.text = "15";
                LevelUpMoneyText.text = "60";
                LevelExpInt += 15;
                CoinInt += 60;
            }
            if (LevelInt > 29)
            {
                LevelUpExpText.text = "20";
                LevelUpMoneyText.text = "80";
                LevelExpInt += 20;
                CoinInt += 80;
            }
            if (LevelInt > 39)
            {
                LevelUpExpText.text = "25";
                LevelUpMoneyText.text = "100";
                LevelExpInt += 25;
                CoinInt += 100;
            }
            if (LevelInt > 49)
            {
                LevelUpExpText.text = "30";
                LevelUpMoneyText.text = "120";
                LevelExpInt += 30;
                CoinInt += 120;
            }
            if (LevelInt > 59)
            {
                LevelUpExpText.text = "35";
                LevelUpMoneyText.text = "140";
                LevelExpInt += 35;
                CoinInt += 140;
            }
            if (LevelInt > 69)
            {
                LevelUpExpText.text = "40";
                LevelUpMoneyText.text = "160";
                LevelExpInt += 40;
                CoinInt += 160;
            }
            if (LevelInt > 79)
            {
                LevelUpExpText.text = "45";
                LevelUpMoneyText.text = "180";
                LevelExpInt += 45;
                CoinInt += 180;
            }
            if (LevelInt > 89)
            {
                LevelUpExpText.text = "50";
                LevelUpMoneyText.text = "200";
                LevelExpInt += 50;
                CoinInt += 200;
            }
            if (LevelInt > 99)
            {
                LevelUpExpText.text = "55";
                LevelUpMoneyText.text = "220";
                LevelExpInt += 55;
                CoinInt += 220;
            }
        }

        Debug.Log("LevelInt : " + LevelInt);
        Debug.Log("Level : " + Level);
       
    }
    public void LevelUpExit()
    {
        Levelup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(UpgradeTimeCheck == 0)
        {
            TiMoneyText.text = "500";
        }
        if (UpgradeTimeCheck == 1)
        {
            TiMoneyText.text = "1000";
        }
        if (UpgradeTimeCheck == 2)
        {
            TiMoneyText.text = "1500";
        }
        if (UpgradeTimeCheck == 3)
        {
            TiMoneyText.text = "2000";
        }
        if (UpgradeTimeCheck == 4)
        {
            TiMoneyText.text = "2500";
        }

        if (UpgradeMoneyCheck == 0)
        {
            MoMoneyText.text = "500";
        }
        if (UpgradeMoneyCheck == 1)
        {
            MoMoneyText.text = "1000";
        }
        if (UpgradeMoneyCheck == 2)
        {
            MoMoneyText.text = "1500";
        }
        if (UpgradeMoneyCheck == 3)
        {
            MoMoneyText.text = "2000";
        }
        if (UpgradeMoneyCheck == 4)
        {
            MoMoneyText.text = "2500";
        }

        if (UpgradeExpCheck == 0)
        {
            ExMoneyText.text = "500";
        }
        if (UpgradeExpCheck == 1)
        {
            ExMoneyText.text = "1000";
        }
        if (UpgradeExpCheck == 2)
        {
            ExMoneyText.text = "1500";
        }
        if (UpgradeExpCheck == 3)
        {
            ExMoneyText.text = "2000";
        }
        if (UpgradeExpCheck == 4)
        {
            ExMoneyText.text = "2500";
        }
        //Debug.Log(LevelExpInt);
        //Debug.Log(CoinInt);

        PlayerPrefs.SetInt("Level", LevelInt);
        PlayerPrefs.SetInt("LevelExp", LevelExpInt);
        PlayerPrefs.SetInt("Coin", CoinInt); // CoinInt를 PlayerPrefs 내에  저장되어있는 'Coin'에 저장합니다.

        PlayerPrefs.SetInt("TimeCheck", UpgradeTimeCheck);
        PlayerPrefs.SetInt("MoneyCheck", UpgradeMoneyCheck);
        PlayerPrefs.SetInt("ExpCheck", UpgradeExpCheck);

        LevelText.text = LevelInt.ToString();
        LevelExpText.text = LevelExpInt.ToString();
        CoinText.text = CoinInt.ToString(); //CoinText의 Text에 CoinInt를 출력합니다.

    }
    public void PancakeStoreBuy(string buttonTag) // 상점에서 구매할때
    {
        if (buttonTag == "ChocoP")
        {
            if (CoinInt >= 100)
            {
                YesMoney.SetActive(true);
                PanCount += 2;
                Coinprice += 100;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "StrawberryP")
        {
            if (CoinInt >= 300)
            {
                YesMoney.SetActive(true);
                PanCount += 3;
                Coinprice += 300;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Green tea")
        {
            if (CoinInt >= 400)
            {
                YesMoney.SetActive(true);
                PanCount += 4;
                Coinprice += 400;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Coffee")
        {
            if (CoinInt >= 500)
            {
                YesMoney.SetActive(true);
                PanCount += 5;
                Coinprice += 500;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "MintP")
        {
            if (CoinInt >= 550)
            {
                YesMoney.SetActive(true);
                PanCount += 6;
                Coinprice += 550;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Black sesame seed")
        {
            if (CoinInt >= 600)
            {
                YesMoney.SetActive(true);
                PanCount += 7;
                Coinprice += 600;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Glacier")
        {
            if (CoinInt >= 800)
            {
                YesMoney.SetActive(true);
                PanCount += 8;
                Coinprice += 800;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Lava")
        {
            if (CoinInt >= 1000)
            {
                YesMoney.SetActive(true);
                PanCount += 9;
                Coinprice += 1000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
    }
    public void ToppingStoreBuy(string buttonTag) // 상점에서 구매할때
    {

        if (buttonTag == "Butter")
        {
            if (CoinInt >= 100)
            {
                YesMoney.SetActive(true);
                ToCount += 3;
                Coinprice += 100;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Green grape")
        {
            if (CoinInt >= 200)
            {
                YesMoney.SetActive(true);
                ToCount += 4;
                Coinprice += 200;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Hub")
        {
            if (CoinInt >= 300)
            {
                YesMoney.SetActive(true);
                ToCount += 5;
                Coinprice += 300;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Banana")
        {
            if (CoinInt >= 350)
            {
                YesMoney.SetActive(true);
                ToCount += 6;
                Coinprice += 350;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Whipped cream")
        {
            if (CoinInt >= 400)
            {
                YesMoney.SetActive(true);
                ToCount += 7;
                Coinprice += 400;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Pistachio")
        {
            if (CoinInt >= 550)
            {
                YesMoney.SetActive(true);
                ToCount += 8;
                Coinprice += 550;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Raspberry")
        {
            if (CoinInt >= 600)
            {
                YesMoney.SetActive(true);
                ToCount += 9;
                Coinprice += 600;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Walnuts")
        {
            if (CoinInt >= 800)
            {
                YesMoney.SetActive(true);
                ToCount += 10;
                Coinprice += 800;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Almond")
        {
            if (CoinInt >= 1000)
            {
                YesMoney.SetActive(true);
                ToCount += 11;
                Coinprice += 1000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
    }
    public void SyrupStoreBuy(string buttonTag) // 상점에서 구매할때
    {
        if (buttonTag == "ChocoS")
        {
            if (CoinInt >= 100)
            {
                YesMoney.SetActive(true);
                SyCount += 2;
                Coinprice += 100;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "StrawberryS")
        {
            if (CoinInt >= 300)
            {
                YesMoney.SetActive(true);
                SyCount += 3;
                Coinprice += 300;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Orange")
        {
            if (CoinInt >= 500)
            {
                YesMoney.SetActive(true);
                SyCount += 4;
                Coinprice += 500;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "MintS")
        {
            if (CoinInt >= 700)
            {
                YesMoney.SetActive(true);
                SyCount += 5;
                Coinprice += 700;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Green teaS")
        {
            if (CoinInt >= 850)
            {
                YesMoney.SetActive(true);
                SyCount += 6;
                Coinprice += 850;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "LavaS")
        {
            if (CoinInt >= 1000)
            {
                YesMoney.SetActive(true);
                SyCount += 7;
                Coinprice += 1000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
    }
    public void FurnitureStoreBuy(string buttonTag) // 상점에서 구매할때
    {
        if (buttonTag == "Flowerpot")
        {
            if (CoinInt >= 1000)
            {
                YesMoney.SetActive(true);
                FuCount += 2;
                Coinprice += 1000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Curtain")
        {
            if (CoinInt >= 2000)
            {
                YesMoney.SetActive(true);
                FuCount += 3;
                Coinprice += 2000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Shelf")
        {
            if (CoinInt >= 3000)
            {
                YesMoney.SetActive(true);
                FuCount += 4;
                Coinprice += 3000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Carpet")
        {
            if (CoinInt >= 4000)
            {
                YesMoney.SetActive(true);
                FuCount += 5;
                Coinprice += 4000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Sofa")
        {
            if (CoinInt >= 5000)
            {
                YesMoney.SetActive(true);
                FuCount += 6;
                Coinprice += 5000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Treadmill")
        {
            if (CoinInt >= 6000)
            {
                YesMoney.SetActive(true);
                FuCount += 7;
                Coinprice += 6000;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
    }
    public void UpgradeStoreBuy(string buttonTag) // 상점에서 구매할때
    {
        if (buttonTag == "UpgradeTime")
        {
            UpgradeBuyCheck = 1;
            Debug.Log("업글타임숫자체크 :" + UpgradeTimeCheck);
            if (UpgradeTimeCheck == 0)
            {
                if (CoinInt >= 500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeTimeCheck == 1)
            {
                if (CoinInt >= 1000)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 1000;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeTimeCheck == 2)
            {
                if (CoinInt >= 1500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 1500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeTimeCheck == 3)
            {
                if (CoinInt >= 2000)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 2000;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeTimeCheck == 4)
            {
                if (CoinInt >= 2500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 2500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
        }
        if (buttonTag == "UpgradeMoney")
        {
            UpgradeBuyCheck = 2;
            Debug.Log("업글머니숫자체크 :" + UpgradeMoneyCheck);
            if (UpgradeMoneyCheck == 0)
            {
                if (CoinInt >= 500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeMoneyCheck == 1)
            {
                if (CoinInt >= 1000)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 1000;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeMoneyCheck == 2)
            {
                if (CoinInt >= 1500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 1500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeMoneyCheck == 3)
            {
                if (CoinInt >= 2000)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 2000;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeMoneyCheck == 4)
            {
                if (CoinInt >= 2500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 2500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
        }
        if (buttonTag == "UpgradeExp")
        {
            UpgradeBuyCheck = 3;
            Debug.Log("업글이엑스피숫자체크 :" + UpgradeExpCheck);
            if (UpgradeExpCheck == 0)
            {
                if (CoinInt >= 500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeExpCheck == 1)
            {
                if (CoinInt >= 1000)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 1000;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeExpCheck == 2)
            {
                if (CoinInt >= 1500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 1500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeExpCheck == 3)
            {
                if (CoinInt >= 2000)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 2000;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
            if (UpgradeExpCheck == 4)
            {
                if (CoinInt >= 2500)
                {
                    YesMoney.SetActive(true);
                    Coinprice += 2500;
                }
                else // 만약에 부족하다면
                {
                    NoMoney.SetActive(true);
                    UpgradeBuyCheck = 0;
                }
            }
        }


    }
    public void NoMoneyExit()
    {
        NoMoney.SetActive(false);
    }
    public void YesMoneyBuy()
    {
        POP.Play();
        CoinInt -= Coinprice;
        Coinprice = 0;
        YesMoney.SetActive(false);
        if (PanCount >= 1)
        {
            //만들기에 잠금해제
            if (PanCount == 2)
            {
                DataManager.UnlockPancake("ChocoP Lock");
                DataManager.UnlockStoreMenu("ChocoP locked");
            }
            if (PanCount == 3)
            {
                DataManager.UnlockPancake("StrawberryP Lock");
                DataManager.UnlockStoreMenu("StrawberryP locked");
            }
            if (PanCount == 4)
            {
                DataManager.UnlockPancake("Green tea Lock");
                DataManager.UnlockStoreMenu("Green tea locked");
            }
            if (PanCount == 5)
            {
                DataManager.UnlockPancake("Coffee Lock");
                DataManager.UnlockStoreMenu("Coffee locked");
            }
            if (PanCount == 6)
            {
                DataManager.UnlockPancake("MintP Lock");
                DataManager.UnlockStoreMenu("MintP locked");
            }
            if (PanCount == 7)
            {
                DataManager.UnlockPancake("Black sesame seed Lock");
                DataManager.UnlockStoreMenu("Black sesame seed locked");
            }
            if (PanCount == 8)
            {
                DataManager.UnlockPancake("Glacier Lock");
                DataManager.UnlockStoreMenu("Glacier locked");
            }
            if (PanCount == 9)
            {
                DataManager.UnlockPancake("Lava Lock");
                DataManager.UnlockStoreMenu("Lava locked");
            }
            //푸드랜덤픽에 등장하게 만들기
            FoodRandomPick.instance.pancakeunlock(PanCount);
            PanCount = 0;
        }
        if (ToCount >= 1)
        {

            //만들기에 잠금해제
            if (ToCount == 3)
            {
                DataManager.UnlockTopping("Butter Lock");
                DataManager.UnlockStoreMenu("Butter locked");
            }
            if (ToCount == 4)
            {
                DataManager.UnlockTopping("Green grape Lock");
                DataManager.UnlockStoreMenu("Green grape locked");
            }
            if (ToCount == 5)
            {
                DataManager.UnlockTopping("Hub Lock");
                DataManager.UnlockStoreMenu("Hub locked");
            }
            if (ToCount == 6)
            {
                DataManager.UnlockTopping("Banana Lock");
                DataManager.UnlockStoreMenu("Banana locked");
            }
            if (ToCount == 7)
            {
                DataManager.UnlockTopping("Whipped cream Lock");
                DataManager.UnlockStoreMenu("Whipped cream locked");
            }
            if (ToCount == 8)
            {
                DataManager.UnlockTopping("Pistachio Lock");
                DataManager.UnlockStoreMenu("Pistachio locked");
            }
            if (ToCount == 9)
            {
                DataManager.UnlockTopping("Raspberry Lock");
                DataManager.UnlockStoreMenu("Raspberry locked");
            }
            if (ToCount == 10)
            {
                DataManager.UnlockTopping("Walnuts Lock");
                DataManager.UnlockStoreMenu("Walnuts locked");
            }
            if (ToCount == 11)
            {
                DataManager.UnlockTopping("Almond Lock");
                DataManager.UnlockStoreMenu("Almond locked");
            }
            //푸드랜덤픽에 등장하게 만들기
            FoodRandomPick.instance.toppingunlock(ToCount);
            ToCount = 0;
        }
        if (SyCount >= 1)
        {
            //만들기에 잠금해제     
            if (SyCount == 2)
            {
                DataManager.UnlockSyrup("ChocoS Lock");
                DataManager.UnlockStoreMenu("ChocoS locked");
            }
            if (SyCount == 3)
            {
                DataManager.UnlockSyrup("StrawberryS Lock");
                DataManager.UnlockStoreMenu("StrawberryS locked");
            }
            if (SyCount == 4)
            {
                DataManager.UnlockSyrup("Orange Lock");
                DataManager.UnlockStoreMenu("Orange locked");
            }
            if (SyCount == 5)
            {
                DataManager.UnlockSyrup("MintS Lock");
                DataManager.UnlockStoreMenu("MintS locked");
            }
            if (SyCount == 6)
            {
                DataManager.UnlockSyrup("Green teaS Lock");
                DataManager.UnlockStoreMenu("Green teaS locked");
            }
            if (SyCount == 7)
            {
                DataManager.UnlockSyrup("LavaS Lock");
                DataManager.UnlockStoreMenu("LavaS locked");
            }
            //푸드랜덤픽에 등장하게 만들기
            FoodRandomPick.instance.syrupunlock(SyCount);
            SyCount = 0;
        }
        if (FuCount >= 1)
        {
            //만들기에 잠금해제     
            if (FuCount == 2)
            {
                //가구 오브젝트를 잠시 활성화 시킴
                Flowerpot.SetActive(true);

                DataManager.UnlockFurniture("Flowerpot Lock");
                DataManager.UnlockStoreMenu("Flowerpot locked");
            }
            if (FuCount == 3)
            {
                Curtain.SetActive(true);

                DataManager.UnlockFurniture("Curtain Lock");
                DataManager.UnlockStoreMenu("Curtain locked");
            }
            if (FuCount == 4)
            {
                Shelf.SetActive(true);

                DataManager.UnlockFurniture("Shelf Lock");
                DataManager.UnlockStoreMenu("Shelf locked");
            }
            if (FuCount == 5)
            {
                Carpet.SetActive(true);

                DataManager.UnlockFurniture("Carpet Lock");
                DataManager.UnlockStoreMenu("Carpet locked");
            }
            if (FuCount == 6)
            {
                Sofa.SetActive(true);

                DataManager.UnlockFurniture("Sofa Lock");
                DataManager.UnlockStoreMenu("Sofa locked");
            }
            if (FuCount == 7)
            {
                Treadmill.SetActive(true);

                DataManager.UnlockFurniture("Treadmill Lock");
                DataManager.UnlockStoreMenu("Treadmill locked");
            }                      
            FuCount = 0;
        }
        if (UpgradeBuyCheck == 1)
        {
            UpgradeBuyCheck = 0;
            YesMoney.SetActive(false);
            UpgradeManager.instance.Upgradetime += 1;           
            UpgradeManager.instance.Restart();
        }
        if (UpgradeBuyCheck == 2)
        {
            UpgradeBuyCheck = 0;
            YesMoney.SetActive(false);
            UpgradeManager.instance.Upgrademoney += 1;         
            UpgradeManager.instance.Restart();
        }
        if (UpgradeBuyCheck == 3)
        {
            UpgradeBuyCheck = 0;
            YesMoney.SetActive(false);
            UpgradeManager.instance.Upgradeexp += 1;          
            UpgradeManager.instance.Restart();
        }
    }
        public void YesMoneyExit()
    {
        POP.Play();
        YesMoney.SetActive(false);
        Coinprice = 0;
    }
}
