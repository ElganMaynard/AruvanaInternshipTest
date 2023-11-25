using UnityEngine;
using System.Collections;

public class TouchScaling : MonoBehaviour {
	void OnMouseDown() {
		Scaling.ScaleTransform = this.transform;
	}
}