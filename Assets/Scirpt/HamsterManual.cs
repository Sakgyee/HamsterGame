using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HamsterManual : MonoBehaviour
{
    public GameObject HamsterManualCanvas;

    public GameObject manual;

    public Text NameText;
    public Text ExplanationText;

    public GameObject Basichamster;
    public GameObject Strawberryhamster;
    public GameObject Mintchocolatehamster;
    public GameObject Vacationhamster;
    public GameObject SnowHamster;
    public GameObject Idolhamster;
    public GameObject Hamsterinkindergarten;
    public GameObject anofficeworkerhamster;
    public GameObject Pearlhamster;

    public GameObject BasichamsterLove;
    public GameObject StrawberryhamsterLove;
    public GameObject MintchocolatehamsterLove;
    public GameObject VacationhamsterLove;
    public GameObject SnowHamsterLove;
    public GameObject IdolhamsterLove;
    public GameObject HamsterinkindergartenLove;
    public GameObject anofficeworkerhamsterLove;
    public GameObject PearlhamsterLove;

    public static int hamsterLove;

    public GameObject Love1;
    public GameObject Love2;
    public GameObject Love3;
    public GameObject Love4;
    public GameObject Love5;

    public static HamsterManual instance;
    private void Awake()
    {
        HamsterManual.instance = this;
    }
    public void Basic()
    {
        hamsterLove = PlayerPrefs.GetInt("Basichamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Basichamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Strawberry()
    {
        hamsterLove = PlayerPrefs.GetInt("Strawberryhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Strawberryhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Mintchocolate()
    {
        hamsterLove = PlayerPrefs.GetInt("Mintchocolatehamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Mintchocolatehamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Vacation()
    {
        hamsterLove = PlayerPrefs.GetInt("Vacationhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Vacationhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Snow()
    {
        hamsterLove = PlayerPrefs.GetInt("SnowHamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("SnowHamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Idol()
    {
        hamsterLove = PlayerPrefs.GetInt("Idolhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Idolhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void kindergarten()
    {
        hamsterLove = PlayerPrefs.GetInt("Hamsterinkindergarten", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Hamsterinkindergarten", hamsterLove);
        hamsterLove = 0;
    }
    public void anofficeworker()
    {
        hamsterLove = PlayerPrefs.GetInt("anofficeworkerhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("anofficeworkerhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Pearl()
    {
        hamsterLove = PlayerPrefs.GetInt("Pearlhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Pearlhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Manual(string buttonTag)
    {
        manual.SetActive(true);
        if (buttonTag == "Basic hamster")
        {
            hamsterLove = PlayerPrefs.GetInt("Basichamster", 0);
            if(hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Basichamster.SetActive(true);
            BasichamsterLove.SetActive(true);
            NameText.text = "����";
            ExplanationText.text = "�������� �����.";
        }
        if (buttonTag == "Strawberry hamster")
        {
            hamsterLove = PlayerPrefs.GetInt("Strawberryhamster", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Strawberryhamster.SetActive(true);
            StrawberryhamsterLove.SetActive(true);
            NameText.text = "���� ����";
            ExplanationText.text = "���� �����.";
        }
        if (buttonTag == "Mint chocolate hamster")
        {
            hamsterLove = PlayerPrefs.GetInt("Mintchocolatehamster", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Mintchocolatehamster.SetActive(true);
            MintchocolatehamsterLove.SetActive(true);
            NameText.text = "���� ����";
            ExplanationText.text = "���� �����.";
        }
        if (buttonTag == "Vacation hamster")
        {
            hamsterLove = PlayerPrefs.GetInt("Vacationhamster", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Vacationhamster.SetActive(true);
            VacationhamsterLove.SetActive(true);
            NameText.text = "��Ĳ�� ����";
            ExplanationText.text = "��Ĳ�� �����.";
        }
        if (buttonTag == "Snow Hamster")
        {
            hamsterLove = PlayerPrefs.GetInt("SnowHamster", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            SnowHamster.SetActive(true);
            SnowHamsterLove.SetActive(true);
            NameText.text = "���� ����";
            ExplanationText.text = "���� �����.";
        }
        if (buttonTag == "Idol hamster")
        {
            hamsterLove = PlayerPrefs.GetInt("Idolhamster", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Idolhamster.SetActive(true);
            IdolhamsterLove.SetActive(true);
            NameText.text = "���̵� ����";
            ExplanationText.text = "���̵� �����.";
        }
        if (buttonTag == "Hamster in kindergarten")
        {
            hamsterLove = PlayerPrefs.GetInt("Hamsterinkindergarten", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Hamsterinkindergarten.SetActive(true);
            HamsterinkindergartenLove.SetActive(true);
            NameText.text = "��ġ�� ����";
            ExplanationText.text = "��ġ�� �����.";
        }
        if (buttonTag == "an office worker hamster")
        {
            hamsterLove = PlayerPrefs.GetInt("anofficeworkerhamster", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            anofficeworkerhamster.SetActive(true);
            anofficeworkerhamsterLove.SetActive(true);
            NameText.text = "������ ����";
            ExplanationText.text = "������ �����.";
        }
        if (buttonTag == "Pearl hamster ")
        {
            hamsterLove = PlayerPrefs.GetInt("Pearlhamster", 0);
            if (hamsterLove == 1)
            {
                Love1.SetActive(false);
            }
            if (hamsterLove == 2)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
            }
            if (hamsterLove == 3)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
            }
            if (hamsterLove == 4)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
            }
            if (hamsterLove == 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Pearlhamster.SetActive(true);
            PearlhamsterLove.SetActive(true);
            NameText.text = "���� ����";
            ExplanationText.text = "���� �����.";
        }
    }

    public void IntoMain()
    {
        HamsterManualCanvas.SetActive(true);
    }
    public void BackToMain()
    {
        HamsterManualCanvas.SetActive(false);
    }
    public void BackToMenu()
    {
        manual.SetActive(false);

        Basichamster.SetActive(false);
        BasichamsterLove.SetActive(false);
        Strawberryhamster.SetActive(false);
        StrawberryhamsterLove.SetActive(false);
        Mintchocolatehamster.SetActive(false);
        MintchocolatehamsterLove.SetActive(false);
        Vacationhamster.SetActive(false);
        VacationhamsterLove.SetActive(false);
        SnowHamster.SetActive(false);
        SnowHamsterLove.SetActive(false);
        Idolhamster.SetActive(false);
        IdolhamsterLove.SetActive(false);
        Hamsterinkindergarten.SetActive(false);
        HamsterinkindergartenLove.SetActive(false);
        anofficeworkerhamster.SetActive(false);
        anofficeworkerhamsterLove.SetActive(false);
        Pearlhamster.SetActive(false);
        PearlhamsterLove.SetActive(false);

        NameText.text = "";
        ExplanationText.text = "";

        Love1.SetActive(true);
        Love2.SetActive(true);
        Love3.SetActive(true);
        Love4.SetActive(true);
        Love5.SetActive(true);
    }
}
