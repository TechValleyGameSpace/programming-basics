using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour {
    public MoveCube script;
	public bool isTrue = true;
	public int intNum = 1;
	public float floatNum = 2f;
	public string word = "Za Waludo";


	// Use this for initialization
	void Start () {
		int[] intArray = new int[] {1, 2};
		Debug.Log(intArray[0]);
		Debug.Log(intArray[1]);
		Debug.Log(intArray.Length);


		string test = "Heh";
		for(int i = 0; i < test.Length; i = i + 1) {
			Debug.Log(test[i]);
		}

		List<string> list = new List<string>() {"yes", "no", "maybe"};
		// Remove the second element
		list.RemoveAt(1);
		// Remove maybe
		list.Remove("maybe");
		for(int i = 0; i < list.Count; i = i + 1) {
			Debug.Log(list[i]);
		}
	}
}
