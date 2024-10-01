using UnityEngine;
// �v���C���[�̈ړ���?
public class PlayerMove : MonoBehaviour
{
    // �ړ����x�Ƃ��Ďg�p����ϐ�
    [SerializeField]
    float moveSpeed;
    void FixedUpdate()
    {
        // �L�[�{�[�h��W��������Ă��邩�m���߂�
        if (Input.GetKey(KeyCode.W))
        {
            /* ���ۂɈړ���?����?
            ������ꏊ����Cz������moveSpeed�̕������i��łƂ������� */
            gameObject.transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        // S�L�[�������ꂽ���ǂ���
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        }
        // D�L�[�������ꂽ���ǂ���
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        // A�L�[�������ꂽ���ǂ���
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        gameObject.transform.position = gameObject.transform.position;
    }
}