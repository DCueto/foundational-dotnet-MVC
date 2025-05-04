
using System.ComponentModel;

namespace NetUniversity.CSharp.Interfaces;

public class Document : IOperations, IMessaging, INotifyPropertyChanged
{
    private string name;
    public string DocumentName 
    { 
        get => name; 
        set
        {
            name = value;
            NotifyPropChanged("DocumentName");
        }
    }


    public Document(string name)
    {
        this.name = name;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropChanged(string propName) 
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
    }

    public bool HasToSave() => false;

    public void Load()
    {
        Console.WriteLine("This method is for loading a document");
    }

    public void Save()
    {
        Console.WriteLine("This method is for saving a document");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending email");
    }

    public void SendNotification()
    {
        Console.WriteLine("New notification");
    }

    public void SendTextMessage()
    {
        Console.WriteLine("Sending text message by iOS");
    }
}
