using System;
using System.Collections.Generic;
using DesignPatternsProgram.Adapter;

namespace DesignPatternsProgram
{
    public class Action : IAction
    {
        private readonly string _toDo;
        private Stack<string> _completedActions;

        public Action(string toDo)
        {
            _toDo = toDo;
            this._completedActions = new Stack<string>();
        }

        public string Do()
        {
            _completedActions.Push(_toDo);
            return _toDo;
        }

        public void Undo()
        {
            var undoneAction = _completedActions.Pop();
            Console.WriteLine("Taking back: " + undoneAction);
        }
    }
}