﻿using System.Windows;
using Livet.Messaging;
using Livet.Messaging.IO;
using Microsoft.Win32;

namespace Livet.Behaviors.Messaging.IO
{
    /// <summary>
    ///     「ファイルを開く」ダイアログを表示するアクションです。<see cref="OpeningFileSelectionMessage" />に対応します。
    /// </summary>
    public class OpenFileDialogInteractionMessageAction : InteractionMessageAction<DependencyObject>
    {
        protected override void InvokeAction(InteractionMessage message)
        {
            if (message is OpeningFileSelectionMessage openFileMessage)
            {
                var dialog = new OpenFileDialog
                {
                    FileName = openFileMessage.FileName,
                    InitialDirectory = openFileMessage.InitialDirectory,
                    AddExtension = openFileMessage.AddExtension,
                    Filter = openFileMessage.Filter,
                    Title = openFileMessage.Title,
                    Multiselect = openFileMessage.MultiSelect
                };

                openFileMessage.Response = dialog.ShowDialog().Value ? dialog.FileNames : null;
            }
        }
    }
}