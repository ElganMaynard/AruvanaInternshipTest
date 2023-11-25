using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshRenderer))]

public class Rotate : MonoBehaviour 
{

	#region ROTATE
	private float sensitivity = 1f;
	private Vector3 mouseReference;
	private Vector3 mouseOffset;
	private Vector3 rotation = Vector3.zero;
	private bool isRotating;


	#endregion

	void Update()
	{
		if(isRotating)
		{
			mouseOffset = (Input.mousePosition - mouseReference);

			rotation.y = -(mouseOffset.x + mouseOffset.y) * sensitivity;

			gameObject.transform.Rotate(rotation);

			mouseReference = Input.mousePosition;
		}
	}

	void OnMouseDown()
	{
		isRotating = true;

		mouseReference = Input.mousePosition;
	}

	void OnMouseUp()
	{
		isRotating = false;
	}

}