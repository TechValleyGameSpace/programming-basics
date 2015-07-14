using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {
	public float speed;
	void Update() {
		Vector3 pos = transform.position;
		pos.x = pos.x + speed * Time.deltaTime;
		transform.position = pos;
	}
}
