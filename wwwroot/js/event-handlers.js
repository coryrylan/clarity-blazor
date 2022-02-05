
/**
 * @experimental
 * 
 * wwwroot/custom-events.js
 * Generated with https://github.com/coryrylan/custom-element-types
 */

 const customEvents = {
  closeChange: true, // cds-dropdown, cds-modal, cds-internal-overlay, cds-internal-popup,
  expandedChange: true, // cds-navigation-group, cds-navigation, cds-tree-item,
  selectedChange: true, // 
};

/**
 * Workaround: Blazor ignores the event target and only listens to global events
 * this is a problem for most custom elements which dispatch CustomEvent types
 * that default to not bubbling.
 */
CustomEvent = class Bubbled extends CustomEvent {
  constructor(event, config) {
    const bubbles = customEvents[event] !== undefined ? customEvents[event] : config.bubbles;
    super(event, { ...config, bubbles });
  }
}

Object.keys(customEvents).map(event => {
  Blazor.registerCustomEventType(event, {
    browserEventName: event,
    createEventArgs: event => {
      return { detail: event.detail };
    }
  });
});
