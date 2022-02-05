/* 
 * @experimental
 *
 * CustomEvents.cs
 * Generated with https://github.com/coryrylan/custom-element-types
 */

using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace clarity_blazor;

[EventHandler("oncloseChange", typeof(CustomEventArgs))] // cds-alert: notify when the user has clicked the dismiss button
[EventHandler("onexpandedChange", typeof(CustomEventArgs))] // cds-accordion-panel: notify when the user has clicked the panel header
[EventHandler("oncloseChange", typeof(CustomEventArgs))] // cds-dropdown: Notify user when close event has occurred
[EventHandler("oncloseChange", typeof(CustomEventArgs))] // cds-modal: notify when the user has clicked the close button
[EventHandler("onexpandedChange", typeof(CustomEventArgs))] // cds-navigation-group: notify when the user has clicked the navigation expand/collapse button
[EventHandler("onexpandedChange", typeof(CustomEventArgs))] // cds-navigation: notify when the user has clicked the navigation expand/collapse button
[EventHandler("onexpandedChange", typeof(CustomEventArgs))] // cds-tree-item: notify when the user has clicked the expand / collapse button
[EventHandler("onselectedChange", typeof(CustomEventArgs))] // cds-tree-item: notify when the user has clicked the tree item
[EventHandler("oncloseChange", typeof(CustomEventArgs))] // cds-internal-overlay: Notify user when close event has occurred
[EventHandler("oncloseChange", typeof(CustomEventArgs))] // cds-internal-popup: Notify user when close event has occurred
public static class EventHandlers
{

}

public class CustomEventArgs : EventArgs
{
  public dynamic? Detail { get; set; }

  /* Returns the detail value of CustomEvent with given type */
  public T GetDetail<T>() {
    return JsonSerializer.Deserialize<T>(Detail); // used to cast dynamic type, unknown until event occurs at runtime
  }
}
