using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContoroller : MonoBehaviour
{
    
    //点数を表示するテキスト
    private GameObject scoreText;

    //Scoreの初期値の設定（０点）
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
       this.scoreText = GameObject.Find("ScoreText");
        

    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    //ターゲットにあたったときの処理
    //smallStar->10,largeStar->20,smallCloud->30,LargeCloud->50
    // タグごとに点数を設定する
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="SmallStarTag")
        {
            score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 50;
        }

      //点数を表示する
        this.scoreText.GetComponent<Text>().text = "Score:" + score;

        
    }
}
