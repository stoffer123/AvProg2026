using DataProcessor.TransformStrategy;
using System.Runtime.CompilerServices;

namespace DataProcessor.Client
{
    public class Client
    {
        private DataProcessor _processor;
        private List<ITransformStrategy> _strategies;
        private Dictionary<string, Func<string>> _operations;

        public Client()
        {
            _processor = new DataProcessor(new TransformDefaultStrategy());
            _strategies = new()
            {
                new TransformDefaultStrategy(),
                new TransformPlus3Strategy(),
                new TransformSquareStrategy()
            };

            _operations = new()
            {
                { "Sum", () => _processor.SumOfTransforms().ToString() },
                {"Min", () => _processor.MinOfTransforms().ToString() },
                {"Max", () => _processor.MaxOfTransforms().ToString() },
                {"Liste", () => string.Join(",", _processor.ListOfTransforms()) }
            };
        }

        public void Run()
        {
            bool running = true;
            while(running)
            {
                ShowMainmenu();
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        ChooseStrategy();
                        break;
                    case "2":
                        KørAlleOperationer();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
            }
        }

        private void ShowMainmenu()
        {
            Console.WriteLine("\n--- DataProcessor Demo ---");
            Console.WriteLine($"Aktuel strategi: {_processor.GetStrategyName()}");
            Console.WriteLine();
            Console.WriteLine("1. Vælg strategi");
            Console.WriteLine("2. Kør alle operationer");
            Console.WriteLine("3. Afslut");
            Console.Write("\nValg: ");
        }

        private void ChooseStrategy()
        {
            Console.WriteLine("\nVælg strategi:");
            for(int i =  0; i < _strategies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_strategies[i].GetType().Name}");
            }
            Console.Write("\nValg: ");

            if(int.TryParse(Console.ReadLine(), out int valg) && valg >= 1 && valg <= _strategies.Count)
            {
                _processor.SetStrategy(_strategies[valg - 1]);
                Console.WriteLine($"Stragegi skiftet til: {_strategies[valg - 1].GetType().Name}");
            }
            else
            {
                Console.WriteLine("Ugyldigt valg");
            }
        }

        private void KørAlleOperationer()
        {
            Console.WriteLine($"\nResultater med {_processor.GetStrategyName()}:");
            Console.WriteLine(new string('-', 30));

            foreach(var op in _operations)
            {
                Console.WriteLine($"{op.Key}: {op.Value()}");
            }
        }
    }
}

