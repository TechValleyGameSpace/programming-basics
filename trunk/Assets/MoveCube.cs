using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {
	public Vector3 speed;
	void Update() {
		Vector3 pos = transform.position;
		pos += speed * Time.deltaTime;
		transform.position = pos;
	}
}
