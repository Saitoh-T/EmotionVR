using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIEventController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textArea; // ������e��\������Text�I�u�W�F�N�g
    [SerializeField] private GameObject cube; // ����Ώۂ̃L���[�u

    // �J�n���ɌĂ΂�郁�\�b�h
    void Start()
    {
        textArea.text = "";
    }

    // ���{�^���������̓���
    public void OnLeftButtonClick()
    {
        textArea.text = "Button Click: ���ړ�";
        Vector3 pos = cube.transform.position;
        pos.x += -0.5f;
        cube.transform.position = pos;
    }

    // �E�{�^���������̓���
    public void OnRightButtonClick()
    {
        textArea.text = "Button Click: �E�ړ�";
        Vector3 pos = cube.transform.position;
        pos.x += 0.5f;
        cube.transform.position = pos;
    }

    // �����{�^���������̓���
    public void OnInitButtonClick()
    {
        textArea.text = "Button Click: �����l�ʒu";
        Vector3 pos = cube.transform.position;
        pos.x = 0f;
        cube.transform.position = pos;
    }

    // �`�F�b�N�{�b�N�X�������̓���
    public void OnToggle(bool value)
    {
        textArea.text = $"Toggle Value:{value}";
        cube.SetActive(value);
    }

    // �X�N���[���o�[���쎞�̓���
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