using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;

    public void SetContent(string title, string content) // void = 반환 값이 없음, 리턴하지 않아도 됨 
    {
        titleText.text = title;
        contentText.text = content;
    }


    public void ClosePopup()
    {
        Destroy(gameObject);
    }
}