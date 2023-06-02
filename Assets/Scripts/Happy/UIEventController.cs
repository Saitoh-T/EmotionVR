using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIEventController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textArea; // 操作内容を表示するTextオブジェクト
    [SerializeField] private GameObject Dog; // 操作対象のキューブ
    private BallPlay PlayState;

    // 開始時に呼ばれるメソッド
    void Start()
    {
        textArea.text = "";
        PlayState = Dog.GetComponent<BallPlay>();
    }

    // Ballボタン押下時の動作
    public void OnBallButtonClick()
    {
        textArea.text = "Button Click: Ball Playing Mode";
        PlayState.enabled = true;
    }

    // 右ボタン押下時の動作
    public void OnRightButtonClick()
    {
        textArea.text = "Button Click: Brushing Mode";
        PlayState.enabled = false;
    }

    // Foodボタン押下時の動作
    public void OnFoodButtonClick()
    {
        textArea.text = "Button Click: Feeding Mode";
        PlayState.enabled = false;
    }

    // チェックボックス押下時の動作
    public void OnToggle(bool value)
    {
        textArea.text = $"Toggle Value:{value}";
    }

    // スクロールバー操作時の動作
    public void OnScrollbar(float value)
    {
        textArea.text = $"Scrollbar Value:{value}";
    }
}