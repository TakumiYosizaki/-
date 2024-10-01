using UnityEngine;
// プレイヤーの移動処?
public class PlayerMove : MonoBehaviour
{
    // 移動速度として使用する変数
    [SerializeField]
    float moveSpeed;
    void FixedUpdate()
    {
        // キーボードのWが押されているか確かめる
        if (Input.GetKey(KeyCode.W))
        {
            /* 実際に移動を?う処?
            今いる場所から，z方向にmoveSpeedの分だけ進んでという命令 */
            gameObject.transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        // Sキーが押されたかどうか
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        }
        // Dキーが押されたかどうか
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        // Aキーが押されたかどうか
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        gameObject.transform.position = gameObject.transform.position;
    }
}