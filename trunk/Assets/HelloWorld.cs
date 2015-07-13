using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {
	public bool isTrue = true;
	public int intNum = 1;
	public float floatNum = 2f;
	public string word = "Za Waludo";


	// Use this for initialization
	void Start () {
		Debug.Log(typeof(bool));
		string x = "Hello World!";
		Debug.Log(x.Replace("Hello", "Goodbye"));
	}
}
