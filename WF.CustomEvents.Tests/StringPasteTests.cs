using Bunit;
using Microsoft.AspNetCore.Components;
using WF.CustomEvents.Tests.Components;

namespace WF.CustomEvents.Tests;

public class PasteHandlerTests : Bunit.TestContext
{
    [Test]
    public void ShouldTriggerOnPasteEvent()
    {
        // Arrange
        PasteEventArgs? receivedArgs = null;
        var cut = RenderComponent<StringPasteEventComponent>(parameters =>
            parameters.Add(p => p.OnPaste, EventCallback.Factory.Create<PasteEventArgs>(this, e => receivedArgs = e))
        );
        
        // Act
        var pasteEventArgs = new PasteEventArgs { PastedData = "Hello, NUnit!" };

        cut.Find("div").TriggerEvent("onstringpaste", pasteEventArgs);

        // Assert
        Assert.That(receivedArgs, Is.Not.Null);
        Assert.That(receivedArgs.PastedData, Is.EqualTo("Hello, NUnit!"));
    }
}