namespace ConnorWyatt.EventStoreExample.Shared.Subscriptions;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class SubscriptionAttribute : Attribute
{
  public string StreamName { get; }

  public SubscriptionAttribute(string streamName) => StreamName = streamName;
}
