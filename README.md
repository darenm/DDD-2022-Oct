# Source for Denver Dev Day Oct 2022 Building for the Web using WinUI and the Uno Platform

A demonstration on using the Uno Platform to build a Win32 Desktop application and then running it on the web using WebAssembly (WASM).

## Session Outline

* What is WinUI?
* What is the Uno Platform?
* What is WebAssembly?
* Build a ToDo App
* Questions?

## What is WinUI?

The Windows UI Library (WinUI) is a native user experience (UX) framework for both Windows desktop and UWP applications.

By incorporating the Fluent Design System into all experiences, controls, and styles, WinUI provides consistent, intuitive, and accessible experiences using the latest user interface (UI) patterns.

With support for both desktop and UWP apps, you can build with WinUI from the ground up, or gradually migrate your existing MFC, WinForms, or WPF apps using familiar languages such as C++, C#, Visual Basic, and Javascript (using React Native for Windows).

Learn more [here](https://learn.microsoft.com/en-us/windows/apps/winui/).

![WinUI Logo](https://learn.microsoft.com/en-us/windows/apps/images/logo-winui.png)

## What is the Uno Platform?

Uno Platform is a cross-platform application framework which lets you write an application once in XAML and C#, and deploy it to any target platform.

Uno Platform's application API is compatible with Microsoft's WinUI 3 API and the older UWP application API. In fact, when your application runs on Windows, it's just an ordinary WinUI 3 (or UWP) application.

This means that existing WinUI or UWP code is compatible with the Uno Platform. Existing WinUI or UWP libraries can be recompiled for use in Uno Platform applications. A number of 3rd-party libraries have been ported to Uno Platform.

Learn more [here](https://platform.uno/docs/articles/what-is-uno.html).

![Uno Platform Diagram](https://platform.uno/docs/articles/Assets/high-level-architecture-copy.png)

## What is WebAssembly?

WebAssembly (also known as WASM) was launched in 2017 as a binary instruction format for a stack-based virtual machine, developed to run in modern web browsers to provide “efficient execution and compact representation of code on modern processors including in a web browser.”

With WebAssembly you can develop high-performance web applications using open web platform technologies and various languages. WebAssembly makes it possible to create video, audio, graphics, 3D environments, multimedia games, cryptographic computations, and even portable language implementations. On top of that, WebAssembly offers serious performance gains over the standard tools. It is not designed to be used as a language itself, but rather as an effective compilation target for languages like C, C++, and Rust (all of which are very fast by design).

Learn more [here](https://webassembly.org/).

![WebAssembly Diagram](docs/images/CSharp-to-WASM.png)
