/* 
 * @experimental
 *
 * CustomEvents.cs
 * Generated with https://github.com/coryrylan/custom-element-types
 */

using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace clarity_blazor;

[EventHandler("oncloseChange", typeof(CustomEventArgs))] // cds-dropdown, cds-modal, cds-internal-overlay, cds-internal-popup
[EventHandler("onexpandedChange", typeof(CustomEventArgs))] // cds-navigation-group, cds-navigation, cds-tree-item
[EventHandler("onselectedChange", typeof(CustomEventArgs))] // 
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