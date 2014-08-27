using UnityEngine;
using System.Collections;

public class C1 : MonoBehaviour {

	private Vector3 _movement;

	private Color initialColor;

	// Use this for initialization
	void Start () {
		initialColor = renderer.material.color;
	
	}
	
	// Update is called once per frame
	void Update () {
		_movement = Vector3.zero;
		
		if( Input.GetKey(KeyCode.UpArrow) )
		{
			_movement.y += 5f;
		}
		
		if( Input.GetKey( KeyCode.DownArrow ) )
		{
			_movement.y -= 5f;
		}

		if( Input.GetKey(KeyCode.RightArrow) )
		{
			_movement.x += 5f;
		}
		
		if( Input.GetKey( KeyCode.LeftArrow ) )
		{
			_movement.x -= 5f;
		}
		
		// follow this pattern
		
		transform.Translate( _movement * Time.deltaTime );
	
	}

	void OnMouseOver()
	{
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit()
	{
		renderer.material.color = initialColor;
	}
}
