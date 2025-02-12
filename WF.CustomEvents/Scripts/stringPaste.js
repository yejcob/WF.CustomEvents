export function afterStarted(blazor) {
    blazor.registerCustomEventType('stringpaste', {
        browserEventName: 'paste',
        createEventArgs: event => {
            return {
                pastedData: event.clipboardData.getData('text')
            };
        }
    });
}