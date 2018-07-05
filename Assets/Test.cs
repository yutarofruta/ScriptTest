using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;          // 体力
    private int power = 25;        // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic() {
        if(mp >= 5) {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}

public class Test : MonoBehaviour {

    int[] array = {0, 2, 4, 6, 8};

	// Use this for initialization
	void Start () {

        Boss lastBoss = new Boss();

        for(int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--) {
            Debug.Log(array[i]);
        }
        for(int i = 1; i <= 11; i++) {
            Debug.Log(i + "回目の攻撃！");
            lastBoss.Magic();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
