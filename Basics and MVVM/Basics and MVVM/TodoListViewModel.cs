using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;


namespace Basics_and_MVVM
{
    public class TodoListViewModel
    {
        // Jo apna model hoga usak Collection bana lo ya asy hai jaisy DataTable
        public ObservableCollection<TodoItems> TodoItems { get; set; }

        // Constructor bana lo
        public TodoListViewModel()
        {
            // Initialize kro Observable Collection ko
            TodoItems = new ObservableCollection<TodoItems>();

            // data Daldo usme
            TodoItems.Add(new TodoItems("Salman",true));
            TodoItems.Add(new TodoItems("Aliyan",false));
            TodoItems.Add(new TodoItems("Tahir", true));

        }
        // jab enter hoga to Add todoCommand us ko 
        public ICommand AddTodoCommand => new Command(AddTodoItem);

        public  string NewTodoInputValue { get; set; }

        void AddTodoItem()
        {
            TodoItems.Add(new TodoItems(NewTodoInputValue, false));
            
        }


        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItems TodoItemRemove = o as TodoItems;
            TodoItems.Remove(TodoItemRemove);
        }

     

    }
}
