using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideCanvas : MonoBehaviour
{
    public Canvas canvas; 
    public float slideDuration = 1f; // 슬라이딩 애니메이션의 시간
    public float slideDistance = 300f; // 캔버스를 슬라이드할 거리

    private Vector3 startPos; 
    private Vector3 targetPosLeft; 
    private Vector3 targetPosRight; 
    private bool isAnimating = false; // 애니메이션이 진행 중인지 추적하는 플래그

    public static SlideCanvas instance;   //변수 선언부

    public GameObject FoodDishMoveObject;
    void Awake()
    {
        SlideCanvas.instance = this;  //변수 초기화부
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
            // 슬라이딩 애니메이션을 시작하여 오른쪽으로 미끄러진다
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
            // 슬라이딩 애니메이션을 시작하여 왼쪽으로 미끄러진다
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
            // 시간을 기준으로 보간 인자를 계산
            float t = Mathf.Clamp01(elapsedTime / slideDuration);

            // 목표 위치로 캔버스 이동
            canvas.transform.position = Vector3.Lerp(startPosition, targetPosition, t);

            // 경과시간 증가
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        // 캔버스가 목표 위치에 도달했는지 확인
        canvas.transform.position = targetPosition;

        isAnimating = false;

    }
}
