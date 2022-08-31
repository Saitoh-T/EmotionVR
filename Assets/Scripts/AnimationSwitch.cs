using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    public AnimationClip anim1;
    public AnimationClip anim2;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(ChangeTest_1());
    }

    /* ---------- Test_1 Coroutine ------------
     * Animation��Test_1�ɕύX���čĐ�����R���[�`��
     */
    IEnumerator ChangeTest_1()
    {
        GetComponent<Animation>().Stop();

        yield return null;

        GetComponent<Animation>().Play(anim1.name);

        yield return null;
    }

    /* ---------- Test_2 Coroutine ------------
     * Animation��Test_2�ɕύX���čĐ�����R���[�`��
     */
    IEnumerator ChangeTest_2()
    {
        GetComponent<Animation>().Stop();

        yield return null;

        GetComponent<Animation>().Play(anim2.name);

        yield return null;
    }
}
