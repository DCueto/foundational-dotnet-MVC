namespace NetUniversity.CSharp;

public delegate void MyHandlerEvent(string value);

public class MyEventArgs : EventArgs
{
    public required string data;
}

public class EventPublisher
{
    private string theVal = "";

    // Define Event
    public event MyHandlerEvent valueChanged = null!;

    // .NET Event
    public event EventHandler<MyEventArgs> myEvent = null!;
    public string Val {
        set 
        { 
            this.theVal = value;

            // Event
            this.valueChanged(this.theVal);

            // .NET Event
            this.myEvent(this, new MyEventArgs { data = this.theVal });
        }
    }
}

public static class Events{
    public static void RunEvents()
    {
        EventPublisher obj = new EventPublisher();

        // Anonymous events
        obj.valueChanged += delegate (string value)
        {
            Console.WriteLine($"Property value has changed. Value: {value}");
        };

        // Chain events
        obj.valueChanged += new MyHandlerEvent(eventLogic1);
        obj.valueChanged += new MyHandlerEvent(eventLogic2);

        // Dotnet Event
        obj.myEvent += delegate (object? sender, MyEventArgs e)
        {
            if (sender != null)
                Console.WriteLine($"Sender {sender.GetType()}: property value changed is {e.data}");
        };

        static void eventLogic1(string value)
        {
            Console.WriteLine($"Handler event 2 is being triggered. Value: {value}");
        }

        static void eventLogic2(string value)
        {
            Console.WriteLine($"Handler event 3 is being triggered. Value: {value}");
        }

        TriggerEvents(obj);
    }
    
    public static void TriggerEvents(EventPublisher obj)
    {
        string str;
        do
        {
            Console.WriteLine("Insert a value");
            str = Console.ReadLine()!;
            if (str.ToLower() != "exit")
            {
                obj.Val = str;
            }

        } while (str.ToLower() != "exit");

        Console.WriteLine("Program exited successfully!");
    }
    
}
