namespace T9;

delegate int Calculator(int a, int b);

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }

    static void Main(string[] args)
    {
        int num1 = 40;
        int num2 = 33;
        string name = "    Hoang    Nghiem    ABC      ";
        
        string nameAfter = name.ChuanHoa();
        Console.WriteLine(nameAfter);

        //Calculator calculator = new Calculator(Sub);
        //Calculator calculator = delegate (int a, int b)
        //{
        //    return a + b;
        //};

        //int result = calculator(num1, num2);

        //Console.WriteLine("Ket qua: {0}", result);


        //ProcessBusinessLogic process = new ProcessBusinessLogic();
        //process.CompletedProcess += Process_CompletedProcess;
        //process.TickProcess += Process_TickProcess;
        //process.StartLogic();

        //ProcessBusinessLogic process1 = new ProcessBusinessLogic();
        //process1.CompletedProcess += Process_CompletedProcess1;
        //process1.StartLogic();


    }

    private static void Process_TickProcess(int i)
    {
        Console.WriteLine("Download.....({0}%)", i);
    }

    private static void Process_CompletedProcess()
    {
        Console.WriteLine("Send file to email hoangnm@gmail.com");
        Console.WriteLine("End");
    }

    private static void Process_CompletedProcess1()
    {
        Console.WriteLine("Play....");
        Console.WriteLine("End");
    }
}


