using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDelete : MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんと壁の距離
	private float distance;

	// Use this for initialization
	void Start () {
		//Unityちゃんオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//Unityちゃんとカメラの位置（z座標）の差を求める
		this.distance = unitychan.transform.position.z - this.transform.position.z;

		
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんの位置に合わせて壁を移動
		this.transform.position = new Vector3 (0, this.transform.position.y,
			this.unitychan.transform.position.z - distance);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag ==
		   "TrafficConeTag" || other.gameObject.tag == "CoinTag") {
			Destroy (other.gameObject);

		}
	}
		
}
