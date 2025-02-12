# WF.CustomEvents

Some Custom Events for blazor

Includes stringpaste event 

```
<input @onstringpaste="@PasteEvent"/>

@code{
    private void PasteEvent(PasteEventArgs args){
        Console.WriteLine(args.PastedData);
    }
}
```