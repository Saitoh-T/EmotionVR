using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIEventController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textArea; // 操作内容を表示するTextオブジェクト
    [SerializeField] private GameObject cube; // 操作対象のキューブ

    // 開始時に呼ばれるメソッド
    void Start()
    {
        textArea.text = "";
    }

    // 左ボタン押下時の動作
    public void OnLeftButtonClick()
    {
        textArea.text = "Button Click: 左移動";
        Vector3 pos = cube.transform.position;
        pos.x += -0.5f;
        cube.transform.position = pos;
    }

    // 右ボタン押下時の動作
    public void OnRightButtonClick()
    {
        textArea.text = "Button Click: 右移動";
        Vector3 pos = cube.transform.position;
        pos.x += 0.5f;
        cube.transform.position = pos;
    }

    // 初期ボタン押下時の動作
    public void OnInitButtonClick()
    {
        textArea.text = "Button Click: 初期値位置";
        Vector3 pos = cube.transform.position;
        pos.x = 0f;
        cube.transform.position = pos;
    }

    // チェックボックス押下時の動作
    public void OnToggle(bool value)
    {
        textArea.text = $"Toggle Value:{value}";
        cube.SetActive(value);
    }

    // スクロールバー操作時の動作
    public void OnScrollbar(float value)
    {
        textArea.text = $"Scrollbar Value:{value}";
        Vector3 scale = cube.transform.localScale;
        scale.x = 1 + value;
        scale.y = 1 + value;
        scale.z = 1 + value;
        cube.transform.localScale = scale;
    }
}