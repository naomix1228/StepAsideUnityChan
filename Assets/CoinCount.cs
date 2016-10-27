using UnityEngine;
using System.Collections;

public class CoinCount : MonoBehaviour
{


    public GameObject coinprefab;
    public GameObject coneprefab;
    public GameObject carprefab;

    //アイテムを格納
    GameObject[] existprefab;
    //アクティブ最大数
    public int maxprefab = 2;


    GameObject unitychan;
    private int goalPos = 120;
    private float posRange = 3.4f;

    private bool isEnd = false;



    // Use this for initialization
    void Start()
    {
        //配列確保
        existprefab = new GameObject[maxprefab];
        //周期的に実行したい場合はコルーチン
        StartCoroutine(Exec());
        


    }


    

        void update()
    {
        
    }

    //アイテムを作成する
    IEnumerator Exec()
    {
        while (true)
        {
            Generate();
            yield return new WaitForSeconds(1.0f);
        }
    }

    void Generate()
    {
        this.unitychan = GameObject.Find("unitychan");
        float Spos = unitychan.transform.position.z + 100;
        float Epos = Spos + 5;


        if (Epos > goalPos) return;

        for (int enemyCount = 0; enemyCount < existprefab.Length; ++enemyCount)
        {
            if (existprefab[enemyCount] == null)
            {
                //アイテムを作成する
                for (float i = Spos; i < Epos; i += 15)
                {
                    //どのアイテムを出すのかをランダムに設定
                    int num = Random.Range(0, 10);
                    if (num <= 1)
                    {



                        //コーンをx軸方向に一直線に生成
                        for (float j = -1; j <= 1; j += 0.4f)
                        {

                            GameObject cone = Instantiate(coneprefab) as GameObject;
                            cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);

                        }
                    }

                    else
                    {
                        //レーンごとにアイテムを生成
                        for (int j = -1; j < 2; j++)
                        {
                            //アイテムの種類を決める
                            int item = Random.Range(1, 11);
                            //アイテムを置くZ座標のオフセットをランダムに設定
                            int offsetZ = Random.Range(-5, 6);
                            //50%コイン配置:30%車配置:10%何もなし
                            if (1 <= item && item <= 6)
                            {
                                GameObject coin = Instantiate(coinprefab) as GameObject;
                                coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);



                            }



                            else if (7 <= item && item <= 9)
                            {
                                GameObject car = Instantiate(carprefab) as GameObject;
                                car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                            }
                        }

                    }
                }
            }


        }

    }
    
}

