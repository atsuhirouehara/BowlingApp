using BowlingApp.Domain;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace BowlingApp.Presentation
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        public ICommand StartButtonClickCommand 
        { 
            get { return new BaseICommand(OnStartButton_Click); }
        }

        /// <summary>
        /// スタートボタン押下時のメソッド
        /// </summary>
        private void OnStartButton_Click()
        {
            Bowling bowling = new Bowling();
            BindText = bowling.MethodSumple();
        }

        // Labelの内容が変わったら変更を通知する処理
        string _bindText;
        public string BindText
        {
            get
            {
                return this._bindText;
            }
            set
            {
                this._bindText = value;
                this.OnPropertyChanged(nameof(BindText));
                return;
            }
        }

        // 変更通知用メソッド
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
