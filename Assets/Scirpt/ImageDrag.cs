using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDrag : MonoBehaviour
{
    private Vector3 m_Offset;
    private float m_ZCoord;

    public GameObject TablePosition;

    public GameObject TrashButton;

    public GameObject SpeechBubble;

    Vector2 Startpo;
    Vector2 Tablepo;

    bool MouseUp = true;

    public static ImageDrag instance;

    private void Awake()
    {
        ImageDrag.instance = this;
    }
    private void Start()
    {
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
            SpeechBubble.SetActive(false);
            TrashButton.SetActive(false);
            Debug.Log("fooddish");
            MouseUp = false;
            transform.position = Tablepo;
            StartCoroutine(Check());
        }
    }

    IEnumerator Check()
    {
        FoodCheck.instance.foodCheck();

        yield return new WaitForSeconds(5.0f);
        MouseUp = true;
        transform.position = Startpo;
        SpeechBubble.SetActive(true);

        this.gameObject.SetActive(false);
    }

}
