using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    private Animation anim;

    public AnimationClip test_1;
    public AnimationClip test_2;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine("ChangeTest_1");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine("ChangeTest_1");
        }
    }

    /* ---------- Test_1 Coroutine ------------
     * AnimationをTest_1に変更して再生するコルーチン
     */
    IEnumerator ChangeTest_1()
    {
        animation.Stop();

        yield return null;

        animation.clip = test_1;

        yield return null;

        animation.Play("test_1");

        yield return null;
    }

    /* ---------- Test_2 Coroutine ------------
     * AnimationをTest_2に変更して再生するコルーチン
     */
    IEnumerator ChangeTest_2()
    {
        animation.Stop();

        yield return null;

        animation.clip = test_2;

        yield return null;

        animation.Play("test_2");

        yield return null;
    }
}
