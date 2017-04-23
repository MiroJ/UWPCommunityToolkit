﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

namespace Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarButtons
{
    public class DefaultButton
    {
        public static DefaultButton OfType(ButtonType type)
        {
            return new DefaultButton { Type = type };
        }

        public ButtonType Type { get; set; }

        internal IToolbarItem Button { get; set; }

        public override string ToString()
        {
            return Type.ToString();
        }

        public enum ButtonType
        {
            /// <summary>
            /// Bold Button
            /// </summary>
            Bold,

            /// <summary>
            /// Italics Button
            /// </summary>
            Italics,

            /// <summary>
            /// Strikethrough Button
            /// </summary>
            Strikethrough,

            /// <summary>
            /// Code button
            /// </summary>
            Code,

            /// <summary>
            /// Quote Button
            /// </summary>
            Quote,

            /// <summary>
            /// Link Button
            /// </summary>
            Link,

            /// <summary>
            /// List Button
            /// </summary>
            List,

            /// <summary>
            /// OrderedList
            /// </summary>
            OrderedList
        }
    }
}