public abstract class MenuProgram
{
    protected virtual void PrintMenu(){}

    protected virtual int ChooseOption(){
        Console.Write("Enter Your Option: ");
        int Option = Convert.ToInt32(Console.ReadLine());
        return Option;
    }

    protected abstract void DoSomething(int Option);

    public void Run(){
        bool running = true;
        while (running)
        {
            PrintMenu();
            int Option = ChooseOption();

            DoSomething(Option);

            if(Option == 0) running = false;
        }
    }
}