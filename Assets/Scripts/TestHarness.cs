using UnityEngine;
using System.Collections;

[RequireComponent(typeof(StateMachine))]
public class TestHarness : MonoBehaviour 
{
	//the state machine
	StateMachine _sm = null;

	void Awake()
	{
		//get the state machine
		_sm = GetComponent<StateMachine> ();
	}

	void Start()
	{
		//if not null then begin the state machine by passing in the first state
		if (_sm != null) _sm.Begin (new FirstState ());
	}
}
