using Microsoft.UI.Content;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.Storage.Search;

namespace TumeraAI.Main.Types
{
    public class Message: INotifyPropertyChanged
    {
        public Roles Role { get; set; }
        public DateTime Time => DateTime.Now;
        public string FormattedTime => Time.ToString("MMM dd yyyy, hh:mm tt");
        private string _content = "";
        public string Content
        {
            get => _content;
            set
            {
                if (_content != value)
                {
                    _content = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsAIResponse => Role == Roles.ASSISTANT;
        public string ModelUsed = "";
        public string Info
        {
            get
            {
                if (IsAIResponse)
                {
                    return $"{ModelUsed} • {FormattedTime}";
                }
                return $"{FormattedTime}";
            }
        } 

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
