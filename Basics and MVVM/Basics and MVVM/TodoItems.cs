using System;
using System.Collections.Generic;
using System.Text;

namespace Basics_and_MVVM
{
   public class TodoItems
    {
        public string TodoText { get; set; }
        public bool Complete { get; set; }

        public TodoItems(string TodoText, bool Complete)
        {
            this.TodoText = TodoText;
            this.Complete = Complete;
        }
    }
}
