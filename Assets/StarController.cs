using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    //回転速度
    private float rotSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //回転を開始する角度を設定：y軸はランダムに止めておく
        this.transform.Rotate(0, Random.Range(0, 360), 0);    
    }

    // Update is called once per frame
    void Update()
    {
        //回転(x軸、ｙ軸、ｚ軸）：y軸中心に回転させる
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
