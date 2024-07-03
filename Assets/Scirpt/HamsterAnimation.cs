using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterAnimation : MonoBehaviour
{
    public static HamsterAnimation Instance;

    private Animator animator;


    private void Awake()
    {
        HamsterAnimation.Instance = this;

    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Heart()
    {
        StartCoroutine(HeartTrigger());
    }
    public void Soso()
    {
        StartCoroutine(SosoTrigger());
    }
    public void Angry()
    {
        StartCoroutine(AngryTrigger());
    }

    IEnumerator HeartTrigger()
    {
        animator.SetTrigger("Heart");
        yield return new WaitForSeconds(2.0f);
        //animator.ResetTrigger("Heart");
    }
    IEnumerator SosoTrigger()
    {
        animator.SetTrigger("Soso");
        yield return new WaitForSeconds(2.0f);
        //animator.ResetTrigger("Soso");
    }
    IEnumerator AngryTrigger()
    {
        animator.SetTrigger("Angry");
        yield return new WaitForSeconds(2.0f);
        //animator.ResetTrigger("Angry");
    }
}
