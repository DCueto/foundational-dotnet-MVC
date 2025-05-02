namespace NetUniversity.CSharp;

public delegate void MyHandlerEvent(string value);

public class EventPublisher
{
    private string theVal = "";

    // Define Event
    public event MyHandlerEvent valueChanged = null!;
    public string Val {
        set 
        { 
            this.theVal = value;
            this.valueChanged(this.theVal);
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
