using Microsoft.AspNetCore.Components;

namespace WF.CustomEvents;

[EventHandler("onstringpaste", typeof(PasteEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
public static class EventHandlers
{
}

public class PasteEventArgs : EventArgs
{
    public string? PastedData { get; set; }
}