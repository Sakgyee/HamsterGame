using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDrag : MonoBehaviour
{
    private Vector3 m_Offset;
    private float m_ZCoord;

    public GameObject TablePosition;
    public GameObject RandomFoodImage;
    public GameObject HamsterCage;

    public GameObject MakeButton;
    public GameObject TrashButton;

    public GameObject Success;
    public GameObject Fail;

    Vector2 Startpo;
    Vector2 Tablepo;

    int RandomTocount;

    int WantPancheck;
    int WantToppingCheck;
    int WantToppingCheck1;
    int WantSyrupCheck;

    int MakePancheck;
    int MakeToppingCheck;
    int MakeToppingCheck1;
    int MakeSyrupCheck;

    int HamsterNum;
    int HamLikePan;
    int HamLikeTo;
    int HamLikeTo1;
    int HamLikeSy;

    int pancakeMoney;
    int toppingMoney;
    int topping1Money;
    int syrupMoney;
    int TotalMoney;

    bool MouseUp = true;

    int Answer;

    public int UpgradeMoney;
    public int UpgradeExp;

    public GameObject MoneyExpAnim;

    public static ImageDrag instance;
    private void Awake()
    {
        ImageDrag.instance = this;
    }
    private void Start()
    {
        Debug.Log("startAnwsercount" + Answer);
        Startpo = transform.position;
        Tablepo = TablePosition.transform.position;
    }
    void OnMouseDown()
    {
        m_ZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        m_Offset = gameObject.transform.position - GetMouseWorldPosition();
    }
    void OnMouseUp()
    {
        if (MouseUp == true)
        {
            transform.position = Startpo;
            }
    }
    void OnMouseDrag()
    {
    if (MouseUp == true)
    {
        transform.position = GetMouseWorldPosition() + m_Offset;
    }
    }

    Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = m_ZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.CompareTag("FoodDish"))
        {
            TrashButton.SetActive(false);
            Debug.Log("fooddish");
            MouseUp = false;
            transform.position = Tablepo;
            StartCoroutine(FoodCheck());
        }
    }

    IEnumerator FoodCheck()
    {
        RandomTocount = FoodRandomPick.instance.ToppingCount;

        WantPancheck = FoodRandomPick.instance.PancakeNumber;
        WantToppingCheck = FoodRandomPick.instance.RToppingNumber;
        WantToppingCheck1 = FoodRandomPick.instance.RToppingNumber1;
        WantSyrupCheck = FoodRandomPick.instance.SyrupNumber;

        MakePancheck = MakeFood.instance.pannum;
        MakeToppingCheck = MakeFood.instance.tonum;
        MakeToppingCheck1 = MakeFood.instance.tonum1;
        MakeSyrupCheck = MakeFood.instance.synum;

        
        HamsterNum = FoodRandomPick.instance.HamNumber;
        HamLikePan = FoodRandomPick.instance.LikePan;
        HamLikeTo = FoodRandomPick.instance.LikeTo;
        HamLikeTo1 = FoodRandomPick.instance.LikeTo1;
        HamLikeSy = FoodRandomPick.instance.LikeSy;

        pancakeMoney = MakeFood.instance.PancakeMoney;
        toppingMoney = MakeFood.instance.ToppingMoney;
        topping1Money = MakeFood.instance.Topping1Money;
        syrupMoney = MakeFood.instance.SyrupMoney;

        RandomFoodImage.SetActive(false);

        Debug.Log("WantPancheck :" + WantPancheck);
        Debug.Log("WantToppingCheck :" + WantToppingCheck);
        Debug.Log("WantToppingCheck1 :" + WantToppingCheck1);
        Debug.Log("WantSyrupCheck :" + WantSyrupCheck);

        Debug.Log("MakePancheck :"+MakePancheck);
        Debug.Log("MakeToppingCheck :"+ MakeToppingCheck);
        Debug.Log("MakeToppingCheck1 :"+ MakeToppingCheck1);
        Debug.Log("MakeSyrupCheck :"+ MakeSyrupCheck);

        Debug.Log("AnswerCheck :" + Answer);
        yield return new WaitForSeconds(3.0f);

        if(RandomTocount == 2)
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
            else if (Answer == 2 || Answer == 3)
            {
                //...이미지
                //Success.SetActive(true);

                MoneyData.CoinInt += (TotalMoney + UpgradeMoney);
                MoneyData.LevelExpInt += ((TotalMoney / 2) + UpgradeExp);
                MoneyData.instance.LevelUp();

                HamsterAnimation.Instance.Soso();

                MoneyExpAnim.SetActive(true);
                //경험치 추가
                //코인 추가
            }
            //랜덤으로 원하는 팬 케이크와 만든 팬 케이크가 다를 경우
            else if (Answer == 1)
            {
                Fail.SetActive(true);

                HamsterAnimation.Instance.Angry();
                //꽝 이미지
            }
        }
        if(RandomTocount == 1)
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
            else if (Answer == 2)
            {
                //...이미지
                //Success.SetActive(true);

                MoneyData.CoinInt += (TotalMoney + UpgradeMoney);
                MoneyData.LevelExpInt += ((TotalMoney / 2) + UpgradeExp);
                MoneyData.instance.LevelUp();

                HamsterAnimation.Instance.Soso();

                MoneyExpAnim.SetActive(true);
                //경험치 추가
                //코인 추가
            }
            //랜덤으로 원하는 팬 케이크와 만든 팬 케이크가 다를 경우
            else if (Answer == 1)
            {
                Fail.SetActive(true);

                HamsterAnimation.Instance.Angry();
                //꽝 이미지
            }
        }
        
        //햄스터가 좋아하는 음식과 만든 음식이 같을 경우
        if (HamsterNum == 1 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1)&& (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.Basic();
        }
        if (HamsterNum == 2 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.Strawberry();
        }
        if (HamsterNum == 3 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.Mintchocolate();
        }
        if (HamsterNum == 4 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.Vacation();
        }
        if (HamsterNum == 5 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.Snow();
        }
        if (HamsterNum == 6 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.Idol();
        }
        if (HamsterNum == 7 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.kindergarten();
        }
        if (HamsterNum == 8 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.anofficeworker();
        }
        if (HamsterNum == 9 && MakePancheck == HamLikePan && (MakeToppingCheck == HamLikeTo || MakeToppingCheck == HamLikeTo1) && (MakeToppingCheck1 == HamLikeTo1 || MakeToppingCheck1 == HamLikeTo) && MakeSyrupCheck == HamLikeSy)
        {
            HamsterManual.instance.Pearl();
        }
        yield return new WaitForSeconds(2.0f);

        Success.SetActive(false);
        Fail.SetActive(false);

        MouseUp = true;

        transform.position = Startpo;

        MakeFood.instance.Dish.SetActive(false);

        MakeFood.instance.MPancakei1.SetActive(false);
        MakeFood.instance.MPancakei2.SetActive(false);
        MakeFood.instance.MPancakei3.SetActive(false);

        MakeFood.instance.MToppingi1.SetActive(false);
        MakeFood.instance.MToppingi2.SetActive(false);
        MakeFood.instance.MToppingi3.SetActive(false);

        MakeFood.instance.MSyrupi1.SetActive(false);
        MakeFood.instance.MSyrupi2.SetActive(false);
        MakeFood.instance.MSyrupi3.SetActive(false);


        this.gameObject.SetActive(false);
        HamsterCage.SetActive(false);
        FoodRandomPick.instance.resetandstart();
        MakeButton.SetActive(true);

        TotalMoney = 0;
        Answer = 0;
    }

}
