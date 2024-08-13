using System;
using System.ComponentModel;

namespace RPG.StatBlock{
    public class Action{
        private string actionName = "";
        private string description = "";

        public string ActionName{
            get { return actionName; }
            set { actionName = value; }
        }
        public string Description{
            get { return description; }
            set { description = value; }
        }
    }
}