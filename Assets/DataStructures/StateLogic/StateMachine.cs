﻿
using System;

namespace DataStructures.StateLogic
{
    /// <summary>
    /// A MonoBehaviour can use a StateMachine in order to be state driven and decides whether
    /// a State is changed or not based on Events or Inputs and communicates it to
    /// the StateMachine and if it does it provides a new State (IState Object).
    /// IState Objects have to be created on its own based on the available states and must implement IState!
    /// </summary>
    public class StateMachine
    {
        public IState CurrentState { get; private set; }
        public IState PreviousState { get; private set; }

        public void Initialize(IState startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }

        // Transition between two states
        public void ChangeState(IState newState)
        {
            CurrentState?.Exit();
            PreviousState = CurrentState;
            CurrentState = newState;
            CurrentState.Enter();
        }

        public void Update()
        {
            CurrentState?.Execute();
        }

        public void SwitchToPreviousState()
        {
            CurrentState.Exit();
            CurrentState = PreviousState;
            CurrentState.Enter();
        }
    }
}