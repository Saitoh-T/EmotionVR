using UnityEngine;

    public class LookAt : MonoBehaviour
    {
        //今回は見たいオブジェクト(向く方向)
        public GameObject target;
        //デバッグ用 見る位置が変わるのを検知
        Vector3 beforeTargetPosition;
        //自分の位置
        private Transform startPosition;


        float step = 0;
        //向くスピード(秒速)
        float speed = 5f;

        void Start()
        {
            startPosition = transform;
            beforeTargetPosition = target.transform.position;
        }



        // Update is called once per frame
        void Update()
        {
            //秒速に直す計算
            step += speed * Time.deltaTime;
            //向き始めと終わりの点を計算して、stepの値より、今向くべき方向を算出
            transform.rotation = Quaternion.Slerp(startPosition.rotation, Quaternion.LookRotation((target.transform.position - startPosition.position).normalized), step);






            //以下デバッグ用 ポジションが途中で変わるのを検出して再び向き始める
            if (beforeTargetPosition != target.transform.position)
            {
                step = 0;
                startPosition = this.transform;
            }
            beforeTargetPosition = target.transform.position;
        }
    }