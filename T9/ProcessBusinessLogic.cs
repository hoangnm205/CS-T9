using System;
namespace T9
{
    public delegate void Notify();
    public delegate void TickNotify(int i);
    public class ProcessBusinessLogic
	{
		public event Notify CompletedProcess;
		public event TickNotify TickProcess;

		public ProcessBusinessLogic()
		{
		}

		public void StartLogic()
		{
			Console.WriteLine("Start Download");

			for (int i = 0; i <= 100; i+=10)
			{
                Thread.Sleep(1000);
                OnTickProcess(i);	
            }
			
            OnCompletedProcess();
        }

		private void OnCompletedProcess()
		{
            CompletedProcess.Invoke();
        }

        private void OnTickProcess(int i)
        {
            TickProcess.Invoke(i);
        }
    }
}

