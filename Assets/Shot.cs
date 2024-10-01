using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shot : MonoBehaviour
{
    // 弾のオブジェクト
    [SerializeField]
    GameObject bulletPrefab;
    // 銃口のオブジェクト。座標の取得に使用
    [SerializeField]
    GameObject muzzleObj;
    // 弾の速度
    [SerializeField]
    float bulletSpeed;
    // 銃口の座標
    Vector3 muzzulePosition;
    // 銃口の向き
    Quaternion muzzuleRotation;
    // レート。何秒間隔で撃てるか
    [SerializeField]
    float FireLate;
    // 経過時間を計測
    float currentTime;
    void Start()
    {
        // 最初なので経過は0
        currentTime = 0;
        // 座標
        muzzulePosition = muzzleObj.transform.position;
        // 向き
        muzzuleRotation = muzzleObj.transform.rotation;
    }
    // マズルも動くので情報を更新
    void UpdateMuzzuleTransdorm()
    {
        // 座標
        muzzulePosition = muzzleObj.transform.position;
        // 向き
        muzzuleRotation = muzzleObj.transform.rotation;
    }
    // 設定したレートの通りに動かすようにチェックする
    bool CheckFireLate()
    {
        if (currentTime > FireLate)
        {
            // 超えたのでタイマーリセット
            currentTime = 0;
            return true;
        }
        else return false;
    }
    void Update()
    {
        // マズルの情報は常に更新
        UpdateMuzzuleTransdorm();
        // 時間経過を加算
        currentTime += Time.deltaTime;
        // キー入力検知
        if (Input.GetMouseButton(0))
        {
            // ファイアレートを超えないかチェック
            if (CheckFireLate())
            {
                // 弾を生成
                var bulletObj = Instantiate(bulletPrefab, muzzulePosition, muzzuleRotation);
                bulletObj.transform.rotation = muzzuleRotation * bulletPrefab.transform.rotation;
                bulletObj.AddComponent<Bullet>();
                bulletObj.GetComponent<Rigidbody>().AddForce(muzzleObj.transform.forward * bulletSpeed, ForceMode.VelocityChange);
            }
        }
    }
}