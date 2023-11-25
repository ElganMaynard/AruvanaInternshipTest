using UnityEngine;

public class BlinkColor : MonoBehaviour
{
public Color startColor = Color.black;
public Color endColor = Color.white;
[Range (0,10)]
public float speed = 1;

Renderer ren;

void Awake(){
    ren = GetComponent<Renderer>();
}

void Update(){
    ren.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
}
}
