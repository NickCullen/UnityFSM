using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour 
{
	//the current state
	private State _current_state = null;

	//called when you want to start the state machine
	public void Begin(State initial_state)
	{
		//prevent duplicating code - just call ChangeState
		ChangeState (initial_state);
	}

	//called when we want to change state
	public void ChangeState(State new_state)
	{
		//call exit on the current state (if any)
		if (_current_state != null) _current_state.Exit ();

		//change state
		_current_state = new_state;

		//call enter on the new current state (check neccassary incase the new_state was null)
		if (_current_state != null) 
		{
			//initialise the new state
			_current_state.Init(this);
			//call its enter function
			_current_state.Enter ();
		}
	}

	//update the current state
	void Update()
	{
		//call execute on the current state (if any)
		if (_current_state != null) _current_state.Execute ();
	}
}
