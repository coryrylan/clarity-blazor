# Clarity Design + Blazor

This is a experimental demo using [.NET Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) and the [Clarity Design System](https://clarity.design). This demo app demonstrates how to build a Web UI using Clarity Design and C# compiled to [Web Assembly](https://developer.mozilla.org/en-US/docs/WebAssembly).

[Live Demo](https://cds-blazor.web.app/)

## Getting Started

1. Install [.NET SDK](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/install)
2. Install [NodeJS](https://nodejs.org/en/)
3. Run `npm install` in root of repo
4. Run `npm start`

Generated type and custom event meta data for Blazor is created with the [custom-element-types](https://github.com/coryrylan/custom-element-types) project. See generated data in `wwwroot/event-handlers.js` and `EventHandlers.cs`.

Note: currently Blazor only can listen to events that bubble. Custom Events however by default do not bubble.
As a workaround, set your Web Component Custom Events to bubble or see the workaround in `wwwroot/event-handlers.js`.
