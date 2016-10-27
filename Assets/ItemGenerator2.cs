using UnityEngine;
using System.Collections;

public class ItemGenerator2 : MonoBehaviour
{


    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;

    GameObject[] tagObjects;

    private GameObject unitychan;

    //private int startPos = -160;
    //private int goalPos = 120;

    private float posRange = 3.4f;

    //アイテムの生成範囲
    //private float Spos = unitychan.transform.position.z;
    //private float Epos = Spos + 80;

    // Use this for initialization
    void Start()
    {







    }



    // Update is called once per frame
    void Update()
    {


        //ユニティちゃんの位置
        this.unitychan = GameObject.Find("unitychan");

        float Spos = unitychan.transform.position.z;
        float Epos = Spos + 80;


        //int coinCount = this.coinPrefab.transform.Count;




        //一定の距離ごとにアイテムを生成
        for (float i = Spos; i < Epos; i += 15)
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                
                

                    //コーンをx軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        for (int h = 0; h < 5; h++)
                        {                      
                           GameObject cone = Instantiate(conePrefab) as GameObject;
                           cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                        }
                    }
            }









        }
    }
}

   

