using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 직렬화 및 병렬화를 할 수 있도록 하지만 이 클래스가 직접하진 못한다.
// 이 클래스는 목록을 Unity의 JSON 유틸리티 기능과 호환되도록 하는 컨테이너 역할을 하여 목록을 JSON 문자열로 효과적으로 저장하고 로드함.
public class Serialization<T>
{
    public List<T> target;

    public Serialization(List<T> target)
    {
        this.target = target;
    }

    public List<T> ToList()
    {
        return target;
    }
}
public class FoodRandomPick : MonoBehaviour
{
    public static FoodRandomPick instance;

    public GameObject PPancakei1;
    public GameObject PPancakei2;
    public GameObject PPancakei3;
    public GameObject PPancakei4;
    public GameObject PPancakei5;
    public GameObject PPancakei6;
    public GameObject PPancakei7;
    public GameObject PPancakei8;
    public GameObject PPancakei9;

    public GameObject PToppingi1;
    public GameObject PToppingi2;
    public GameObject PToppingi3;
    public GameObject PToppingi4;
    public GameObject PToppingi5;
    public GameObject PToppingi6;
    public GameObject PToppingi7;
    public GameObject PToppingi8;
    public GameObject PToppingi9;
    public GameObject PToppingi10;
    public GameObject PToppingi11;

    public GameObject PSyrupi1;
    public GameObject PSyrupi2;
    public GameObject PSyrupi3;
    public GameObject PSyrupi4;
    public GameObject PSyrupi5;
    public GameObject PSyrupi6;
    public GameObject PSyrupi7;

    public int PancakeNumber;
    public int ToppingNumber;
    public int SyrupNumber;

    //랜덤 토핑 2개 넘버
    public int RToppingNumber;
    public int RToppingNumber1;

    public int HamNumber;

    public int ToppingCount;

    int SameCount;

    public GameObject RanHam1;
    public GameObject RanHam2;
    public GameObject RanHam3;
    public GameObject RanHam4;
    public GameObject RanHam5;
    public GameObject RanHam6;
    public GameObject RanHam7;
    public GameObject RanHam8;
    public GameObject RanHam9;
    public GameObject RanHam10;
    public GameObject RanHam11;
    public GameObject RanHam12;
    public GameObject RanHam13;

    public List<int> Panvalues = new List<int> {};
    public List<int> Tovalues = new List<int> { };
    public List<int> Syvalues = new List<int> { };

    public List<int> Hamvalues = new List<int> { };

    List<int> LikeToppingNumbers = new List<int>();

    private void Awake()
    {
        FoodRandomPick.instance = this;
    }
    public void RandomPickSaveData()
    {
        PlayerPrefs.SetString("Panvalues", JsonUtility.ToJson(new Serialization<int>(Panvalues)));
        PlayerPrefs.SetString("Tovalues", JsonUtility.ToJson(new Serialization<int>(Tovalues)));
        PlayerPrefs.SetString("Syvalues", JsonUtility.ToJson(new Serialization<int>(Syvalues)));
        PlayerPrefs.SetString("Hamvalues", JsonUtility.ToJson(new Serialization<int>(Hamvalues)));
        //PlayerPrefs.SetString("LikeToppingNumbers", JsonUtility.ToJson(new Serialization<int>(LikeToppingNumbers)));
    }

