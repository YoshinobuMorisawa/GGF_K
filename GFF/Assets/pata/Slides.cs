using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Slides : MonoBehaviour {

	[SerializeField]
	GameObject test;

	private List<GameObject> objects = new List<GameObject>();
	[SerializeField]
	private List<GameObject> ansObjects;

	private Vector2 originPos = new Vector2(10, -2);
	private int index = 0;

	public void Add(GameObject prefab){
		int index = objects.Count;
		test.GetComponent<Image>().sprite = prefab.GetComponent<Image>().sprite;
		var itemobj = Instantiate(test);
		RectTransform item = itemobj.GetComponent<RectTransform>();
		item.SetParent(transform, false);
		item.sizeDelta = new Vector2(50, 50);
		
		item.transform.position = item.parent.transform.position + new Vector3(originPos.x + index * (20), originPos.y, 0);
		objects.Add(itemobj);
	}

	public void Delete(){
		foreach(GameObject x in objects){
			GameObject.Destroy(x);
		}
		objects.Clear();
	}

	public int[] TypeCount(){
		int[] cnt = detectObject();
		return cnt;
	}

	private int[] detectObject(){
		int[] cnt = new int[7];
		foreach(GameObject x in objects){
			for(int i = 0; i<ansObjects.Count; i++){
				if(ansObjects[i] == x){
					cnt[i]++;
				}
			}
		}
		return cnt;
	}
}