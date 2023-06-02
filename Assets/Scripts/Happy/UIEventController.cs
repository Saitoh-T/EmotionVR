using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIEventController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textArea; // ������e��\������Text�I�u�W�F�N�g
    [SerializeField] private GameObject Dog; // ����Ώۂ̃L���[�u
    private BallPlay PlayState;

    // �J�n���ɌĂ΂�郁�\�b�h
    void Start()
    {
        textArea.text = "";
        PlayState = Dog.GetComponent<BallPlay>();
    }

    // Ball�{�^���������̓���
    public void OnBallButtonClick()
    {
        textArea.text = "Button Click: Ball Playing Mode";
        PlayState.enabled = true;
    }

    // �E�{�^���������̓���
    public void OnRightButtonClick()
    {
        textArea.text = "Button Click: Brushing Mode";
        PlayState.enabled = false;
    }

    // Food�{�^���������̓���
    public void OnFoodButtonClick()
    {
        textArea.text = "Button Click: Feeding Mode";
        PlayState.enabled = false;
    }

    // �`�F�b�N�{�b�N�X�������̓���
    public void OnToggle(bool value)
    {
        textArea.text = $"Toggle Value:{value}";
    }

    // �X�N���[���o�[���쎞�̓���
    public void OnScrollbar(float value)
    {
        textArea.text = $"Scrollbar Value:{value}";
    }
}