using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCheck : MonoBehaviour
{
    public static FoodCheck instance;

    public GameObject RandomFoodImage;
    public GameObject HamsterCage;

    public GameObject MakeButton;

    public GameObject Success;
    public GameObject Soso;
    public GameObject Fail;

    public GameObject MoneyExpAnim;

    int RandomTocount;

    int WantPancheck;
    int WantToppingCheck;
    int WantToppingCheck1;
    int WantSyrupCheck;

    int MakePancheck;
    int MakeToppingCheck;
    int MakeToppingCheck1;
    int MakeSyrupCheck;

    int pancakeMoney;
    int toppingMoney;
    int topping1Money;
    int syrupMoney;
    int TotalMoney;

    int hamNum;

    int Answer = 0;

    public int UpgradeMoney;
    public int UpgradeExp;

    public static int UnlockHamStack;

    private void Awake()
    {
        FoodCheck.instance = this;
    }
    private void Start()
    {
        UnlockHamStack = PlayerPrefs.GetInt("Stack", 0);
        Debug.Log("startAnwsercount" + Answer); 
    }
    public void StackReset()
    {
        UnlockHamStack = PlayerPrefs.GetInt("Stack", 0);
        UnlockHamStack = 0;
        PlayerPrefs.SetInt("Stack", UnlockHamStack);
    }
    public void GiveStack()
    {
        UnlockHamStack += 50;
        if (UnlockHamStack == 50f)
        {
            FoodRandomPick.instance.hamsterunlock(4);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H4();
            DataManager.UnlockEncyclopedia("Hamster in kindergarten Lock");
        }
        if (UnlockHamStack == 100f)
        {
            FoodRandomPick.instance.hamsterunlock(5);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H5();
            DataManager.UnlockEncyclopedia("Vacation hamster Lock");
        }
        if (UnlockHamStack == 150f)
        {
            FoodRandomPick.instance.hamsterunlock(6);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H6();
            DataManager.UnlockEncyclopedia("an office worker hamster Lock");
        }
        if (UnlockHamStack == 200f)
        {
            FoodRandomPick.instance.hamsterunlock(7);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H7();
            DataManager.UnlockEncyclopedia("Strawberry hamster Lock");
        }
        if (UnlockHamStack == 250f)
        {
            FoodRandomPick.instance.hamsterunlock(8);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H8();
            DataManager.UnlockEncyclopedia("Mint chocolate hamster Lock");
        }
        if (UnlockHamStack == 300f)
        {
            FoodRandomPick.instance.hamsterunlock(9);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H9();
            DataManager.UnlockEncyclopedia("a suspicious hamster Lock");
        }
        if (UnlockHamStack == 350f)
        {
            FoodRandomPick.instance.hamsterunlock(10);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H10();
            DataManager.UnlockEncyclopedia("Idol hamster Lock");
        }
        if (UnlockHamStack == 400f)
        {
            FoodRandomPick.instance.hamsterunlock(11);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H11();
            DataManager.UnlockEncyclopedia("Fire hamster Lock");
        }
        if (UnlockHamStack == 450f)
        {
            FoodRandomPick.instance.hamsterunlock(12);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H12();
            DataManager.UnlockEncyclopedia("Wizard hamster Lock");
        }
        if (UnlockHamStack == 500f)
        {
            FoodRandomPick.instance.hamsterunlock(13);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H13();
            DataManager.UnlockEncyclopedia("Ice queen hamster Lock");
        }
        PlayerPrefs.SetInt("Stack", UnlockHamStack);
    }
    public void foodCheck()
    {
        StartCoroutine(Fcheck());
    }
    IEnumerator Fcheck()
    {
        RandomTocount = FoodRandomPick.instance.ToppingCount;

        hamNum = FoodRandomPick.instance.HamNumber;

        WantPancheck = FoodRandomPick.instance.PancakeNumber;
        WantToppingCheck = FoodRandomPick.instance.RToppingNumber;
        WantToppingCheck1 = FoodRandomPick.instance.RToppingNumber1;
        WantSyrupCheck = FoodRandomPick.instance.SyrupNumber;

        MakePancheck = MakeFood.instance.pannum;
        MakeToppingCheck = MakeFood.instance.tonum;
        MakeToppingCheck1 = MakeFood.instance.tonum1;
        MakeSyrupCheck = MakeFood.instance.synum;

        pancakeMoney = MakeFood.instance.PancakeMoney;
        toppingMoney = MakeFood.instance.ToppingMoney;
        topping1Money = MakeFood.instance.Topping1Money;
        syrupMoney = MakeFood.instance.SyrupMoney;

        RandomFoodImage.SetActive(false);

        Debug.Log("WantPancheck :" + WantPancheck);
        Debug.Log("WantToppingCheck :" + WantToppingCheck);
        Debug.Log("WantToppingCheck1 :" + WantToppingCheck1);
        Debug.Log("WantSyrupCheck :" + WantSyrupCheck);

        Debug.Log("MakePancheck :" + MakePancheck);
        Debug.Log("MakeToppingCheck :" + MakeToppingCheck);
        Debug.Log("MakeToppingCheck1 :" + MakeToppingCheck1);
        Debug.Log("MakeSyrupCheck :" + MakeSyrupCheck);

        yield return new WaitForSeconds(3.0f);

        if (RandomTocount == 2)
        {
            if (WantPancheck == MakePancheck)
            {
                Answer += 1;
                TotalMoney += pancakeMoney;
            }
            if (WantToppingCheck == MakeToppingCheck || WantToppingCheck1 == MakeToppingCheck)
            {
                Answer += 1;
                TotalMoney += toppingMoney;
            }
            if (WantToppingCheck1 == MakeToppingCheck1 || WantToppingCheck == MakeToppingCheck1)
            {
                Answer += 1;
                TotalMoney += topping1Money;
            }
            if (WantSyrupCheck == MakeSyrupCheck)
            {
                Answer += 1;
                TotalMoney += syrupMoney;
            }

            // 랜덤으로 원하는 팬 케이크와 만든 팬 케이크가 같을 경우
            if (Answer == 4)
            {
                //하트 이미지
                Success.SetActive(true);

                MoneyData.CoinInt += (TotalMoney + UpgradeMoney);
                MoneyData.LevelExpInt += ((TotalMoney / 2) + UpgradeExp);
                MoneyData.instance.LevelUp();

                HamsterAnimation.Instance.Heart();

                MoneyExpAnim.SetActive(true);
                //경험치 추가
                //코인 추가               
            }
            if (Answer == 2 || Answer == 3)
            {
                //...이미지
                Soso.SetActive(true);

                MoneyData.CoinInt += (TotalMoney + UpgradeMoney);
                MoneyData.LevelExpInt += ((TotalMoney / 2) + UpgradeExp);
                MoneyData.instance.LevelUp();

                HamsterAnimation.Instance.Soso();

                MoneyExpAnim.SetActive(true);
                //경험치 추가
                //코인 추가
            }
            //랜덤으로 원하는 팬 케이크와 만든 팬 케이크가 다를 경우
            if (Answer == 1 || Answer == 0)
            {
                Fail.SetActive(true);

                HamsterAnimation.Instance.Angry();
                //꽝 이미지
            }
        }
        if (RandomTocount == 1)
        {
            if (WantPancheck == MakePancheck)
            {
                Answer += 1;
                TotalMoney += pancakeMoney;
            }
            if (WantToppingCheck == MakeToppingCheck)
            {
                Answer += 1;
                TotalMoney += toppingMoney;
            }
            if (WantSyrupCheck == MakeSyrupCheck)
            {
                Answer += 1;
                TotalMoney += syrupMoney;
            }
            if(MakeToppingCheck1 >= 1)
            {
                Answer -= 1;
            }

            // 랜덤으로 원하는 팬 케이크와 만든 팬 케이크가 같을 경우
            if (Answer == 3)
            {
                //하트 이미지
                Success.SetActive(true);

                MoneyData.CoinInt += (TotalMoney + UpgradeMoney);
                MoneyData.LevelExpInt += ((TotalMoney / 2) + UpgradeExp);
                MoneyData.instance.LevelUp();

                HamsterAnimation.Instance.Heart();

                MoneyExpAnim.SetActive(true);
                //경험치 추가
                //코인 추가
            }
            if (Answer == 2)
            {
                //...이미지
                Soso.SetActive(true);

                MoneyData.CoinInt += (TotalMoney + UpgradeMoney);
                MoneyData.LevelExpInt += ((TotalMoney / 2) + UpgradeExp);
                MoneyData.instance.LevelUp();

                HamsterAnimation.Instance.Soso();

                MoneyExpAnim.SetActive(true);
                //경험치 추가
                //코인 추가
            }
            //랜덤으로 원하는 팬 케이크와 만든 팬 케이크가 다를 경우
            if (Answer == 1 || Answer == 0)
            {
                Fail.SetActive(true);

                HamsterAnimation.Instance.Angry();
                //꽝 이미지
            }
        }
        Debug.Log("AnswerCheck :" + Answer);
        //햄스터가 좋아하는 음식과 만든 음식이 같을 경우
        if (hamNum == 1 && MakePancheck == 1 && (MakeToppingCheck == 1 || MakeToppingCheck == 2) && (MakeToppingCheck1 == 2 || MakeToppingCheck1 == 1) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.Basic();
        }
        if (hamNum == 1 && MakePancheck == 1 && (MakeToppingCheck == 2 || MakeToppingCheck == 3) && (MakeToppingCheck1 == 3 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.Basic();
        }

        if (hamNum == 2 && MakePancheck == 1 && (MakeToppingCheck == 4 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 4) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.Pearl();
        }
        if (hamNum == 2 && MakePancheck == 1 && (MakeToppingCheck == 2 || MakeToppingCheck == 4) && (MakeToppingCheck1 == 4 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.Pearl();
        }

        if (hamNum == 3 && MakePancheck == 1 && (MakeToppingCheck == 5 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 5) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.Snow();
        }
        if (hamNum == 3 && MakePancheck == 1 && (MakeToppingCheck == 2 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.Snow();
        }

        if (hamNum == 4 && MakePancheck == 1 && (MakeToppingCheck == 2 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.kindergarten();
        }
        if (hamNum == 4 && MakePancheck == 2 && (MakeToppingCheck == 1 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 1) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.kindergarten();
        }

        if (hamNum == 5 && MakePancheck == 1 && (MakeToppingCheck == 2 || MakeToppingCheck == 6) && (MakeToppingCheck1 == 6 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.Vacation();
        }
        if (hamNum == 5 && MakePancheck == 1 && (MakeToppingCheck == 2 || MakeToppingCheck == 4) && (MakeToppingCheck1 == 4 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 6)
        {
            HamsterManual.instance.Vacation();
        }

        if (hamNum == 6 && MakePancheck == 5 && (MakeToppingCheck == 7 || MakeToppingCheck == 11) && (MakeToppingCheck1 == 11 || MakeToppingCheck1 == 7) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.anofficeworker();
        }
        if (hamNum == 6 && MakePancheck == 5 && (MakeToppingCheck == 7 || MakeToppingCheck == 10) && (MakeToppingCheck1 == 10 || MakeToppingCheck1 == 7) && MakeSyrupCheck == 1)
        {
            HamsterManual.instance.anofficeworker();
        }

        if (hamNum == 7 && MakePancheck == 1 && (MakeToppingCheck == 1 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 1) && MakeSyrupCheck == 3)
        {
            HamsterManual.instance.Strawberry();
        }
        if (hamNum == 7 && MakePancheck == 3 && (MakeToppingCheck == 1 || MakeToppingCheck == 6) && (MakeToppingCheck1 == 6 || MakeToppingCheck1 == 1) && MakeSyrupCheck == 3)
        {
            HamsterManual.instance.Strawberry();
        }

        if (hamNum == 8 && MakePancheck == 6 && (MakeToppingCheck == 5 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 5) && MakeSyrupCheck == 5)
        {
            HamsterManual.instance.Mintchocolate();
        }
        if (hamNum == 8 && MakePancheck == 6 && (MakeToppingCheck == 5 || MakeToppingCheck == 6) && (MakeToppingCheck1 == 6 || MakeToppingCheck1 == 5) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.Mintchocolate();
        }

        if (hamNum == 9 && MakePancheck == 1 && (MakeToppingCheck == 2 || MakeToppingCheck == 9) && (MakeToppingCheck1 == 9 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.Suspicious();
        }
        if (hamNum == 9 && MakePancheck == 7 && (MakeToppingCheck == 7 || MakeToppingCheck == 9) && (MakeToppingCheck1 == 9 || MakeToppingCheck1 == 7) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.Suspicious();
        }

        if (hamNum == 10 && MakePancheck == 1 && (MakeToppingCheck == 7 || MakeToppingCheck == 9) && (MakeToppingCheck1 == 9 || MakeToppingCheck1 == 7) && MakeSyrupCheck == 3)
        {
            HamsterManual.instance.Idol();
        }
        if (hamNum == 10 && MakePancheck == 3 && (MakeToppingCheck == 1 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 1) && MakeSyrupCheck == 5)
        {
            HamsterManual.instance.Idol();
        }

        if (hamNum == 11 && MakePancheck == 9 && (MakeToppingCheck == 7 || MakeToppingCheck == 10) && (MakeToppingCheck1 == 10 || MakeToppingCheck1 == 7) && MakeSyrupCheck == 7)
        {
            HamsterManual.instance.Fire();
        }
        if (hamNum == 11 && MakePancheck == 7 && (MakeToppingCheck == 9 || MakeToppingCheck == 10) && (MakeToppingCheck1 == 10 || MakeToppingCheck1 == 9) && MakeSyrupCheck == 7)
        {
            HamsterManual.instance.Fire();
        }

        if (hamNum == 12 && MakePancheck == 4 && (MakeToppingCheck == 2 || MakeToppingCheck == 4) && (MakeToppingCheck1 == 4 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.Wizard();
        }
        if (hamNum == 12 && MakePancheck == 7 && (MakeToppingCheck == 2 || MakeToppingCheck == 6) && (MakeToppingCheck1 == 6 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.Wizard();
        }

        if (hamNum == 13 && MakePancheck == 8 && (MakeToppingCheck == 2 || MakeToppingCheck == 7) && (MakeToppingCheck1 == 7 || MakeToppingCheck1 == 2) && MakeSyrupCheck == 5)
        {
            HamsterManual.instance.Icequeen();
        }
        if (hamNum == 13 && MakePancheck == 8 && (MakeToppingCheck == 3 || MakeToppingCheck == 5) && (MakeToppingCheck1 == 5 || MakeToppingCheck1 == 3) && MakeSyrupCheck == 2)
        {
            HamsterManual.instance.Icequeen();
        }

        yield return new WaitForSeconds(2.0f);

        Success.SetActive(false);
        Soso.SetActive(false);
        Fail.SetActive(false);

        MakeFood.instance.MPancakei1.SetActive(false);
        MakeFood.instance.MPancakei2.SetActive(false);
        MakeFood.instance.MPancakei3.SetActive(false);
        MakeFood.instance.MPancakei4.SetActive(false);
        MakeFood.instance.MPancakei5.SetActive(false);
        MakeFood.instance.MPancakei6.SetActive(false);
        MakeFood.instance.MPancakei7.SetActive(false);
        MakeFood.instance.MPancakei8.SetActive(false);
        MakeFood.instance.MPancakei9.SetActive(false);

        MakeFood.instance.MToppingi1.SetActive(false);
        MakeFood.instance.MToppingi2.SetActive(false);
        MakeFood.instance.MToppingi3.SetActive(false);
        MakeFood.instance.MToppingi4.SetActive(false);
        MakeFood.instance.MToppingi5.SetActive(false);
        MakeFood.instance.MToppingi6.SetActive(false);
        MakeFood.instance.MToppingi7.SetActive(false);
        MakeFood.instance.MToppingi8.SetActive(false);
        MakeFood.instance.MToppingi9.SetActive(false);
        MakeFood.instance.MToppingi10.SetActive(false);
        MakeFood.instance.MToppingi11.SetActive(false);

        MakeFood.instance.MSyrupi1.SetActive(false);
        MakeFood.instance.MSyrupi2.SetActive(false);
        MakeFood.instance.MSyrupi3.SetActive(false);
        MakeFood.instance.MSyrupi4.SetActive(false);
        MakeFood.instance.MSyrupi5.SetActive(false);
        MakeFood.instance.MSyrupi6.SetActive(false);
        MakeFood.instance.MSyrupi7.SetActive(false);

        HamsterCage.SetActive(false);
        MakeFood.instance.Dish.SetActive(false);

        FoodRandomPick.instance.resetandstart();

        //햄스터 해금

        UnlockHamStack += 1;     
        Debug.Log("UnlockHamStack :" + UnlockHamStack);

        if (UnlockHamStack == 50f)
        {
            FoodRandomPick.instance.hamsterunlock(4);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H4();
            DataManager.UnlockEncyclopedia("Hamster in kindergarten Lock");
        }
        if (UnlockHamStack == 100f)
        {
            FoodRandomPick.instance.hamsterunlock(5);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H5();
            DataManager.UnlockEncyclopedia("Vacation hamster Lock");
        }
        if (UnlockHamStack == 150f)
        {
            FoodRandomPick.instance.hamsterunlock(6);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H6();
            DataManager.UnlockEncyclopedia("an office worker hamster Lock");
        }
        if (UnlockHamStack == 200f)
        {
            FoodRandomPick.instance.hamsterunlock(7);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H7();
            DataManager.UnlockEncyclopedia("Strawberry hamster Lock");
        }
        if (UnlockHamStack == 250f)
        {
            FoodRandomPick.instance.hamsterunlock(8);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H8();
            DataManager.UnlockEncyclopedia("Mint chocolate hamster Lock");
        }
        if (UnlockHamStack == 300f)
        {
            FoodRandomPick.instance.hamsterunlock(9);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H9();
            DataManager.UnlockEncyclopedia("a suspicious hamster Lock");
        }
        if (UnlockHamStack == 350f)
        {
            FoodRandomPick.instance.hamsterunlock(10);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H10();
            DataManager.UnlockEncyclopedia("Idol hamster Lock");
        }
        if (UnlockHamStack == 400f)
        {
            FoodRandomPick.instance.hamsterunlock(11);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H11();
            DataManager.UnlockEncyclopedia("Fire hamster Lock");
        }
        if (UnlockHamStack == 450f)
        {
            FoodRandomPick.instance.hamsterunlock(12);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H12();
            DataManager.UnlockEncyclopedia("Wizard hamster Lock");
        }
        if (UnlockHamStack == 500f)
        {
            FoodRandomPick.instance.hamsterunlock(13);
            NewHamster.instance.NewHam.SetActive(true);
            NewHamster.instance.H13();
            DataManager.UnlockEncyclopedia("Ice queen hamster Lock");
        }
        PlayerPrefs.SetInt("Stack", UnlockHamStack);
        TotalMoney = 0;
        Answer = 0;
        MakeFood.instance.Deletenum();
        MakeButton.SetActive(true);
    }
}
