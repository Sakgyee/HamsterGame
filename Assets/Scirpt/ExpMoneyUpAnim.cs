using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpMoneyUpAnim : MonoBehaviour
{
    public GameObject ExpTarget;
    public GameObject MoneyTarget;

    public GameObject ExpUpAnim;
    public GameObject MoneyUpAnim;

    public GameObject ExpUpAnim1;
    public GameObject MoneyUpAnim1;

    public GameObject ExpUpAnim2;
    public GameObject MoneyUpAnim2;

    public GameObject ExpUpAnim3;
    public GameObject MoneyUpAnim3;

    public GameObject ExpUpAnim4;
    public GameObject MoneyUpAnim4;

    public GameObject Anim;

    public static ExpMoneyUpAnim instance;

    private void Awake()
    {
        ExpMoneyUpAnim.instance = this;
    }
    void Update()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        ExpUpAnim.transform.localPosition = Vector3.MoveTowards(ExpUpAnim.transform.localPosition, ExpTarget.transform.localPosition, 0.05f);
        MoneyUpAnim.transform.localPosition = Vector3.MoveTowards(MoneyUpAnim.transform.localPosition, MoneyTarget.transform.localPosition, 0.05f);

        yield return new WaitForSeconds(0.1f);

        ExpUpAnim1.transform.localPosition = Vector3.MoveTowards(ExpUpAnim1.transform.localPosition, ExpTarget.transform.localPosition, 0.05f);
        MoneyUpAnim1.transform.localPosition = Vector3.MoveTowards(MoneyUpAnim1.transform.localPosition, MoneyTarget.transform.localPosition, 0.05f);

        yield return new WaitForSeconds(0.1f);

        ExpUpAnim2.transform.localPosition = Vector3.MoveTowards(ExpUpAnim2.transform.localPosition, ExpTarget.transform.localPosition, 0.05f);
        MoneyUpAnim2.transform.localPosition = Vector3.MoveTowards(MoneyUpAnim2.transform.localPosition, MoneyTarget.transform.localPosition, 0.05f);

        yield return new WaitForSeconds(0.1f);

        ExpUpAnim3.transform.localPosition = Vector3.MoveTowards(ExpUpAnim3.transform.localPosition, ExpTarget.transform.localPosition, 0.05f);
        MoneyUpAnim3.transform.localPosition = Vector3.MoveTowards(MoneyUpAnim3.transform.localPosition, MoneyTarget.transform.localPosition, 0.05f);

        yield return new WaitForSeconds(0.1f);

        ExpUpAnim4.transform.localPosition = Vector3.MoveTowards(ExpUpAnim4.transform.localPosition, ExpTarget.transform.localPosition, 0.05f);
        MoneyUpAnim4.transform.localPosition = Vector3.MoveTowards(MoneyUpAnim4.transform.localPosition, MoneyTarget.transform.localPosition, 0.05f);

        yield return new WaitForSeconds(2.0f);

        ExpUpAnim.transform.localPosition = new Vector3(-391, 820, 0);
        MoneyUpAnim.transform.localPosition = new Vector3(-147, 820, 0);
        ExpUpAnim1.transform.localPosition = new Vector3(-391, 820, 0);
        MoneyUpAnim1.transform.localPosition = new Vector3(-147, 820, 0);
        ExpUpAnim2.transform.localPosition = new Vector3(-391, 820, 0);
        MoneyUpAnim2.transform.localPosition = new Vector3(-147, 820, 0);
        ExpUpAnim3.transform.localPosition = new Vector3(-391, 820, 0);
        MoneyUpAnim3.transform.localPosition = new Vector3(-147, 820, 0);
        ExpUpAnim4.transform.localPosition = new Vector3(-391, 820, 0);
        MoneyUpAnim4.transform.localPosition = new Vector3(-147, 820, 0);

        Anim.SetActive(false);
    }
}
