// <copyright file="JSInterop.Generated.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

/// <summary>
/// This file is auto-generated by a build task. It shouldn't be edited by hand.
/// </summary>
namespace SuperBasic.Editor.Interop
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.JSInterop;
    using SuperBasic.Compiler.Services;

    internal static class JSInterop
    {
        public static class Layout
        {
            public static async Task InitializeWebView(string locale, string title)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Layout.initializeWebView", locale, title).ConfigureAwait(false);
            }

            public static async Task OpenExternalLink(string url)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Layout.openExternalLink", url).ConfigureAwait(false);
            }

            public static async Task AttachSideBarEvents(ElementRef upButton, ElementRef scrollContentsArea, ElementRef downButton)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Layout.attachSideBarEvents", upButton, scrollContentsArea, downButton).ConfigureAwait(false);
            }
        }

        public static class Monaco
        {
            public static async Task Initialize(ElementRef editorElement, string initialValue, bool isReadOnly)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.initialize", editorElement, initialValue, isReadOnly).ConfigureAwait(false);
            }

            public static async Task Dispose()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.dispose").ConfigureAwait(false);
            }

            public static async Task SelectRange(MonacoRange range)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.selectRange", range).ConfigureAwait(false);
            }

            public static async Task SaveToFile()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.saveToFile").ConfigureAwait(false);
            }

            public static async Task OpenFile(string confirmationMessage)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.openFile", confirmationMessage).ConfigureAwait(false);
            }

            public static async Task ClearEditor(string confirmationMessage)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.clearEditor", confirmationMessage).ConfigureAwait(false);
            }

            public static async Task Cut()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.cut").ConfigureAwait(false);
            }

            public static async Task Copy()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.copy").ConfigureAwait(false);
            }

            public static async Task Paste()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.paste").ConfigureAwait(false);
            }

            public static async Task Undo()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.undo").ConfigureAwait(false);
            }

            public static async Task Redo()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.redo").ConfigureAwait(false);
            }
        }

        public static class TextDisplay
        {
            public static async Task Initialize(ElementRef textDisplayElement)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.initialize", textDisplayElement).ConfigureAwait(false);
            }

            public static async Task Dispose()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.dispose").ConfigureAwait(false);
            }

            public static async Task ScrollTo(ElementRef element)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.scrollTo", element).ConfigureAwait(false);
            }

            public static async Task SetBackgroundColor(string hexColor)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.setBackgroundColor", hexColor).ConfigureAwait(false);
            }
        }

        public static class Controls
        {
            public static async Task Initialize(ElementRef graphicsDisplayElement)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.initialize", graphicsDisplayElement).ConfigureAwait(false);
            }

            public static async Task AddButton(string controlName, string caption, decimal left, decimal top)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.addButton", controlName, caption, left, top).ConfigureAwait(false);
            }

            public static async Task AddMultiLineTextBox(string controlName, decimal left, decimal top)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.addMultiLineTextBox", controlName, left, top).ConfigureAwait(false);
            }

            public static async Task AddTextBox(string controlName, decimal left, decimal top)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.addTextBox", controlName, left, top).ConfigureAwait(false);
            }

            public static async Task HideControl(string controlName)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.hideControl", controlName).ConfigureAwait(false);
            }

            public static async Task Move(string controlName, decimal x, decimal y)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.move", controlName, x, y).ConfigureAwait(false);
            }

            public static async Task Remove(string controlName)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.remove", controlName).ConfigureAwait(false);
            }

            public static async Task SetButtonCaption(string controlName, string caption)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.setButtonCaption", controlName, caption).ConfigureAwait(false);
            }

            public static async Task SetSize(string controlName, decimal width, decimal height)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.setSize", controlName, width, height).ConfigureAwait(false);
            }

            public static async Task SetTextBoxText(string controlName, string text)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.setTextBoxText", controlName, text).ConfigureAwait(false);
            }

            public static async Task ShowControl(string controlName)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Controls.showControl", controlName).ConfigureAwait(false);
            }
        }
    }
}