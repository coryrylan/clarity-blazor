
/**
 * @experimental
 * 
 * wwwroot/BlazorApp.lib.module.js
 * Generated with https://github.com/coryrylan/custom-element-types
 * 
 * Workaround: Blazor ignores the event target and only listens to global events
 * this is a problem for most custom elements which dispatch CustomEvent types
 * that default to not bubbling.
 */
 CustomEvent = class Bubbled extends CustomEvent {
  constructor(event, config) {
    super(event, { ...config, bubbles: true });
  }
}
  
// cds-dropdown: Notify user when close event has occurred
// cds-modal: notify when the user has clicked the close button
// cds-internal-overlay: Notify user when close event has occurred
// cds-internal-popup: Notify user when close event has occurred
Blazor.registerCustomEventType('closeChange', {
  browserEventName: 'closeChange',
  createEventArgs: event => {
    return { detail: event.detail };
  }
});

// cds-navigation-group: notify when the user has clicked the navigation expand/collapse button
// cds-navigation: notify when the user has clicked the navigation expand/collapse button
// cds-tree-item: notify when the user has clicked the expand / collapse button
Blazor.registerCustomEventType('expandedChange', {
  browserEventName: 'expandedChange',
  createEventArgs: event => {
    return { detail: event.detail };
  }
});


Blazor.registerCustomEventType('selectedChange', {
  browserEventName: 'selectedChange',
  createEventArgs: event => {
    return { detail: event.detail };
  }
});
