using UnityEngine;
using System.Collections;

public class State
{
	//the statemachine this state belongs to (so we can call its functions)
	private StateMachine _sm = null;

	//called just after the state gets instantiated
	public virtual void Init(StateMachine sm)
	{
		//store the state machine
		_sm = sm;
	}

	//called when we enter this state
	public virtual void Enter(){}
	//called every frane
	public virtual void Execute(){}
	//called when leaving this state
	public virtual void Exit(){}

	//helper function
	protected void ChangeState(State new_state)
	{
		_sm.ChangeState(new_state);
	}
}
