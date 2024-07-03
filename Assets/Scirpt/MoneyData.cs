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

    int UpgradeBuyCheck;
    public int UpgradeTimeCheck;
    public int UpgradeMoneyCheck;
    public int UpgradeExpCheck;
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

        Coinprice = 0;
        PanCount = 0;
        ToCount = 0;
        SyCount = 0;

        //LevelInt -= 1;
        //LevelExpInt -= 300;

        LevelUp();
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
     
        //Debug.Log(LevelExpInt);
        //Debug.Log(CoinInt);

        PlayerPrefs.SetInt("Level", LevelInt);
        PlayerPrefs.SetInt("LevelExp", LevelExpInt);
        PlayerPrefs.SetInt("Coin", CoinInt); // CoinInt를 PlayerPrefs 내에  저장되어있는 'Coin'에 저장합니다.

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
            if (CoinInt >= 200)
            {
                YesMoney.SetActive(true);
                PanCount += 3;
                Coinprice += 200;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Green tea")
        {
            if (CoinInt >= 300)
            {
                YesMoney.SetActive(true);
                PanCount += 4;
                Coinprice += 300;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Coffee")
        {
            if (CoinInt >= 400)
            {
                YesMoney.SetActive(true);
                PanCount += 5;
                Coinprice += 400;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "MintP")
        {
            if (CoinInt >= 500)
            {
                YesMoney.SetActive(true);
                PanCount += 6;
                Coinprice += 500;
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
            if (CoinInt >= 700)
            {
                YesMoney.SetActive(true);
                PanCount += 8;
                Coinprice += 700;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Lava")
        {
            if (CoinInt >= 800)
            {
                YesMoney.SetActive(true);
                PanCount += 9;
                Coinprice += 800;
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
            if (CoinInt >= 400)
            {
                YesMoney.SetActive(true);
                ToCount += 6;
                Coinprice += 400;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Whipped cream")
        {
            if (CoinInt >= 500)
            {
                YesMoney.SetActive(true);
                ToCount += 7;
                Coinprice += 500;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Pistachio")
        {
            if (CoinInt >= 600)
            {
                YesMoney.SetActive(true);
                ToCount += 8;
                Coinprice += 600;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Raspberry")
        {
            if (CoinInt >= 700)
            {
                YesMoney.SetActive(true);
                ToCount += 9;
                Coinprice += 700;
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
            if (CoinInt >= 900)
            {
                YesMoney.SetActive(true);
                ToCount += 11;
                Coinprice += 900;
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
            if (CoinInt >= 200)
            {
                YesMoney.SetActive(true);
                SyCount += 3;
                Coinprice += 200;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Orange")
        {
            if (CoinInt >= 300)
            {
                YesMoney.SetActive(true);
                SyCount += 4;
                Coinprice += 300;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "MintS")
        {
            if (CoinInt >= 400)
            {
                YesMoney.SetActive(true);
                SyCount += 5;
                Coinprice += 400;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "Green teaS")
        {
            if (CoinInt >= 500)
            {
                YesMoney.SetActive(true);
                SyCount += 6;
                Coinprice += 500;
            }
            else // 만약에 부족하다면
            {
                NoMoney.SetActive(true);
            }
        }
        if (buttonTag == "LavaS")
        {
            if (CoinInt >= 600)
            {
                YesMoney.SetActive(true);
                SyCount += 7;
                Coinprice += 600;
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
                }
            }
        }


    }
    public void NoMoneyExit()
    {
        //Coinprice += 10000;
        //CoinInt += Coinprice;
        NoMoney.SetActive(false);
    }
    public void YesMoneyBuy()
    {
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
        if(UpgradeBuyCheck == 1)
        {
            YesMoney.SetActive(false);
            UpgradeManager.instance.Upgradetime += 1;
            UpgradeBuyCheck = 0;
            UpgradeManager.instance.Restart();
        }
        if (UpgradeBuyCheck == 2)
        {
            YesMoney.SetActive(false);
            UpgradeManager.instance.Upgrademoney += 1;
            UpgradeBuyCheck = 0;
            UpgradeManager.instance.Restart();
        }
        if (UpgradeBuyCheck == 3)
        {
            YesMoney.SetActive(false);
            UpgradeManager.instance.Upgradeexp += 1;
            UpgradeBuyCheck = 0;
            UpgradeManager.instance.Restart();
        }
    }
        public void YesMoneyExit()
    {
        YesMoney.SetActive(false);
        Coinprice = 0;
    }
}