    public void RandomPickLoadData()
    {
        if (PlayerPrefs.HasKey("Panvalues"))
        {
            Panvalues = JsonUtility.FromJson<Serialization<int>>(PlayerPrefs.GetString("Panvalues")).ToList();
        }
        if (PlayerPrefs.HasKey("Tovalues"))
        {
            Tovalues = JsonUtility.FromJson<Serialization<int>>(PlayerPrefs.GetString("Tovalues")).ToList();
        }
        if (PlayerPrefs.HasKey("Syvalues"))
        {
            Syvalues = JsonUtility.FromJson<Serialization<int>>(PlayerPrefs.GetString("Syvalues")).ToList();
        }
        if (PlayerPrefs.HasKey("Hamvalues"))
        {
            Hamvalues = JsonUtility.FromJson<Serialization<int>>(PlayerPrefs.GetString("Hamvalues")).ToList();
        }
        /*
        if (PlayerPrefs.HasKey("LikeToppingNumbers"))
        {
            LikeToppingNumbers = JsonUtility.FromJson<Serialization<int>>(PlayerPrefs.GetString("LikeToppingNumbers")).ToList();
        }
        */
    }
    void Start()
    {

        //ResetData();
        //RandomPickSaveData();
        RandomPickLoadData();

        //RanHam1.SetActive(false);
        //RanHam2.SetActive(false);
        //RanHam3.SetActive(false);
        //RanHam4.SetActive(false);
        //RanHam5.SetActive(false);
        //RanHam6.SetActive(false);
        //RanHam7.SetActive(false);
        //RanHam8.SetActive(false);
        //RanHam9.SetActive(false);
        //RanHam10.SetActive(false);
        //RanHam11.SetActive(false);
        //RanHam12.SetActive(false);
        //RanHam13.SetActive(false);

        PPancakei1.SetActive(false);
        PPancakei2.SetActive(false);
        PPancakei3.SetActive(false);
        PPancakei4.SetActive(false);
        PPancakei5.SetActive(false);
        PPancakei6.SetActive(false);
        PPancakei7.SetActive(false);
        PPancakei8.SetActive(false);
        PPancakei9.SetActive(false);

        PToppingi1.SetActive(false);
        PToppingi2.SetActive(false);
        PToppingi3.SetActive(false);
        PToppingi4.SetActive(false);
        PToppingi5.SetActive(false);
        PToppingi6.SetActive(false);
        PToppingi7.SetActive(false);
        PToppingi8.SetActive(false);
        PToppingi9.SetActive(false);
        PToppingi10.SetActive(false);
        PToppingi11.SetActive(false);

        PSyrupi1.SetActive(false);
        PSyrupi2.SetActive(false);
        PSyrupi3.SetActive(false);
        PSyrupi4.SetActive(false);
        PSyrupi5.SetActive(false);
        PSyrupi6.SetActive(false);
        PSyrupi7.SetActive(false);

        for (int i = 1; i < 4; i++)
        {
            LikeToppingNumbers.Add(i);
        }
        
        HamNumber = Hamvalues[Random.Range(0, Hamvalues.Count)];
        if (HamNumber == 1)
            {
                RanHam1.SetActive(true);
            }
            if (HamNumber == 2)
            {
                RanHam2.SetActive(true);
            }
            if (HamNumber == 3)
            {
                RanHam3.SetActive(true);
            }
            if (HamNumber == 4)
            {
                RanHam4.SetActive(true);
            }
            if (HamNumber == 5)
            {
                RanHam5.SetActive(true);
            }
        if (HamNumber == 6)
        {
            RanHam6.SetActive(true);
        }
        if (HamNumber == 7)
        {
            RanHam7.SetActive(true);
        }
        if (HamNumber == 8)
        {
            RanHam8.SetActive(true);
        }
        if (HamNumber == 9)
        {
            RanHam9.SetActive(true);
        }
        if (HamNumber == 10)
        {
            RanHam10.SetActive(true);
        }
        if (HamNumber == 11)
        {
            RanHam11.SetActive(true);
        }
        if (HamNumber == 12)
        {
            RanHam12.SetActive(true);
        }
        if (HamNumber == 13)
        {
            RanHam13.SetActive(true);
        }

        PancakeNumber = Panvalues[Random.Range(0, Panvalues.Count)];
            if (PancakeNumber == 1)
            {
                PPancakei1.SetActive(true);
            }
            if (PancakeNumber == 2)
            {
                PPancakei2.SetActive(true);
            }
            if (PancakeNumber == 3)
            {
                PPancakei3.SetActive(true);
            }
        if (PancakeNumber == 4)
        {
            PPancakei4.SetActive(true);
        }
        if (PancakeNumber == 5)
        {
            PPancakei5.SetActive(true);
        }
        if (PancakeNumber == 6)
        {
            PPancakei6.SetActive(true);
        }
        if (PancakeNumber == 7)
        {
            PPancakei7.SetActive(true);
        }
        if (PancakeNumber == 8)
        {
            PPancakei8.SetActive(true);
        }
        if (PancakeNumber == 9)
        {
            PPancakei9.SetActive(true);
        }
        Debug.Log("PanNum"+PancakeNumber);


            ToppingCount = Random.Range(1, 3);
            Debug.Log("Toppingco :" + ToppingCount);

            List<int> ToppingNumbers = new List<int>();

        for (int i = 0; i < ToppingCount; i++)
        {
            if(i == 0)
            {
                ToppingNumber = Random.Range(0, Tovalues.Count) + 1;
                ToppingNumbers.Add(ToppingNumber);
                SameCount = ToppingNumber;
                switch (ToppingNumber)
                {
                    case 1:
                        PToppingi1.SetActive(true);
                        break;
                    case 2:
                        PToppingi2.SetActive(true);
                        break;
                    case 3:
                        PToppingi3.SetActive(true);
                        break;
                    case 4:
                        PToppingi4.SetActive(true);
                        break;
                    case 5:
                        PToppingi5.SetActive(true);
                        break;
                    case 6:
                        PToppingi6.SetActive(true);
                        break;
                    case 7:
                        PToppingi7.SetActive(true);
                        break;
                    case 8:
                        PToppingi8.SetActive(true);
                        break;
                    case 9:
                        PToppingi9.SetActive(true);
                        break;
                    case 10:
                        PToppingi10.SetActive(true);
                        break;
                    case 11:
                        PToppingi11.SetActive(true);
                        break;

                    default:
                        Debug.LogWarning("Invalid ToppingNumber: " + ToppingNumber);
                        break;
                }
                RToppingNumber = ToppingNumbers[0];

            }               
            if (i == 1)
            {
                ToppingNumber = Random.Range(0, Tovalues.Count) + 1;
                // 중복을 확인하고 중복될경우 다시 랜덤함수 돌리기
                // Contains 함수 : 문자열에 특정 문자열 포함 여부 확인하는 메소드
                if (SameCount == ToppingNumber)
                {
                    ToppingNumber = Random.Range(0, Tovalues.Count) + 1;
                    if(SameCount == ToppingNumber)
                    {
                        i--;
                        Debug.Log("i :" + i);
                    }
                    else
                    {
                        ToppingNumbers.Add(ToppingNumber);
                        RToppingNumber1 = ToppingNumbers[1];

                        switch (ToppingNumber)
                        {
                            case 1:
                                PToppingi1.SetActive(true);
                                break;
                            case 2:
                                PToppingi2.SetActive(true);
                                break;
                            case 3:
                                PToppingi3.SetActive(true);
                                break;
                            case 4:
                                PToppingi4.SetActive(true);
                                break;
                            case 5:
                                PToppingi5.SetActive(true);
                                break;
                            case 6:
                                PToppingi6.SetActive(true);
                                break;
                            case 7:
                                PToppingi7.SetActive(true);
                                break;
                            case 8:
                                PToppingi8.SetActive(true);
                                break;
                            case 9:
                                PToppingi9.SetActive(true);
                                break;
                            case 10:
                                PToppingi10.SetActive(true);
                                break;
                            case 11:
                                PToppingi11.SetActive(true);
                                break;

                            default:
                                Debug.LogWarning("Invalid ToppingNumber: " + ToppingNumber);
                                break;
                        }
                    }                             
                }
                else
                {
                    ToppingNumbers.Add(ToppingNumber);
                    RToppingNumber1 = ToppingNumbers[1];
                    switch (ToppingNumber)
                    {
                        case 1:
                            PToppingi1.SetActive(true);
                            break;
                        case 2:
                            PToppingi2.SetActive(true);
                            break;
                        case 3:
                            PToppingi3.SetActive(true);
                            break;
                        case 4:
                            PToppingi4.SetActive(true);
                            break;
                        case 5:
                            PToppingi5.SetActive(true);
                            break;
                        case 6:
                            PToppingi6.SetActive(true);
                            break;
                        case 7:
                            PToppingi7.SetActive(true);
                            break;
                        case 8:
                            PToppingi8.SetActive(true);
                            break;
                        case 9:
                            PToppingi9.SetActive(true);
                            break;
                        case 10:
                            PToppingi10.SetActive(true);
                            break;
                        case 11:
                            PToppingi11.SetActive(true);
                            break;

                        default:
                            Debug.LogWarning("Invalid ToppingNumber: " + ToppingNumber);
                            break;
                    }
                }
            
            }        

        }
        
        SyrupNumber = Syvalues[Random.Range(0, Syvalues.Count)];
        if (SyrupNumber == 1)
        {
            PSyrupi1.SetActive(true);
        }
        if (SyrupNumber == 2)
        {
            PSyrupi2.SetActive(true);
        }
        if (SyrupNumber == 3)
        {
            PSyrupi3.SetActive(true);
        }
        if (SyrupNumber == 4)
        {
            PSyrupi4.SetActive(true);
        }
        if (SyrupNumber == 5)
        {
            PSyrupi5.SetActive(true);
        }
        if (SyrupNumber == 6)
        {
            PSyrupi6.SetActive(true);
        }
        if (SyrupNumber == 7)
        {
            PSyrupi7.SetActive(true);
        }

        if (ToppingCount == 1)
        {
            Debug.Log("랜덤 팬케이크넘버 :" + PancakeNumber);
            Debug.Log("랜덤 토핑넘버 :" + RToppingNumber);
            Debug.Log("랜덤 시럽넘버 :" + SyrupNumber);
        }
        if (ToppingCount == 2)
        {
            Debug.Log("랜덤 팬케이크넘버 :" + PancakeNumber);
            Debug.Log("랜덤 토핑넘버 :" + RToppingNumber);
            Debug.Log("랜덤 토핑넘버1 :" + RToppingNumber1);
            Debug.Log("랜덤 시럽넘버 :" + SyrupNumber);
        }     
    }

