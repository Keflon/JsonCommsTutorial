using System;
using System.Collections.Generic;
using System.Text;

namespace JsonCommsTutorial.Models
{
    public class StartupCheckResponse
    {
        public StartupCheckResponse(
            bool canProceed, 
            string title, 
            string message, 
            string goToStoreButtonText, 
            string proceedButtonText, 
            long messageIndex, 
            string appStoreUrl
            )
        {
            CanProceed = canProceed;
            Message = message;
            Title = title;
            GoToStoreButtonText = goToStoreButtonText;
            ProceedButtonText = proceedButtonText;
            MessageIndex = messageIndex;
            AppStoreUrl = appStoreUrl;
        }

        public bool CanProceed { get; }
        public string Title { get; }
        public string Message { get; }
        public string GoToStoreButtonText { get; }
        public string ProceedButtonText { get; }
        public long MessageIndex { get; }
        public string AppStoreUrl { get; }
    }
}
