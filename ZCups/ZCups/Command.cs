using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ZCups
{
    abstract class ICommand
    {
        public abstract void Execute();

    }
    class Command : ICommand
    {
        private Receiver receiver;
        string Text;
        double X;
        DrinkSelection ds;

        public Command(DrinkSelection ds, string text, double x, Receiver receiver)
        {

            Text = text;
            X = x;
            this.ds = ds;
            this.receiver = receiver;

        }
        public override void Execute()
        {
            receiver.Operation(ds, Text, X);
        }

       
    }
    class Receiver
    {
       //DrinkSelection ds = new DrinkSelection();
        //public RichTextBox Billtb = new RichTextBox();

        public void Operation(DrinkSelection ds, string text, double bill)
        {
           
            DrinkSelection.bill = bill;
            ds.undo(text);
        }
    }
    class User
    {
        private Receiver receiver = new Receiver();
        Stack<ICommand> UndoStack = new Stack<ICommand>();

        public void Undo()
        {
            if (UndoStack.Count > 0)
            {
                ICommand cmd = UndoStack.Pop();               
                cmd.Execute();
            }

        }

        public void Compute(DrinkSelection ds, string text, double x)
        {
            UndoStack.Push(new Command(ds, text, x, receiver));

        }
    }

}
