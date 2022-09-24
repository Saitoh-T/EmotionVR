using UnityEngine;

    public class LookAt : MonoBehaviour
    {
        //����͌������I�u�W�F�N�g(��������)
        public GameObject target;
        //�f�o�b�O�p ����ʒu���ς��̂����m
        Vector3 beforeTargetPosition;
        //�����̈ʒu
        private Transform startPosition;


        float step = 0;
        //�����X�s�[�h(�b��)
        float speed = 5f;

        void Start()
        {
            startPosition = transform;
            beforeTargetPosition = target.transform.position;
        }



        // Update is called once per frame
        void Update()
        {
            //�b���ɒ����v�Z
            step += speed * Time.deltaTime;
            //�����n�߂ƏI���̓_���v�Z���āAstep�̒l���A�������ׂ��������Z�o
            transform.rotation = Quaternion.Slerp(startPosition.rotation, Quaternion.LookRotation((target.transform.position - startPosition.position).normalized), step);






            //�ȉ��f�o�b�O�p �|�W�V�������r���ŕς��̂����o���čĂь����n�߂�
            if (beforeTargetPosition != target.transform.position)
            {
                step = 0;
                startPosition = this.transform;
            }
            beforeTargetPosition = target.transform.position;
        }
    }