using UnityEngine;
using System.Collections;



public class Boss {

	private int hp = 100;		// 体力
	private int power = 25;		// 攻撃力
	private int mp = 53;        // MP

	// 攻撃用の関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	// Magic関数

	public void Magic(){
		
		int sum = this.mp;
		for ( int i = 0; i <= 10; i++ ) {
			sum -= 5;
			if (sum > 0) {
				Debug.Log ("魔法攻撃をした。 残りMPは" + sum);
			} else { 
				Debug.Log ("魔法攻撃をした。 MPが足りないため魔法が使えない");
			}
		}
	}

	// 防御用の関数
	public void Defence(int damage){
		// 残りhpを減らす
		this.hp -= damage;
		Debug.Log (damage + "のダメージを受けた");
	}
}





public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] array = new int[5];

		array[0] = 110;
		array[1] = 220;
		array[2] = 330;
		array[3] = 440;
		array[4] = 550;

		Debug.Log (array[0]);
		Debug.Log (array[1]);
		Debug.Log (array[2]);
		Debug.Log (array[3]);
		Debug.Log (array[4]);



		for(int i = array.Length - 1; i >= 0; i-- ){
			Debug.Log (array[i]);
		}



		// BossクラスのlastBoss変数を宣言してインスタンスを生成して代入
		Boss lastBoss = new Boss();
		// BossクラスのmidBoss変数を宣言してインスタンスを生成して代入
		Boss midBoss = new Boss();

		// lastBoss変数の持つ、攻撃用のAttack関数を呼び出す
		lastBoss.Attack();
		// lastBoss変数の持つ、防御用のDefence関数を呼び出す
		lastBoss.Defence(3);
		// lastBoss変数の持つ、魔法攻撃用のMagic関数を呼び出す
		lastBoss.Magic();
		// midBoss変数の持つ、攻撃用のAttack関数を呼び出す
		midBoss.Attack();
		// midBoss変数の持つ、防御用のDefence関数を呼び出す
		midBoss.Defence(5);
			
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