    public void resetandstart()
    {
        StartCoroutine(starttime());
    }
    IEnumerator starttime()
    {
        RanHam1.SetActive(false);
        RanHam2.SetActive(false);
        RanHam3.SetActive(false);
        RanHam4.SetActive(false);
        RanHam5.SetActive(false);
        RanHam6.SetActive(false);
        RanHam7.SetActive(false);
        RanHam8.SetActive(false);
        RanHam9.SetActive(false);
        RanHam10.SetActive(false);
        RanHam11.SetActive(false);
        RanHam12.SetActive(false);
        RanHam13.SetActive(false);

        LikeToppingNumbers.Clear();

        yield return new WaitForSeconds(1.5f);
        
        Start();
    }
    public void hamsterunlock(int hamnumber)
    {
        Hamvalues.Add(hamnumber);
        RandomPickSaveData();
    }
    public void pancakeunlock(int pannumber)
    {
        Panvalues.Add(pannumber);
        RandomPickSaveData();
    }
    public void toppingunlock(int tonumber)
    {
        Tovalues.Add(tonumber);
        RandomPickSaveData();
    }
    public void syrupunlock(int synumber)
    {
        Syvalues.Add(synumber);
        RandomPickSaveData();
    }
    public void ResetData()
    {
        Panvalues.Clear();
        Tovalues.Clear();
        Syvalues.Clear();
        Hamvalues.Clear();

        Panvalues.Add(1);

        Tovalues.Add(1);
        Tovalues.Add(2);

        Syvalues.Add(1);

        Hamvalues.Add(1);
        Hamvalues.Add(2);
        Hamvalues.Add(3);

        RandomPickSaveData();
    }
}
