using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBehaviour : MonoBehaviour {

	public int count;
	public GameObject sphere;
	public GameObject cube;
	GameObject imtarget;

	// Use this for initialization
	void Start () {
		count = 0;
		imtarget =  GameObject.Find ("ImageTarget");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log ("touch");
			count++;
			if (count % 2 == 0) {		
				GameObject c = GameObject.Find ("phonemodel_ipadair_withtext(Clone)");

				if (c!=null) 
				{
					Destroy (c); 
				}

				GameObject v = (GameObject)Instantiate (sphere, new Vector3 (-130, 0, -85), Quaternion.Euler(-90, 180, 0));
				v.transform.parent = imtarget.transform;
			
				// 
			}
			else if (count % 2 == 1)
			{
				GameObject c = GameObject.Find ("phonemodel_iphone5_withtext(Clone)");
				if (c!=null) 
				{
					Destroy (c); 
				}


				GameObject v = (GameObject)Instantiate(cube, new Vector3(-200, 0, 0), Quaternion.Euler(-90, 180, 0));
				v.transform.parent = imtarget.transform;



			}
		}
	}
}
