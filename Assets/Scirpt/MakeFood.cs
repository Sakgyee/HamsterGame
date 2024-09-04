using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MakeFood : MonoBehaviour
{
    public static MakeFood instance;

    public GameObject Pancakei1;
    public GameObject Pancakei2;
    public GameObject Pancakei3;
    public GameObject Pancakei4;
    public GameObject Pancakei5;
    public GameObject Pancakei6;
    public GameObject Pancakei7;
    public GameObject Pancakei8;
    public GameObject Pancakei9;

    public GameObject Toppingi1;
    public GameObject Toppingi2;
    public GameObject Toppingi3;
    public GameObject Toppingi4;
    public GameObject Toppingi5;
    public GameObject Toppingi6;
    public GameObject Toppingi7;
    public GameObject Toppingi8;
    public GameObject Toppingi9;
    public GameObject Toppingi10;
    public GameObject Toppingi11;

    public GameObject Syrupi1;
    public GameObject Syrupi2;
    public GameObject Syrupi3;
    public GameObject Syrupi4;
    public GameObject Syrupi5;
    public GameObject Syrupi6;
    public GameObject Syrupi7;

    public GameObject MPancakei1;
    public GameObject MPancakei2;
    public GameObject MPancakei3;
    public GameObject MPancakei4;
    public GameObject MPancakei5;
    public GameObject MPancakei6;
    public GameObject MPancakei7;
    public GameObject MPancakei8;
    public GameObject MPancakei9;

    public GameObject MToppingi1;
    public GameObject MToppingi2;
    public GameObject MToppingi3;
    public GameObject MToppingi4;
    public GameObject MToppingi5;
    public GameObject MToppingi6;
    public GameObject MToppingi7;
    public GameObject MToppingi8;
    public GameObject MToppingi9;
    public GameObject MToppingi10;
    public GameObject MToppingi11;

    public GameObject MSyrupi1;
    public GameObject MSyrupi2;
    public GameObject MSyrupi3;
    public GameObject MSyrupi4;
    public GameObject MSyrupi5;
    public GameObject MSyrupi6;
    public GameObject MSyrupi7;

    public GameObject PanChange;
    public GameObject ToChange;
    public GameObject SyChange;

    public GameObject PanCollect;
    public GameObject ToCollect;
    public GameObject SyCollect;

    public GameObject PanImageCollect;
    public GameObject ToImageCollect;
    public GameObject SyImageCollect;

    public GameObject fullcounttext;
    public GameObject firstpancake;
    public GameObject secondtopping;
    public GameObject samemenutext;

    public GameObject MTrashB;
    public GameObject MMakeB;

    public GameObject Dish;

    public GameObject MakingPanel;

    public int PancakeMoney;
    public int ToppingMoney;
    public int Topping1Money;
    public int SyrupMoney;

    int MakeMoney;

    private bool pancake1ButtonPressed = true;
    private bool pancake2ButtonPressed = true;
    private bool pancake3ButtonPressed = true;
    private bool pancake4ButtonPressed = true;
    private bool pancake5ButtonPressed = true;
    private bool pancake6ButtonPressed = true;
    private bool pancake7ButtonPressed = true;
    private bool pancake8ButtonPressed = true;
    private bool pancake9ButtonPressed = true;

    private bool topping1ButtonPressed = true;
    private bool topping2ButtonPressed = true;
    private bool topping3ButtonPressed = true;
    private bool topping4ButtonPressed = true;
    private bool topping5ButtonPressed = true;
    private bool topping6ButtonPressed = true;
    private bool topping7ButtonPressed = true;
    private bool topping8ButtonPressed = true;
    private bool topping9ButtonPressed = true;
    private bool topping10ButtonPressed = true;
    private bool topping11ButtonPressed = true;

    private bool syrup1ButtonPressed = true;
    private bool syrup2ButtonPressed = true;
    private bool syrup3ButtonPressed = true;
    private bool syrup4ButtonPressed = true;
    private bool syrup5ButtonPressed = true;
    private bool syrup6ButtonPressed = true;
    private bool syrup7ButtonPressed = true;

    public int pancount = 0;
    public int tocount = 0;
    public int sycount = 0;

    public int pannum;
    public int tonum;
    public int tonum1;
    public int synum;

    public float MakeTime;

    public AudioSource MakeFinish;
    public AudioSource Trash;

    public AudioSource POP;
    void Awake()
    {
        MakeFood.instance = this;  //변수 초기화부
    }
    private void Start()
    {
        MakingPanel.SetActive(false);
        pancount = 0;
        tocount = 0;
        sycount = 0;

        pannum = 0;
        tonum = 0;
        tonum1 = 0;
        synum = 0;

        PancakeMoney = 0;
        ToppingMoney = 0;
        Topping1Money = 0;
        SyrupMoney = 0;

        MakeMoney = 0;
    }

    public void PancakeButtonClicked(string buttonTag)
    {
        POP.Play();
        Debug.Log("pancount" + pancount);
        if (buttonTag == "Pancake1")
        {
            
            if (pancake1ButtonPressed == true)
            {
                pancake2ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake4ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake6ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9ButtonPressed = false;
                pancake1();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);                    
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }

        else if (buttonTag == "Pancake2")
        {
            if (pancake2ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake4ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake6ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9ButtonPressed = false;
                pancake2();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }


        else if (buttonTag == "Pancake3")
        {
            if (pancake3ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake2ButtonPressed = false;
                pancake4ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake6ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9ButtonPressed = false;
                pancake3();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Pancake4")
        {
            if (pancake4ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake2ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake6ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9ButtonPressed = false;
                pancake4();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Pancake5")
        {
            if (pancake5ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake2ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake4ButtonPressed = false;              
                pancake6ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9ButtonPressed = false;
                pancake5();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Pancake6")
        {
            if (pancake6ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake2ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake4ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9ButtonPressed = false;
                pancake6();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Pancake7")
        {
            if (pancake7ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake2ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake4ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake6ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9ButtonPressed = false; ;
                pancake7();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Pancake8")
        {
            if (pancake8ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake2ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake4ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake6ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake9ButtonPressed = false;
                pancake8();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Pancake9")
        {
            if (pancake9ButtonPressed == true)
            {
                pancake1ButtonPressed = false;
                pancake2ButtonPressed = false;
                pancake3ButtonPressed = false;
                pancake4ButtonPressed = false;
                pancake5ButtonPressed = false;
                pancake6ButtonPressed = false;
                pancake7ButtonPressed = false;
                pancake8ButtonPressed = false;
                pancake9();
            }
            else
            {
                if (pancount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
    }

    public void ToppingButtonClicked(string buttonTag)
    {
        POP.Play();
        samemenutext.SetActive(false);
        Debug.Log("tocount" + tocount);
        if (buttonTag == "Topping1")
        {
            if (topping1ButtonPressed == true)
            {
                topping1ButtonPressed = false;
                topping1();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping2")
        {
            if (topping2ButtonPressed == true)
            {
                topping2ButtonPressed = false;
                topping2();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }

        else if (buttonTag == "Topping3")
        {
            if (topping3ButtonPressed == true)
            {
                topping3ButtonPressed = false;
                topping3();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping4")
        {
            if (topping4ButtonPressed == true)
            {
                topping4ButtonPressed = false;
                topping4();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping5")
        {
            if (topping5ButtonPressed == true)
            {
                topping5ButtonPressed = false;
                topping5();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping6")
        {
            if (topping6ButtonPressed == true)
            {
                topping6ButtonPressed = false;
                topping6();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping7")
        {
            if (topping7ButtonPressed == true)
            {
                topping7ButtonPressed = false;
                topping7();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping8")
        {
            if (topping8ButtonPressed == true)
            {
                topping8ButtonPressed = false;
                topping8();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping9")
        {
            if (topping9ButtonPressed == true)
            {
                topping9ButtonPressed = false;
                topping9();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping10")
        {
            if (topping10ButtonPressed == true)
            {
                topping10ButtonPressed = false;
                topping10();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Topping11")
        {
            if (topping11ButtonPressed == true)
            {
                topping11ButtonPressed = false;
                topping11();
            }
            else
            {
                if (tocount >= 2)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
                else
                {
                    fullcounttext.SetActive(false);
                    samemenutext.SetActive(true);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
    }

    public void SyrupButtonClicked(string buttonTag)
    {
        POP.Play();
        samemenutext.SetActive(false);
        Debug.Log("sycount" + sycount);
        if (buttonTag == "Syrup1")
        {
            if (syrup1ButtonPressed == true)
            {
                syrup2ButtonPressed = false;
                syrup3ButtonPressed = false;
                syrup4ButtonPressed = false;
                syrup5ButtonPressed = false;
                syrup6ButtonPressed = false;
                syrup7ButtonPressed = false;
                syrup1();
            }
            else
            {
                if (sycount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Syrup2")
        {
            if (syrup2ButtonPressed == true)
            {
                syrup1ButtonPressed = false;
                syrup3ButtonPressed = false;
                syrup4ButtonPressed = false;
                syrup5ButtonPressed = false;
                syrup6ButtonPressed = false;
                syrup7ButtonPressed = false;
                syrup2();
            }
            else
            {
                if (sycount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }

        else if (buttonTag == "Syrup3")
        {
            if (syrup3ButtonPressed == true)
            {
                syrup1ButtonPressed = false;
                syrup2ButtonPressed = false;
                syrup4ButtonPressed = false;
                syrup5ButtonPressed = false;
                syrup6ButtonPressed = false;
                syrup7ButtonPressed = false;
                syrup3();
            }
            else
            {
                if (sycount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Syrup4")
        {
            if (syrup4ButtonPressed == true)
            {
                syrup1ButtonPressed = false;
                syrup2ButtonPressed = false;
                syrup3ButtonPressed = false;
                syrup5ButtonPressed = false;
                syrup6ButtonPressed = false;
                syrup7ButtonPressed = false;
                syrup4();
            }
            else
            {
                if (sycount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Syrup5")
        {
            if (syrup5ButtonPressed == true)
            {
                syrup1ButtonPressed = false;
                syrup2ButtonPressed = false;
                syrup3ButtonPressed = false;
                syrup4ButtonPressed = false;
                syrup6ButtonPressed = false;
                syrup7ButtonPressed = false;
                syrup5();
            }
            else
            {
                if (sycount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Syrup6")
        {
            if (syrup6ButtonPressed == true)
            {
                syrup1ButtonPressed = false;
                syrup2ButtonPressed = false;
                syrup3ButtonPressed = false;
                syrup4ButtonPressed = false;
                syrup5ButtonPressed = false;
                syrup7ButtonPressed = false;
                syrup6();
            }
            else
            {
                if (sycount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
        else if (buttonTag == "Syrup7")
        {
            if (syrup7ButtonPressed == true)
            {
                syrup1ButtonPressed = false;
                syrup2ButtonPressed = false;
                syrup3ButtonPressed = false;
                syrup4ButtonPressed = false;
                syrup5ButtonPressed = false;
                syrup6ButtonPressed = false;
                syrup7();
            }
            else
            {
                if (sycount >= 1)
                {
                    fullcounttext.SetActive(true);
                    samemenutext.SetActive(false);
                    firstpancake.SetActive(false);
                    secondtopping.SetActive(false);
                }
            }
        }
    }

    public void pancake1()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if(pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
            Pancakei1.SetActive(true);
            MPancakei1.SetActive(true);
            pancount = 1;
        pannum = 1;
        PancakeMoney += 1;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake2()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei2.SetActive(true);
        MPancakei2.SetActive(true);
        pancount = 1;
        pannum = 2;
        PancakeMoney += 2;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake3()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei3.SetActive(true);
        MPancakei3.SetActive(true);
        pancount = 1;
        pannum = 3;
        PancakeMoney += 3;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake4()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei4.SetActive(true);
        MPancakei4.SetActive(true);
        pancount = 1;
        pannum = 4;
        PancakeMoney += 4;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake5()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei5.SetActive(true);
        MPancakei5.SetActive(true);
        pancount = 1;
        pannum = 5;
        PancakeMoney += 5;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake6()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei6.SetActive(true);
        MPancakei6.SetActive(true);
        pancount = 1;
        pannum = 6;
        PancakeMoney += 6;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake7()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei7.SetActive(true);
        MPancakei7.SetActive(true);
        pancount = 1;
        pannum = 7;
        PancakeMoney += 7;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake8()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei8.SetActive(true);
        MPancakei8.SetActive(true);
        pancount = 1;
        pannum = 8;
        PancakeMoney += 8;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void pancake9()
    {
        samemenutext.SetActive(false);
        if (firstpancake != null)
        {
            firstpancake.SetActive(false);
        }
        if (pancount >= 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(true);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            return;
        }
        Pancakei9.SetActive(true);
        MPancakei9.SetActive(true);
        pancount = 1;
        pannum = 9;
        PancakeMoney += 9;
        PanCollect.SetActive(false);
        ToCollect.SetActive(true);
    }
    public void topping1()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }         
        if ( pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }
        
        if(tocount > 0)
        {
            tonum1 = 1;
        }
        if (tocount <= 0)
        {
            tonum = 1;
        }
        Toppingi1.SetActive(true);
        MToppingi1.SetActive(true);
        tocount += 1;
        PancakeMoney += 1;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping2()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }
     
        if (tocount > 0)
        {
            tonum1 = 2;
        }
        if (tocount <= 0)
        {
            tonum = 2;
        }
        Toppingi2.SetActive(true);
        MToppingi2.SetActive(true);
        tocount += 1;
        PancakeMoney += 1;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping3()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }
        
        if (tocount > 0)
        {
            tonum1 = 3;
        }
        if (tocount <= 0)
        {
            tonum = 3;
        }
        Toppingi3.SetActive(true);
        MToppingi3.SetActive(true);
        tocount += 1;
        PancakeMoney += 2;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping4()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 4;
        }
        if (tocount <= 0)
        {
            tonum = 4;
        }
        Toppingi4.SetActive(true);
        MToppingi4.SetActive(true);
        tocount += 1;
        PancakeMoney += 3;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping5()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 5;
        }
        if (tocount <= 0)
        {
            tonum = 5;
        }
        Toppingi5.SetActive(true);
        MToppingi5.SetActive(true);
        tocount += 1;
        PancakeMoney += 4;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping6()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 6;
        }
        if (tocount <= 0)
        {
            tonum = 6;
        }
        Toppingi6.SetActive(true);
        MToppingi6.SetActive(true);
        tocount += 1;
        PancakeMoney += 5;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping7()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 7;
        }
        if (tocount <= 0)
        {
            tonum = 7;
        }
        Toppingi7.SetActive(true);
        MToppingi7.SetActive(true);
        tocount += 1;
        PancakeMoney += 6;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping8()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 8;
        }
        if (tocount <= 0)
        {
            tonum = 8;
        }
        Toppingi8.SetActive(true);
        MToppingi8.SetActive(true);
        tocount += 1;
        PancakeMoney += 7;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping9()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 9;
        }
        if (tocount <= 0)
        {
            tonum = 9;
        }
        Toppingi9.SetActive(true);
        MToppingi9.SetActive(true);
        tocount += 1;
        PancakeMoney += 8;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping10()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 10;
        }
        if (tocount <= 0)
        {
            tonum = 10;
        }
        Toppingi10.SetActive(true);
        MToppingi10.SetActive(true);
        tocount += 1;
        PancakeMoney += 9;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void topping11()
    {
        secondtopping.SetActive(false);

        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            topping1ButtonPressed = true;
            topping2ButtonPressed = true;
            topping3ButtonPressed = true;
            topping4ButtonPressed = true;
            topping5ButtonPressed = true;
            topping6ButtonPressed = true;
            topping7ButtonPressed = true;
            topping8ButtonPressed = true;
            topping9ButtonPressed = true;
            return;
        }

        if (tocount > 0)
        {
            tonum1 = 11;
        }
        if (tocount <= 0)
        {
            tonum = 11;
        }
        Toppingi11.SetActive(true);
        MToppingi11.SetActive(true);
        tocount += 1;
        PancakeMoney += 10;
        if (tocount >= 2)
        {
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void syrup1()
    {
        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (pancount >= 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(true);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if(sycount >= 1)
        {
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            fullcounttext.SetActive(true);
            return;
        }
        Syrupi1.SetActive(true);
        MSyrupi1.SetActive(true);
        sycount = 1;
        synum = 1;
        PancakeMoney += 1;
    }
    public void syrup2()
    {
        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (pancount >= 1 && tocount < 1)
        {
            fullcounttext.SetActive(false);
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(true);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (sycount >= 1)
        {
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            fullcounttext.SetActive(true);
            return;
        }
        Syrupi2.SetActive(true);
        MSyrupi2.SetActive(true);
        sycount = 1;
        synum = 2;
        PancakeMoney += 2;
    }
    public void syrup3()
    {
        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (pancount >= 1 && tocount < 1)
        {
            fullcounttext.SetActive(false);
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(true);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (sycount >= 1)
        {
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            fullcounttext.SetActive(true);
            return;
        }
        Syrupi3.SetActive(true);
        MSyrupi3.SetActive(true);
        sycount = 1;
        synum = 3;
        PancakeMoney += 3;
    }
    public void syrup4()
    {
        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (pancount >= 1 && tocount < 1)
        {
            fullcounttext.SetActive(false);
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(true);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (sycount >= 1)
        {
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            fullcounttext.SetActive(true);
            return;
        }
        Syrupi4.SetActive(true);
        MSyrupi4.SetActive(true);
        sycount = 1;
        synum = 4;
        PancakeMoney += 4;
    }
    public void syrup5()
    {
        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (pancount >= 1 && tocount < 1)
        {
            fullcounttext.SetActive(false);
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(true);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (sycount >= 1)
        {
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            fullcounttext.SetActive(true);
            return;
        }
        Syrupi5.SetActive(true);
        MSyrupi5.SetActive(true);
        sycount = 1;
        synum = 5;
        PancakeMoney += 5;
    }
    public void syrup6()
    {
        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (pancount >= 1 && tocount < 1)
        {
            fullcounttext.SetActive(false);
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(true);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (sycount >= 1)
        {
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            fullcounttext.SetActive(true);
            return;
        }
        Syrupi6.SetActive(true);
        MSyrupi6.SetActive(true);
        sycount = 1;
        synum = 6;
        PancakeMoney += 6;
    }
    public void syrup7()
    {
        if (fullcounttext != null)
        {
            fullcounttext.SetActive(false);
        }
        if (pancount < 1 && tocount < 1)
        {
            samemenutext.SetActive(false);
            fullcounttext.SetActive(false);
            firstpancake.SetActive(true);
            secondtopping.SetActive(false);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (pancount >= 1 && tocount < 1)
        {
            fullcounttext.SetActive(false);
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(true);

            syrup1ButtonPressed = true;
            syrup2ButtonPressed = true;
            syrup3ButtonPressed = true;
            syrup4ButtonPressed = true;
            syrup5ButtonPressed = true;
            syrup6ButtonPressed = true;
            syrup7ButtonPressed = true;
            return;
        }
        if (sycount >= 1)
        {
            samemenutext.SetActive(false);
            firstpancake.SetActive(false);
            secondtopping.SetActive(false);
            fullcounttext.SetActive(true);
            return;
        }
        Syrupi7.SetActive(true);
        MSyrupi7.SetActive(true);
        sycount = 1;
        synum = 7;
        PancakeMoney += 7;
    }
    public void pencakechange()
    {
        if(PanChange != null)
        {
            PanCollect.SetActive(true);
            ToCollect.SetActive(false);
            SyCollect.SetActive(false);
        }
    }
    public void toppingchange()
    {
        if (ToChange != null)
        {
            PanCollect.SetActive(false);
            ToCollect.SetActive(true);
            SyCollect.SetActive(false);
        }
    }
    public void syrupchange()
    {
        if (ToChange != null)
        {
            PanCollect.SetActive(false);
            ToCollect.SetActive(false);
            SyCollect.SetActive(true);
        }
    }
    public void make()
    {
        POP.Play();
        if(pancount < 1)
        {
            return;
        }
        MTrashB.SetActive(false);
        MMakeB.SetActive(true);
        Dish.SetActive(true);

        MakingPanel.SetActive(true);

        MakeMoney += PancakeMoney;
        MakeMoney += ToppingMoney;
        MakeMoney += Topping1Money;
        MakeMoney += SyrupMoney;

        PanImageCollect.SetActive(true);
        ToImageCollect.SetActive(true);
        SyImageCollect.SetActive(true);

        StartCoroutine(makefinish());
    }
    public void trash()
    {
        Trash.Play();

        MTrashB.SetActive(true);
        MMakeB.SetActive(false);
        Dish.SetActive(false);

        pancount = 0;
        tocount = 0;
        sycount = 0;

        pannum = 0;
        tonum = 0;
        tonum1 = 0;
        synum = 0;

        PancakeMoney = 0;
        ToppingMoney = 0;
        Topping1Money = 0;
        SyrupMoney = 0;

        MakeMoney = 0;

        pancake1ButtonPressed = true;
    pancake2ButtonPressed = true;
    pancake3ButtonPressed = true;
    pancake4ButtonPressed = true;
    pancake5ButtonPressed = true;
    pancake6ButtonPressed = true;
    pancake7ButtonPressed = true;
    pancake8ButtonPressed = true;
    pancake9ButtonPressed = true;

    topping1ButtonPressed = true;
    topping2ButtonPressed = true;
    topping3ButtonPressed = true;
    topping4ButtonPressed = true;
    topping5ButtonPressed = true;
    topping6ButtonPressed = true;
    topping7ButtonPressed = true;
    topping8ButtonPressed = true;
    topping9ButtonPressed = true;
    topping10ButtonPressed = true;
    topping11ButtonPressed = true;

    syrup1ButtonPressed = true;
    syrup2ButtonPressed = true;
    syrup3ButtonPressed = true;
    syrup4ButtonPressed = true;
    syrup5ButtonPressed = true;
    syrup6ButtonPressed = true;
    syrup7ButtonPressed = true;

        PanCollect.SetActive(true);
        ToCollect.SetActive(false);
        SyCollect.SetActive(false);
        
        Pancakei1.SetActive(false);
        Pancakei2.SetActive(false);
        Pancakei3.SetActive(false);
        Pancakei4.SetActive(false);
        Pancakei5.SetActive(false);
        Pancakei6.SetActive(false);
        Pancakei7.SetActive(false);
        Pancakei8.SetActive(false);
        Pancakei9.SetActive(false);

        Toppingi1.SetActive(false);
        Toppingi2.SetActive(false);
        Toppingi3.SetActive(false);
        Toppingi4.SetActive(false);
        Toppingi5.SetActive(false);
        Toppingi6.SetActive(false);
        Toppingi7.SetActive(false);
        Toppingi8.SetActive(false);
        Toppingi9.SetActive(false);
        Toppingi10.SetActive(false);
        Toppingi11.SetActive(false);

        Syrupi1.SetActive(false);
        Syrupi2.SetActive(false);
        Syrupi3.SetActive(false);
        Syrupi4.SetActive(false);
        Syrupi5.SetActive(false);
        Syrupi6.SetActive(false);
        Syrupi7.SetActive(false);

        MPancakei1.SetActive(false);
        MPancakei2.SetActive(false);
        MPancakei3.SetActive(false);
        MPancakei4.SetActive(false);
        MPancakei5.SetActive(false);
        MPancakei6.SetActive(false);
        MPancakei7.SetActive(false);
        MPancakei8.SetActive(false);
        MPancakei9.SetActive(false);

        MToppingi1.SetActive(false);
        MToppingi2.SetActive(false);
        MToppingi3.SetActive(false);
        MToppingi4.SetActive(false);
        MToppingi5.SetActive(false);
        MToppingi6.SetActive(false);
        MToppingi7.SetActive(false);
        MToppingi8.SetActive(false);
        MToppingi9.SetActive(false);
        MToppingi10.SetActive(false);
        MToppingi11.SetActive(false);

        MSyrupi1.SetActive(false);
        MSyrupi2.SetActive(false);
        MSyrupi3.SetActive(false);
        MSyrupi4.SetActive(false);
        MSyrupi5.SetActive(false);
        MSyrupi6.SetActive(false);
        MSyrupi7.SetActive(false);

        fullcounttext.SetActive(false);
    firstpancake.SetActive(false);
    secondtopping.SetActive(false);
    samemenutext.SetActive(false);
    }

    IEnumerator makefinish()
    {

        if (MoneyData.CoinInt > 0)
        {
            if(MoneyData.CoinInt < MakeMoney)
            {
                MoneyData.CoinInt -= MoneyData.CoinInt;
            }
            else
            {
                MoneyData.CoinInt -= (MakeMoney/3);
            }          
        }       

        fullcounttext.SetActive(false);
        firstpancake.SetActive(false);
        secondtopping.SetActive(false);
        samemenutext.SetActive(false);
        yield return new WaitForSeconds(MakeTime);
        MakeFinish.Play();
        SlideCanvas.instance.SlideOutToRight();       
        yield return new WaitForSeconds(1.0f);
        MakingPanel.SetActive(false);

        Pancakei1.SetActive(false);
        Pancakei2.SetActive(false);
        Pancakei3.SetActive(false);
        Pancakei4.SetActive(false);
        Pancakei5.SetActive(false);
        Pancakei6.SetActive(false);
        Pancakei7.SetActive(false);
        Pancakei8.SetActive(false);
        Pancakei9.SetActive(false);

        Toppingi1.SetActive(false);
        Toppingi2.SetActive(false);
        Toppingi3.SetActive(false);
        Toppingi4.SetActive(false);
        Toppingi5.SetActive(false);
        Toppingi6.SetActive(false);
        Toppingi7.SetActive(false);
        Toppingi8.SetActive(false);
        Toppingi9.SetActive(false);
        Toppingi10.SetActive(false);
        Toppingi11.SetActive(false);

        Syrupi1.SetActive(false);
        Syrupi2.SetActive(false);
        Syrupi3.SetActive(false);
        Syrupi4.SetActive(false);
        Syrupi5.SetActive(false);
        Syrupi6.SetActive(false);
        Syrupi7.SetActive(false);

        pancake1ButtonPressed = true;
        pancake2ButtonPressed = true;
        pancake3ButtonPressed = true;
        pancake4ButtonPressed = true;
        pancake5ButtonPressed = true;
        pancake6ButtonPressed = true;
        pancake7ButtonPressed = true;
        pancake8ButtonPressed = true;
        pancake9ButtonPressed = true;

        topping1ButtonPressed = true;
        topping2ButtonPressed = true;
        topping3ButtonPressed = true;
        topping4ButtonPressed = true;
        topping5ButtonPressed = true;
        topping6ButtonPressed = true;
        topping7ButtonPressed = true;
        topping8ButtonPressed = true;
        topping9ButtonPressed = true;
        topping10ButtonPressed = true;
        topping11ButtonPressed = true;

        syrup1ButtonPressed = true;
        syrup2ButtonPressed = true;
        syrup3ButtonPressed = true;
        syrup4ButtonPressed = true;
        syrup5ButtonPressed = true;
        syrup6ButtonPressed = true;
        syrup7ButtonPressed = true;

        MakingPanel.SetActive(false);

        yield return new WaitForSeconds(1.0f);

        if (pancount == 1)
        {
            pancount -= 1;
        }
        pancount = 0;
        if(tocount == 2)
        {
            tocount -= 2;
        }
        if (tocount == 1)
        {
            tocount -= 1;
        }
        if (sycount == 1)
        {
            sycount -= 1;
        }
    }

    public void Deletenum()
    {
        pancount = 0;
        tocount = 0;
        sycount = 0;

        pannum = 0;
        tonum = 0;
        tonum1 = 0;
        synum = 0;

        PancakeMoney = 0;
        ToppingMoney = 0;
        Topping1Money = 0;
        SyrupMoney = 0;

        MakeMoney = 0;
    }
}