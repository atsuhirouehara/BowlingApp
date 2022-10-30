using System;
using Prism.Commands;

namespace BowlingApp.ViewModels
{
    internal class delegatecommand : DelegateCommand
    {
        public delegatecommand(Action executeMethod) : base(executeMethod)
        {
        }
    }
}