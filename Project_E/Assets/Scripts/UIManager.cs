using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab; // 프리팹 변수
    public Transform canvasTransform; // 위치 변수
    public string TitleText; // 어느 팝업을 띄울지
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform); // 생성한 팝업 변수
        Popup popupScript = newPopup.GetComponent<Popup>(); // 팝업 스크립트 변수

        popupScript.SetContent(this.TitleText, this.ContentText); // 팝업 내용 설정
    }
}