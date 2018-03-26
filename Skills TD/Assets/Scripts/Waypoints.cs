using UnityEngine;

public class Waypoints : MonoBehaviour {

	public static Transform[] WayPoints;

	void Awake ()
	{
		WayPoints = new Transform[transform.childCount];
		for (int i = 0; i < WayPoints.Length; i++) 
		{
			WayPoints[i] = transform.GetChild(i);
		}
	}
}