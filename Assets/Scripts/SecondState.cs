using UnityEngine;
using System.Collections;

public class SecondState : State 
{
	//stay in this state for 5 seconds then go to second state
	float _cur_time = 0.0f;
	float _max_time = 5.0f;
	
	
	public override void Enter ()
	{
		Debug.Log ("Second State Enter");
	}
	
	public override void Execute ()
	{
		//add current time
		_cur_time += Time.deltaTime;
		
		//if it exceeds max time go to First state
		if (_cur_time >= _max_time) 
		{
			ChangeState(new FirstState());
		}
	}
	
	public override void Exit ()
	{
		Debug.Log ("Second State Exit");
	}
}
