using UnityEngine;
using System.Collections;

public class boss : MonoBehaviour {
	
	// Use this for initialization

	public GameObject croissaint;
	GameObject clone;
	//public int bossAlive;
	public int bossLife;

	void Start () {

		bossLife=2;
		InvokeRepeating ("LaunchProjectile", 3,2);

	}
	void LaunchProjectile (){
		clone = Instantiate(croissaint, transform.position, transform.rotation) as GameObject;
		print("croissant fired");
	}
void Update(){
		//bossAlive=bossLife;
		if(bossLife<=0){
			Destroy (gameObject);
		}
	

	}
//	void OnCollision2D(Collision2D collision){
//	if(collision.gameObject.tag=="Pizza"){
//		if (bossLife >1){
////				bossLife--;
////			}
////			if(bossLife==1){
////				Destroy(this.gameObject);
////
////			}
////
////		}
//	}
	
}
