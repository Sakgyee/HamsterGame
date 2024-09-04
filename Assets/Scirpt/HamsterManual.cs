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
    public GameObject Pearlhamster;
    public GameObject SnowHamster;
    public GameObject Hamsterinkindergarten;
    public GameObject Vacationhamster;
    public GameObject anofficeworkerhamster;
    public GameObject Strawberryhamster;
    public GameObject Mintchocolatehamster;
    public GameObject asuspicioushamster;
    public GameObject Idolhamster;
    public GameObject Firehamster;
    public GameObject Wizardhamster;
    public GameObject Icequeenhamster;

    public GameObject BasichamsterLove;
    public GameObject PearlhamsterLove;
    public GameObject SnowHamsterLove;
    public GameObject HamsterinkindergartenLove;
    public GameObject VacationhamsterLove;
    public GameObject anofficeworkerhamsterLove;
    public GameObject StrawberryhamsterLove;
    public GameObject MintchocolatehamsterLove;
    public GameObject asuspicioushamsterLove;
    public GameObject IdolhamsterLove;
    public GameObject FirehamsterLove;
    public GameObject WizardhamsterLove;
    public GameObject IcequeenhamsterLove;

    public static int hamsterLove;

    public GameObject Love1;
    public GameObject Love2;
    public GameObject Love3;
    public GameObject Love4;
    public GameObject Love5;

    public static HamsterManual instance;

    public AudioSource POP;

    private void Awake()
    {
        HamsterManual.instance = this;
    }
    private void Start()
    {
        //Basic();
    }
    public void ResetHeart()
    {
        PlayerPrefs.DeleteKey("Basichamster");
        PlayerPrefs.DeleteKey("Pearlhamster");
        PlayerPrefs.DeleteKey("SnowHamster");
        PlayerPrefs.DeleteKey("Hamsterinkindergarten");
        PlayerPrefs.DeleteKey("Vacationhamster");
        PlayerPrefs.DeleteKey("anofficeworkerhamster");
        PlayerPrefs.DeleteKey("Strawberryhamster");
        PlayerPrefs.DeleteKey("Mintchocolatehamster");
        PlayerPrefs.DeleteKey("asuspicioushamster");
        PlayerPrefs.DeleteKey("Idolhamster");
        PlayerPrefs.DeleteKey("Firehamster");
        PlayerPrefs.DeleteKey("Wizardhamster");
        PlayerPrefs.DeleteKey("Icequeenhamster");
    }
    public void Basic()
    {
        hamsterLove = PlayerPrefs.GetInt("Basichamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Basichamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Pearl()
    {
        hamsterLove = PlayerPrefs.GetInt("Pearlhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Pearlhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Snow()
    {
        hamsterLove = PlayerPrefs.GetInt("SnowHamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("SnowHamster", hamsterLove);
        hamsterLove = 0;
    }
    public void kindergarten()
    {
        hamsterLove = PlayerPrefs.GetInt("Hamsterinkindergarten", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Hamsterinkindergarten", hamsterLove);
        hamsterLove = 0;
    }
    public void Vacation()
    {
        hamsterLove = PlayerPrefs.GetInt("Vacationhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Vacationhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void anofficeworker()
    {
        hamsterLove = PlayerPrefs.GetInt("anofficeworkerhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("anofficeworkerhamster", hamsterLove);
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
    public void Suspicious()
    {
        hamsterLove = PlayerPrefs.GetInt("asuspicioushamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Mintchocolatehamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Idol()
    {
        hamsterLove = PlayerPrefs.GetInt("Idolhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Idolhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Fire()
    {
        hamsterLove = PlayerPrefs.GetInt("Firehamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Firehamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Wizard()
    {
        hamsterLove = PlayerPrefs.GetInt("Wizardhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Wizardhamster", hamsterLove);
        hamsterLove = 0;
    }
    public void Icequeen()
    {
        hamsterLove = PlayerPrefs.GetInt("Icequeenhamster", 0);
        hamsterLove += 1;
        PlayerPrefs.SetInt("Icequeenhamster", hamsterLove);
        hamsterLove = 0;
    }

    public void Manual(string buttonTag)
    {
        manual.SetActive(true);
        if (buttonTag == "Basic hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
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
            ExplanationText.text = "������ũ�� �����ϴ� �Ϳ��� �����";
        }
        if (buttonTag == "Pearl hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Pearlhamster.SetActive(true);
            PearlhamsterLove.SetActive(true);
            NameText.text = "������";
            ExplanationText.text = "������ ���� �� ����� ������ũ ���� �Ծ��";
        }
        if (buttonTag == "Snow Hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            SnowHamster.SetActive(true);
            SnowHamsterLove.SetActive(true);
            NameText.text = "���������";
            ExplanationText.text = "�Ͼ�� ������ ���� �ŷ��� ����� �����";
        }
        if (buttonTag == "Hamster in kindergarten")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Hamsterinkindergarten.SetActive(true);
            HamsterinkindergartenLove.SetActive(true);
            NameText.text = "��ġ������";
            ExplanationText.text = "�����߿� ������ũ�� ���� �����ϴ� �Ϳ��� ��ġ�� �����";
        }
        if (buttonTag == "Vacation hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Vacationhamster.SetActive(true);
            VacationhamsterLove.SetActive(true);
            NameText.text = "��Ĳ������";
            ExplanationText.text = "������ �����ϰ� �޺� �Ʒ����� ������ũ�� ��� �Դ� ��Ĳ�� �����";
        }
        if (buttonTag == "an office worker hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            anofficeworkerhamster.SetActive(true);
            anofficeworkerhamsterLove.SetActive(true);
            NameText.text = "��¯������";
            ExplanationText.text = "���� �Ϸ絵 �����߾��! ������ũ�� �����鼭 �Ϸ縦 ������ �ؿ�";
        }
        if (buttonTag == "Strawberry hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Strawberryhamster.SetActive(true);
            StrawberryhamsterLove.SetActive(true);
            NameText.text = "��������";
            ExplanationText.text = "���⸦ �����ϴ� �������� ���⸸ �ص� ���޴��� �ؿ�";
        }
        if (buttonTag == "Mint chocolate hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Mintchocolatehamster.SetActive(true);
            MintchocolatehamsterLove.SetActive(true);
            NameText.text = "��������";
            ExplanationText.text = "���ʴ� ���� ����� ������ũ�� ���ʷ� �Դ´ٰ� �ؿ�";
        }
        if (buttonTag == "a suspicious hamster")
        {
            POP.Play();
            hamsterLove = PlayerPrefs.GetInt("asuspicioushamster", 0);
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            asuspicioushamster.SetActive(true);
            asuspicioushamsterLove.SetActive(true);
            NameText.text = "����������";
            ExplanationText.text = "���� ��ĥ�� ���� �ʳ���..? ������ ���ִ� ������ũ�� �شٸ� �ƹ��ϵ� ������ �����ſ���!";
        }

        if (buttonTag == "Idol hamster")
        {
            POP.Play();
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Idolhamster.SetActive(true);
            IdolhamsterLove.SetActive(true);
            NameText.text = "���̵�����";
            ExplanationText.text = "���۽�Ÿ ���̵� ��� ������ũ�� ���� �����Ѵٴ� �ҹ� ���̾��?";
        }
        if (buttonTag == "Fire hamster")
        {
            POP.Play();
            hamsterLove = PlayerPrefs.GetInt("Firehamster", 0);
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Firehamster.SetActive(true);
            FirehamsterLove.SetActive(true);
            NameText.text = "�Ҳ�����";
            ExplanationText.text = "�������� �Ҳ������ �׻� �տ��� ������ ��� �ǸԴ´ٰ� �ؿ�";
        }
        if (buttonTag == "Wizard hamster")
        {
            POP.Play();
            hamsterLove = PlayerPrefs.GetInt("Wizardhamster", 0);
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Wizardhamster.SetActive(true);
            WizardhamsterLove.SetActive(true);
            NameText.text = "����������";
            ExplanationText.text = "������ ��� �����߾�� ������ � ������ �������� �ñ����� �ʳ���?";
        }
        if (buttonTag == "Ice queen hamster")
        {
            POP.Play();
            hamsterLove = PlayerPrefs.GetInt("Icequeenhamster", 0);
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
            if (hamsterLove >= 5)
            {
                Love1.SetActive(false);
                Love2.SetActive(false);
                Love3.SetActive(false);
                Love4.SetActive(false);
                Love5.SetActive(false);
            }

            Icequeenhamster.SetActive(true);
            IcequeenhamsterLove.SetActive(true);
            NameText.text = "������������";
            ExplanationText.text = "�������� ��� ��Ÿ���� ���⸶���� �߿����� ������ũ�� �������� ����� ?";
        }
    }

    public void IntoManual()
    {
        HamsterManualCanvas.transform.localPosition = new Vector3(0, 0, 0);
        POP.Play();
    }
    public void BackToMain()
    {
        HamsterManualCanvas.transform.localPosition = new Vector3(-8, 0, 0);
    }
    public void BackToMenu()
    {
        manual.SetActive(false);

        Basichamster.SetActive(false);
        BasichamsterLove.SetActive(false);

        Pearlhamster.SetActive(false);
        PearlhamsterLove.SetActive(false);

        SnowHamster.SetActive(false);
        SnowHamsterLove.SetActive(false);

        Hamsterinkindergarten.SetActive(false);
        HamsterinkindergartenLove.SetActive(false);

        Vacationhamster.SetActive(false);
        VacationhamsterLove.SetActive(false);

        anofficeworkerhamster.SetActive(false);
        anofficeworkerhamsterLove.SetActive(false);

        Strawberryhamster.SetActive(false);
        StrawberryhamsterLove.SetActive(false);

        Mintchocolatehamster.SetActive(false);
        MintchocolatehamsterLove.SetActive(false);

        asuspicioushamster.SetActive(false);
        asuspicioushamsterLove.SetActive(false);

        Idolhamster.SetActive(false);
        IdolhamsterLove.SetActive(false);

        Firehamster.SetActive(false);
        FirehamsterLove.SetActive(false);

        Wizardhamster.SetActive(false);
        WizardhamsterLove.SetActive(false);

        Icequeenhamster.SetActive(false);
        IcequeenhamsterLove.SetActive(false);

        NameText.text = "";
        ExplanationText.text = "";

        Love1.SetActive(true);
        Love2.SetActive(true);
        Love3.SetActive(true);
        Love4.SetActive(true);
        Love5.SetActive(true);
    }
}
