using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideCanvas : MonoBehaviour
{
    public Canvas canvas; 
    public float slideDuration = 1f; // �����̵� �ִϸ��̼��� �ð�
    public float slideDistance = 300f; // ĵ������ �����̵��� �Ÿ�

    private Vector3 startPos; 
    private Vector3 targetPosLeft; 
    private Vector3 targetPosRight; 
    private bool isAnimating = false; // �ִϸ��̼��� ���� ������ �����ϴ� �÷���

    public static SlideCanvas instance;   //���� �����

    public GameObject FoodDishMoveObject;
    void Awake()
    {
        SlideCanvas.instance = this;  //���� �ʱ�ȭ��
    }
    void Start()
    {
        startPos = canvas.transform.position;
        targetPosLeft = startPos - new Vector3(slideDistance, 0f, 0f); 
        targetPosRight = startPos; 
    }

    public void SlideOutToRight()
    {
        StartCoroutine(wait());
        if (!isAnimating)
        {
            // �����̵� �ִϸ��̼��� �����Ͽ� ���������� �̲�������
            StartCoroutine(SlideCanvasCoroutine(targetPosRight));
        }
    }

    public void SlideInToLeft()
    {
        //FoodDishMoveObject.SetActive(true);
        MakeFood.instance.ToCollect.SetActive(false);
        MakeFood.instance.SyCollect.SetActive(false);
        if (!isAnimating)
        {
            // �����̵� �ִϸ��̼��� �����Ͽ� �������� �̲�������
            StartCoroutine(SlideCanvasCoroutine(targetPosLeft));
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        MakeFood.instance.PanCollect.SetActive(true);
        MakeFood.instance.ToCollect.SetActive(true);
        MakeFood.instance.SyCollect.SetActive(true);
    }
    IEnumerator SlideCanvasCoroutine(Vector3 targetPosition)
    {
        isAnimating = true;

        float elapsedTime = 0f;
        Vector3 startPosition = canvas.transform.position;

        while (elapsedTime < slideDuration)
        {
            // �ð��� �������� ���� ���ڸ� ���
            float t = Mathf.Clamp01(elapsedTime / slideDuration);

            // ��ǥ ��ġ�� ĵ���� �̵�
            canvas.transform.position = Vector3.Lerp(startPosition, targetPosition, t);

            // ����ð� ����
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        // ĵ������ ��ǥ ��ġ�� �����ߴ��� Ȯ��
        canvas.transform.position = targetPosition;

        isAnimating = false;

    }
}
