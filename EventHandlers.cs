/* 
 * @experimental
 *
 * CustomEvents.cs
 * Generated with https://github.com/coryrylan/custom-element-types
 */

using Microsoft.AspNetCore.Components;

namespace clarity_blazor;

[EventHandler("oncloseChange", typeof(CustomEventArgs<Object>))] // cds-alert: notify when the user has clicked the dismiss button
[EventHandler("onexpandedChange", typeof(CustomEventArgs<Object>))] // cds-accordion-panel: notify when the user has clicked the panel header
[EventHandler("oncloseChange", typeof(CustomEventArgs<Object>))] // cds-dropdown: Notify user when close event has occurred
[EventHandler("oncloseChange", typeof(CustomEventArgs<Object>))] // cds-modal: notify when the user has clicked the close button
[EventHandler("onexpandedChange", typeof(CustomEventArgs<Object>))] // cds-navigation-group: notify when the user has clicked the navigation expand/collapse button
[EventHandler("onexpandedChange", typeof(CustomEventArgs<Object>))] // cds-navigation: notify when the user has clicked the navigation expand/collapse button
[EventHandler("onexpandedChange", typeof(CustomEventArgs<Object>))] // cds-tree-item: notify when the user has clicked the expand / collapse button
[EventHandler("onselectedChange", typeof(CustomEventArgs<Object>))] // cds-tree-item: notify when the user has clicked the tree item
[EventHandler("oncloseChange", typeof(CustomEventArgs<Object>))] // cds-internal-overlay: Notify user when close event has occurred
[EventHandler("oncloseChange", typeof(CustomEventArgs<Object>))] // cds-internal-popup: Notify user when close event has occurred
public static class EventHandlers
{

}

public class CustomEventArgs<T> : EventArgs
{
  public T? Detail { get; set; }
}