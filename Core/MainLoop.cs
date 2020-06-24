using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Common;
using Core.Events;

namespace Core
{
    public class MainLoop : IMainLoop
    {
        private static ILogger _logger;

        public MainLoop(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogDebug("Run");

            Routine routine1 = new Routine(_logger)
            {
                Delay = 2000,
                Name = "R1"
            };
            routine1.SomeEvent += (SomeEventHandlerArgs args) => { _logger.LogDebug($"R1 - event : {args.EventType}"); };

            Task.Factory.StartNew(() => routine1.Execute());

            Routine routine2 = new Routine(_logger)
            {
                Delay = 4000,
                Name = "R2"
            };

            Task.Factory.StartNew(() => routine2.Execute());
            
            Console.ReadKey();
            
            routine2.SomeEvent += (SomeEventHandlerArgs args) => { _logger.LogDebug($"R2 - event : {args.EventType}"); };

            Console.ReadKey();
        }
    }
}